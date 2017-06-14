using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using SimpleDemo.Model;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class SettingPortViewModel
    {

        public LightSetting LightSettingItem { get; set; } = new LightSetting();
    }

    

}