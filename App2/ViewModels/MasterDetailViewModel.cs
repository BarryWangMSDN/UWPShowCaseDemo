﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using App2.Core.Models;
using App2.Core.Services;

using GalaSoft.MvvmLight;

using Microsoft.Toolkit.Uwp.UI.Controls;

namespace App2.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private SampleOrder _selected;

        public SampleOrder Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

        public MasterDetailViewModel()
        {
        }

        public async Task LoadDataAsync(MasterDetailsViewState viewState)
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetMasterDetailDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (viewState == MasterDetailsViewState.Both)
            {
                Selected = SampleItems.First();
            }
        }
    }
}
