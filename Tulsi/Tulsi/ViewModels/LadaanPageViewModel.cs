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
    public class LadaanPageViewModel : ViewModelBase, IViewModel {

        ObservableCollection<LaddanData> _ladaanSource;
        public ObservableCollection<LaddanData> LadaanSource {
            get { return _ladaanSource; }
            set { SetProperty(ref _ladaanSource, value); }
        }

        LadaanEntry _selectedMenuItem;
        public LadaanEntry SelectedMenuItem {
            get { return _selectedMenuItem; }
            set {
                if (SetProperty(ref _selectedMenuItem, value) && value != null) {
                    // Do something
                }
            }
        }

        //  Navigate to SearchPage.
        public ICommand DisplaySearchPageCommand { get; private set; }

        // Navigate back.
        public ICommand NavigateBackCommand { get; private set; }

        /// <summary>
        ///     ctor().
        /// </summary>
        public LadaanPageViewModel() {

            LadaanSource = new ObservableCollection<LaddanData>() {
                new LaddanData{
                    Date =DateTime.Now,
                    Data = new List<LadaanEntry>{
                        new LadaanEntry { Code = "NS Cuttack", Number = "29" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" },
                        new LadaanEntry { Code = "AR Cuttack", Number = "28" },
                        new LadaanEntry { Code = "NS Cuttack", Number = "28" }
                }},
                new LaddanData{
                    Date =DateTime.Now,
                    Data = new List<LadaanEntry>{
                        new LadaanEntry { Code = "NS Cuttack", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" },
                        new LadaanEntry { Code = "AR Cuttack", Number = "28" },
                        new LadaanEntry { Code = "AR Cuttack", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" },
                        new LadaanEntry { Code = "AR Cuttack", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" }
                }},
                new LaddanData{
                    Date =DateTime.Now,
                    Data = new List<LadaanEntry>{
                        new LadaanEntry { Code = "NS Cuttack", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" },
                        new LadaanEntry { Code = "AR Cuttack", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" }
                }},
                new LaddanData{
                    Date =DateTime.Now,
                    Data = new List<LadaanEntry>{
                        new LadaanEntry { Code = "NS Cuttack", Number = "28" },
                        new LadaanEntry { Code = "SFT Bharampur", Number = "28" },
                        new LadaanEntry { Code = "AR Cuttack", Number = "28" }
                }}
            };

            DisplaySearchPageCommand = new Command(() => BaseSingleton<ViewSwitchingLogic>.Instance.NavigateTo(ViewType.SearchPage));

            NavigateBackCommand = new Command(() => BaseSingleton<ViewSwitchingLogic>.Instance.NavigateOneStepBack());
        }

        public void Dispose() {
            LadaanSource.Clear();
        }
    }
}