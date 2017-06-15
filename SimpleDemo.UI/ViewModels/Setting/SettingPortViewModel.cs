using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using SimpleDemo.Model;
using SimpleDemo.Common;
using System.Collections.Generic;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class SettingPortViewModel
    {

        //public LightSetting LightSettingItem { get; set; }

        //public PortElement Items { get; set; } = new PortElement();

        public List<PortElement> Items { get; set; } = new List<PortElement>();

        public SettingPortViewModel()
        {
            //LightSettingItem = GlobalConfig.GetInstance().GetLightSetting();
        }

       

    }




    

}