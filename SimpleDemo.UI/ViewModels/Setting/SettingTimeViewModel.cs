using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using SimpleDemo.Model;
using SimpleDemo.Common;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class SettingTimeViewModel
    {
        public PortElement LightSettingItem { get; set; } = new PortElement();
    }
}