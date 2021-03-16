using Core.Interfaces;
using Data.DbContext;
using Data.ViewModels;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PaymentService : IPaymentService
    {
        private E_commerceDB _context;
        public PaymentService(E_commerceDB context)
        {
            _context = context;
        }
        public  async Task <dynamic> PayAsync(PaymentVM vm)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51IVhxWAo5kvEMVAPoxtaBukO4AIGoBmipAsWXSrkPYdrDlU1OvupScMK0gaEUz4CHczcuGwVq2MXVyBp5coggJrd00AEA7SqHY";
                var optionsToken = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = vm.CardNumber,
                        ExpMonth = vm.Month,
                        ExpYear = vm.Year,
                        Cvc = vm.Cvc
                    }
                };
                var serviceToken = new TokenService();
                Token stripeToken = await serviceToken.CreateAsync(optionsToken);
                var options = new ChargeCreateOptions
                {
                    Amount =(int)vm.TotalPrice ,
                    Currency = "usd",
                    Description = "test",
                    Source = stripeToken.Id
                };
                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);
                if (charge.Paid)
                {
                    return "Succes";
                }
                else
                    return "Failed";

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
