using Microsoft.ReactNative;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Rn
{
    public sealed partial class RNApp : UserControl
    {
        public RNApp()
        {
            this.InitializeComponent();
            //this.InitReactNative();
        }

        private void InitReactNative()
        {
            //this.RNRoot.ComponentName = "RNApp";
            //ReactInstanceSettings settings = new ReactInstanceSettings();
            //settings.UseFastRefresh = true;
            //settings.UseDeveloperSupport = true;
            //settings.SourceBundleHost = "localhost";
            //settings.SourceBundlePort = 8081;
            //settings.PackageProviders.Add(new ReactPackageProvider());

            //ReactNativeHost host = new ReactNativeHost();
            //host.InstanceSettings = settings;

            //this.RNRoot.ReactNativeHost = host;

            //host.LoadInstance();
        }
    }
}
