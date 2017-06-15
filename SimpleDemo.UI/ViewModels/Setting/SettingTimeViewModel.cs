using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using SimpleDemo.Model;
using SimpleDemo.Common;
using System.Collections.Generic;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class SettingTimeViewModel
    {

        public List<PortElement> Items { get; set; } = new List<PortElement>();

        public SettingTimeViewModel()
        {
            Items.Add(new PortElement() { ProtocolType = "1213" });
            Items.Add(new PortElement() { ProtocolType = "aa" });
            Items.Add(new PortElement() { ProtocolType = "ss" });
        }

    }
}