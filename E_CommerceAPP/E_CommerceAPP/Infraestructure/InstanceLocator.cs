using E_CommerceAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceAPP.Infraestructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
