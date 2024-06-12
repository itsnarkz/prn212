using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment1PRN.ViewModels;

public class UserManageViewModel : ViewModel
{
    private CustomerService customerService;
    public ObservableCollection<Customer> Customers { get; set; }
    private int selectedId;
    public int SelectedId {get=>selectedId;
        set => SetField(ref selectedId, value);
    }
    public ICommand Delete { get; set; }
    public ICommand Update { get; set; }
    public ICommand GoBack { get; set; }
    public UserManageViewModel(Navigation navigation)
    {
        customerService = new CustomerService();
        Customers = new ObservableCollection<Customer>(customerService.GetAll());
        Delete = new ParamCommand((customerId)=>navigation.ViewModel=new ConfirmDeleteViewModel(new BaseCommand(() => DoConfirm((int)customerId, navigation)),new BaseCommand(() => DoCancel(navigation))));
        Update = new ParamCommand((customerId) => DoUpdate((int)customerId, navigation));
        GoBack = new BaseCommand(() => DoGoBack(navigation));
    }
    public void DoConfirm(int customerId,Navigation navigation)
    { 
        customerService.DeleteCustomer(customerId);
        navigation.ViewModel = new UserManageViewModel(navigation);

    }
    public void DoCancel(Navigation navigation) { 
        navigation.ViewModel = new UserManageViewModel(navigation);
    }
    public void DoUpdate(int customerId, Navigation navigation)
    {
        navigation.ViewModel = new AdminEditUserViewModel(customerService.GetById(customerId), navigation);
    }

    public void DoGoBack(Navigation navigation)
    {
        navigation.ViewModel = new AdminWorkSpaceViewModel(navigation);
    }


}