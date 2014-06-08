using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace TestWinRTPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SamplePage02 : Page
    {
        public SamplePage02()
        {
            this.InitializeComponent();
            this.LayoutUpdated += OnLayoutUpdated;
        }

        private void OnLayoutUpdated(object sender, object e)
        {
            Debug.WriteLine("Sample Page 02 LayoutUpdated.");
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Windows.Phone.UI.Input.HardwareButtons.BackPressed += OnBackPressed;
        }

        private void OnBackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            Windows.Phone.UI.Input.HardwareButtons.BackPressed -= OnBackPressed;

            if (this.Frame.CanGoBack)
            {
                e.Handled = true;
                this.Frame.GoBack();
            }
        }

        ~SamplePage02()
        {
            Debug.WriteLine("SamplePage02 destroyed.");
        }
    }
}