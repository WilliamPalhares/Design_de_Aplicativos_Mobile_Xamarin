using E_CommerceAPP.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace E_CommerceAPP
{
	public partial class App : Application
	{
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }

        public App ()
		{
			InitializeComponent ();

            MainPage = new LoginPage();
		}
    }
}