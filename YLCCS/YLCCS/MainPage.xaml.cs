namespace YLCCS
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Navigation;
    using YLCCS.LoginUI;
    using System;
    using YLCCS.Views;
    using System.Linq;

    /// <summary>
    /// <see cref="UserControl"/> class providing the main UI for the application.
    /// </summary>
    public partial class MainPage : UserControl
    {
        /// <summary>
        /// Creates a new <see cref="MainPage"/> instance.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
            //this.loginContainer.Child = new LoginStatus();
            //(StockPanel)this.loginContainer.Child
            this.spLoginStatus.Children.Add(new LoginStatus());
            WebContext.Current.Authentication.LoggedIn += new EventHandler<System.ServiceModel.DomainServices.Client.ApplicationServices.AuthenticationEventArgs>(Authentication_LoggedIn);
            WebContext.Current.Authentication.LoggedOut += new EventHandler<System.ServiceModel.DomainServices.Client.ApplicationServices.AuthenticationEventArgs>(Authentication_LoggedOut);
        }

        void Authentication_LoggedOut(object sender, System.ServiceModel.DomainServices.Client.ApplicationServices.AuthenticationEventArgs e)
        {

            InfoView.Visibility = System.Windows.Visibility.Collapsed;
            InfoInput.Visibility = System.Windows.Visibility.Collapsed;

        }

        void Authentication_LoggedIn(object sender, System.ServiceModel.DomainServices.Client.ApplicationServices.AuthenticationEventArgs e)
        {
            if (WebContext.Current.User.Roles.SingleOrDefault(c => c == "内部用户") == null)
            {
                InfoView.Visibility = System.Windows.Visibility.Visible;
                InfoInput.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                InfoView.Visibility = System.Windows.Visibility.Visible;
                InfoInput.Visibility = System.Windows.Visibility.Visible;
            }
        }

        /// <summary>
        /// After the Frame navigates, ensure the <see cref="HyperlinkButton"/> representing the current page is selected
        /// </summary>
        private void ContentFrame_Navigated(object sender, NavigationEventArgs e)
        {
            foreach (UIElement child in LinksStackPanel.Children)
            {
                HyperlinkButton hb = child as HyperlinkButton;
                if (hb != null && hb.NavigateUri != null)
                {
                    if (hb.NavigateUri.ToString().Equals(e.Uri.ToString()))
                    {
                        VisualStateManager.GoToState(hb, "ActiveLink", true);
                    }
                    else
                    {
                        VisualStateManager.GoToState(hb, "InactiveLink", true);
                    }
                }
            }
        }

        /// <summary>
        /// If an error occurs during navigation, show an error window
        /// </summary>
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            e.Handled = true;
            ErrorWindow.CreateNew(e.Exception);
        }

        private void hyperlinkButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hyperlinkButton1_Click_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(WebContext.Current.User.DisplayName);
            CustomerDataEditor2 cde = new CustomerDataEditor2();
            cde.Show();

        }

        private void hbInfoShow_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}