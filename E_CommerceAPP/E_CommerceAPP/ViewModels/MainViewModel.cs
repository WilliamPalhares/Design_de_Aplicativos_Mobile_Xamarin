using System;
using System.Collections.ObjectModel;

namespace E_CommerceAPP.ViewModels
{
    public class MainViewModel
    {
        #region Properties

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        #endregion

        #region Construct

        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
        }
        
        #endregion

        #region Methods

        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_product.png",
                PageName = "ProductPage",
                Title = "Produtos",
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_client.png",
                PageName = "CustomerPage",
                Title = "Clientes",
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_orders.png",
                PageName = "OrderPage",
                Title = "Vendas",
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_purchase.png",
                PageName = "PurchasePage",
                Title = "Compras",
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_config.png",
                PageName = "ConfigPage",
                Title = "Configurações",
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_sinc.png",
                PageName = "SincPage",
                Title = "Sincronização",
            });

            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_exit.png",
                PageName = "LogoutPage",
                Title = "Sair",
            });
        }

        #endregion
    }
}
