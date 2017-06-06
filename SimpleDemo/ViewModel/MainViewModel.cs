﻿using GalaSoft.MvvmLight;

namespace SimpleDemo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        //public MainViewModel(IDataService dataService)
        //{
        //    _dataService = dataService;
        //    _dataService.GetData(
        //        (item, error) =>
        //        {
        //            if (error != null)
        //            {
        //                // Report error here
        //                return;
        //            }

        //            WelcomeTitle = item.Title;
        //        });
        //}

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}

        public MainViewModel()
        {
            using (var dc = new DemoWCF.Service1Client())
            {
                var a = dc.GetData(2);
            }

            using (var api = new WebAPI.Service1SoapClient())
            {
                var asaaa = api.init("asdaaa");
            }

        }

    }
}