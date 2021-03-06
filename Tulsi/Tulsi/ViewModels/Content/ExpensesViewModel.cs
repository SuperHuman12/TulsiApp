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

namespace Tulsi.ViewModels.Content {
    public sealed class ExpensesViewModel : ViewModelBase, IViewModel {

        ObservableCollection<ChartModel> _chartData;
        public ObservableCollection<ChartModel> ChartData {
            get { return _chartData; }
            set { SetProperty(ref _chartData, value); }
        }

        // Navigate back.
        public ICommand NavigateBackCommand { get; private set; }

        /// <summary>
        /// Opens ExpensesListPage.
        /// </summary>
        public ICommand OpenExpensesListCommand { get; private set; }

        /// <summary>
        ///     ctor().
        /// </summary>
        public ExpensesViewModel() {
            ChartData = GetChartData();

            OpenExpensesListCommand = new Command(() => {
                BaseSingleton<ViewSwitchingLogic>.Instance.NavigateTo(ViewType.ExpensesListPage);
            });

            NavigateBackCommand = new Command(() => BaseSingleton<ViewSwitchingLogic>.Instance.NavigateOneStepBack());
        }

        private ObservableCollection<ChartModel> GetChartData() {
             return new ObservableCollection<ChartModel>()
            {
                new ChartModel { Name = "Groceries", Value = 29 },
                new ChartModel { Name = "Utilities", Value = 16 },
                new ChartModel { Name = "Car", Value = 14 },
                new ChartModel { Name = "Payments", Value = 12 },
                new ChartModel { Name = "iTunes", Value = 10 },
                new ChartModel { Name = "House", Value = 8 },
                new ChartModel { Name = "Wardrobe", Value = 6 },
                new ChartModel { Name = "Food", Value = 5 },
            };
        }

        public void Dispose() {
            ChartData.Clear();
        }
    }
}
