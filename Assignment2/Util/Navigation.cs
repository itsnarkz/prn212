using Assignment1PRN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1PRN.Util
{
    public class Navigation
    {
        private ViewModel _viewModel;
        public ViewModel ViewModel { get => _viewModel; set
            {
                _viewModel = value;
                OnCurrentViewModelChanged();
            } }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;
    }
}
