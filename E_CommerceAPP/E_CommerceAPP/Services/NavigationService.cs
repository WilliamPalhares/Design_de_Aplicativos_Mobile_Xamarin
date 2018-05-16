using E_CommerceAPP.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPP.Services
{
    public class NavigationService
    {
        public async Task Navigate(string PageName)
        {
            App.Master.IsPresented = false;

            switch (PageName)
            {
                case "CustomerPage":
                    await App.Navigator.PushAsync(new CustomerPage());
                    break;

                case "ProductPage":
                    await App.Navigator.PushAsync(new ProductPage());
                    break;

                case "PurchasePage":
                    await App.Navigator.PushAsync(new PurchasePage());
                    break;

                case "OrderPage":
                    await App.Navigator.PushAsync(new OrderPage());
                    break;

                case "ConfigPage":
                    await App.Navigator.PushAsync(new ConfigPage());
                    break;

                case "SincPage":
                    await App.Navigator.PushAsync(new SincPage());
                    break;

                case "LogoutPage":
                    
                    break;

                default:
                    break;
            }
        }
    }
}
