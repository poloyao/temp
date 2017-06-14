using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using SimpleDemo.Model;
using SimpleDemo.Common;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class SettingPortViewModel
    {

        public LightSetting LightSettingItem { get; set; }
        

        public SettingPortViewModel()
        {
            LightSettingItem = GlobalConfig.GetInstance().GetLightSetting();
        }

    }

    

}