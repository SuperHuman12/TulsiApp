﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulsi.NavigationFramework;
using Xamarin.Forms;
using Tulsi.Controls;
using Tulsi.Helpers;

namespace Tulsi {
    public partial class PasswordRecoveryPage : ContentPage, IView {
        public PasswordRecoveryPage() {
            InitializeComponent();

            SubmitLink.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
            DescriptionLabel.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            Logo.Source = ImageSource.FromResource("Tulsi.Images.logo.png");

            //Taps
            TapGestureRecognizer tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += (s, e) => {
                DisplayAlert("Navigation", "Password recovery action", "OK");
                //DashboardPage dp = new DashboardPage();
                //Application.Current.MainPage = new NavigationPage(dp);
            };
            SubmitLink.GestureRecognizers.Add(tapGestureRecognizer1);


            EntryEx EmailEntry = new EntryEx() {
                BorderWidth = 2,
                BorderRadius = 50,
                BorderColor = Color.FromHex("#d9d9d9"),
                PlaceholderColor = Color.FromHex("#d9d9d9"),
                Placeholder = "Email",
                HeightRequest = 20,
                LeftPadding = 30,
                RightPadding = 30,
                Margin = 10,
                FontSize = 18,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Keyboard = Keyboard.Email,
            };
            LoginGrid.Children.Add(EmailEntry);
            Grid.SetRow(EmailEntry, 4);
            Grid.SetColumn(EmailEntry, 1);
        }

        /// <summary>
        /// Make some visual changes of current page through navigating process (hide side menu or smt...)
        /// </summary>
        public void ApplyVisualChangesWhileNavigating() {
            
        }

        public void Dispose() {
            
        }

        /// <summary>
        ///     Occurs only for Android (not for iOS).
        ///     False navigate out from page, true - staying in this page.
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed() {
            BaseSingleton<ViewSwitchingLogic>.Instance.NavigateOneStepBack();
            return true;
        }
    }
}
