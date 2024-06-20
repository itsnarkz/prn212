using System.Windows.Input;
using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;

namespace Assignment1PRN.ViewModels;

public class AdminEditUserViewModel:ViewModel
{
    private string _customerFullName;
    private string _telephone;
    private string _emailAddress;
    private DateOnly? _customerBirthday;
    private int _status;
    private CustomerService _customerService;
    public string CustomerFullName { get=>_customerFullName; set=>SetField(ref _customerFullName,value); }
    
    public string Telephone { get=>_telephone; set=>SetField(ref _telephone,value); }
    
    public string EmailAddress { get=>_emailAddress; set=>SetField(ref _emailAddress,value); }
    
    public DateOnly? CustomerBirthday { get=>_customerBirthday; set=>SetField(ref _customerBirthday,value); }
    
    public int Status
    {
        get => _status;
        set => SetField(ref _status, value);
    }
    
    public ICommand Confirm { get; set; }
    public ICommand Cancel { get; set; }

    public AdminEditUserViewModel(Customer customer,Navigation navigation)
    {
        _customerService = new CustomerService();
        _customerFullName = customer.CustomerFullName;
        _telephone = customer.Telephone;
        _emailAddress = customer.EmailAddress;
        _customerBirthday = customer.CustomerBirthday;
        _status = (int)customer.CustomerStatus;
        Confirm = new BaseCommand(() => DoConfirm(customer,navigation));
        Cancel = new BaseCommand(() => DoCancel(navigation));
    }

    void DoConfirm(Customer customer,Navigation navigation)
    {
        _customerService.UpdateCustomer(customer.CustomerId,_customerFullName,_telephone,_emailAddress,_customerBirthday,_status);
        navigation.ViewModel = new UserManageViewModel(navigation);
    }

    void DoCancel(Navigation navigation)
    {
        navigation.ViewModel = new UserManageViewModel(navigation);
    }
}