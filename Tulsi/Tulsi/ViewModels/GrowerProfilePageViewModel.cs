﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tulsi.Helpers;
using Tulsi.Model;
using Tulsi.MVVM.Core;
using Tulsi.NavigationFramework;
using Xamarin.Forms;

namespace Tulsi.ViewModels {
    public sealed class GrowerProfilePageViewModel : ViewModelBase, IViewModel {

       ObservableCollection<ProfileTransaction> _transactionsData;
        public ObservableCollection<ProfileTransaction> TransactionsData {
            get { return _transactionsData; }
            set { SetProperty(ref _transactionsData, value); }
        }

        ProfileTransaction _selectedMenuItem;
        public ProfileTransaction SelectedMenuItem {
            get { return _selectedMenuItem; }
            set {
                if (SetProperty(ref _selectedMenuItem, value) && value != null) {
                    // Do something
                }
            }
        }

        public ICommand  CloseCommand { get; private set; }

        /// <summary>
        ///     ctor().
        /// </summary>
        public GrowerProfilePageViewModel() {
            TransactionsData = new ObservableCollection<ProfileTransaction>()
            {
                new ProfileTransaction { Code = "SKC", Number = "28", IsP=true, Quantity="8,200" },
                new ProfileTransaction { Code = "SKC", Number = "28", IsP=false, Quantity="8,200" },
                new ProfileTransaction{ Code = "SKC", Number = "28", IsP=true, Quantity="8,200" },
                new ProfileTransaction { Code = "SKC", Number = "28", IsP=true, Quantity="8,200" },
            };

            CloseCommand = new Command(() => BaseSingleton<ViewSwitchingLogic>.Instance.NavigateOneStepBack());
        }

        public void Dispose() {
            
        }

        public void ReSubscribe() {
            
        }
    }
}
