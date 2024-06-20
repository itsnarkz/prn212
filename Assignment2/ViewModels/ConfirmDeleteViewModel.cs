using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment1PRN.ViewModels
{
    public class ConfirmDeleteViewModel:ViewModel
    {
        public ICommand Confirm { get; set; }
        public ICommand Cancel { get; set; }
        public ConfirmDeleteViewModel(ICommand confirm, ICommand cancel)
        {
            Confirm = confirm;
            Cancel = cancel;
        }
    }
}
