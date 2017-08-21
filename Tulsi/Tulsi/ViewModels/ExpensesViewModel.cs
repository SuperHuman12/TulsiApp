﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulsi.Model;
using Tulsi.MVVM.Core;
using Tulsi.NavigationFramework;
using Tulsi.Helpers;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tulsi.ViewModels {
    public class ExpensesViewModel : ViewModelBase,IViewModel {
        /// <summary>
        /// Public ctor.
        /// </summary>
        public ExpensesViewModel() {
            ChartData = new List<ChartModel>()
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

            OpenExpensesListCommand = new Command(() => {
                BaseSingleton<ViewSwitchingLogic>.Instance.NavigateTo(ViewType.ExpensesListPage);
            });
        }

        /// <summary>
        /// 
        /// </summary>
        public List<ChartModel> ChartData { get; private set; }

        /// <summary>
        /// Opens ExpensesListPage.
        /// </summary>
        public ICommand OpenExpensesListCommand { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose() {
            
        }
    }
}
