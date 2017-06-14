using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.Generic;
using DevExpress.Mvvm.POCO;
using System.ComponentModel.DataAnnotations;

namespace SimpleDemo.UI.ViewModels
{
    [POCOViewModel]
    public class SettingManageViewModel
    {
        
        public List<ModuleInfo> Menu { get; set; }


        [Required]
        protected virtual ICurrentWindowService CurrentWindowService { get { return null; } }
        protected virtual ISplashScreenService SplashScreenService { get { return this.GetService<ISplashScreenService>(); } }


        public SettingManageViewModel()
        {
            Menu = new List<ModuleInfo>()
            {
                 ViewModelSource.Create(()=>new ModuleInfo("SettingBasicView",this,"基本信息")).SetIcon("setting"),
                 ViewModelSource.Create(()=>new ModuleInfo("SettingTimeView",this,"时间参数")).SetIcon("time"),
                 ViewModelSource.Create(()=>new ModuleInfo("SettingPortView",this,"串口设置")).SetIcon("port"),
                 ViewModelSource.Create(()=>new ModuleInfo("SettingLineView",this,"通道管理")).SetIcon("line"),
            };
        }

    }
}