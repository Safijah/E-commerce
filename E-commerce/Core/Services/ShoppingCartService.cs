using Core.Interfaces;
using Data.DbContext;
using Data.ViewModels;
using Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private E_commerceDB _context;
        private IEmailService _emailService;
        private ICouponService _couponService;
        private IPaymentService _paymentService;
        private UserManager<Account> _userManager;
        public ShoppingCartService(E_commerceDB context, IEmailService emailService, ICouponService couponService, UserManager<Account> userManager,
            IPaymentService paymentService)
        {
            _context = context;
            _emailService = emailService;
            _userManager = userManager;
            _couponService = couponService;
            _paymentService = paymentService;
        }
        public async Task   ShoppingCartAsync(ShoppingCartVM cart)
        {

            Check check = new Check()
            {
                Price = cart.totalprice,
                TotalPrice = cart.totalprice,
                DateTime = DateTime.Now,
                PaymentMethodID = cart.paymentmethodId,
                FirstName=cart.firstname,
                LastName=cart.lastname
            };
            if (cart.coupon != null)
            {
                var coupon = _context.Coupon.First(a => a.Code == cart.coupon);
                coupon.IsValid = false;
                _context.SaveChanges();
                check.CouponID = coupon.ID;
                check.Discount = coupon.Value;
            }
            _context.Add(check);
            _context.SaveChanges();
            ShoppingCart ShoppingCart = new ShoppingCart() 
            {
            TotalPrice=cart.totalprice,
            Date=DateTime.Now,
            Address=cart.adress,
            City=cart.city,
            CustomerID=cart.customerId,
            BranchID=cart.branchId,
            CheckID=check.ID

            };
            _context.Add(ShoppingCart);
            _context.SaveChanges();
            foreach(var x in cart.Orders)
            {
                var order = new Order()
                {
                    Date = DateTime.Now,
                    UnitCost = x.unitcost,
                    TotalPrice=x.totalpriceitem,
                    Quantity = x.quantity,
                    ItemSizeID = x.itemsizeId,
                    ShoppingCartID = ShoppingCart.ID
                };
                var inventory = _context.Inventory.First(a=>a.ID==x.inventoryId && a.ItemSizeID==x.itemsizeId && a.BranchID== cart.branchId);
                inventory.Quantity = inventory.Quantity - x.quantity;
                if (inventory.Quantity <= 0)
                {
                    inventory.IsAvailable = false;
                }
                _context.SaveChanges();
                _context.Add(order);
                _context.SaveChanges();
            }
                var customer = _context.Customer.First(a => a.ID == ShoppingCart.CustomerID);
                customer.TotalSpent += ShoppingCart.TotalPrice;
            if(customer.TotalSpent>=1000)
            {
                Coupon coupon = new Coupon()
                {
                    Code = _couponService.GenerateChode(),
                    IsValid = true,
                    Value = 0.10
                };
                _couponService.AddCoupon(coupon);
                var user = await _userManager.FindByIdAsync(cart.customerId);
                 await _emailService.SendEmailAsync( user.Email, "E-commerce", "<h1>Congratulations, you have won a gift bonus</h1>" +
                    $"<p>Use the following discount code for your next purchase " + coupon.Code + "</p>");
            }
                _context.SaveChanges();
            var vm = new PaymentVM()
            {
                CardNumber = cart.cardnumber,
                Month = cart.month,
                Year = cart.year,
                Cvc = cart.cvc
            };
            if(await _paymentService.PayAsync(vm)=="succes")
            {
                if(_context.CreditCard.FirstOrDefault(a=>a.CardNumber==vm.CardNumber && a.CustomerID==cart.customerId)==null)
                {

                var card = new CreditCard()
                {
                    CardNumber = vm.CardNumber,
                    ExpMonth = vm.Month,
                    ExpYear = vm.Year,
                    Cvc = vm.Cvc,
                    CustomerID = cart.customerId
                };
                    _context.Add(card);
                    _context.SaveChanges();
                }
            }
        }
    }
}
