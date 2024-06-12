using System.Windows.Input;
using Assignment1PRN.Command;
using Assignment1PRN.Util;
using Assignment1PRN.ViewModels;

namespace Assignment1PRN.ViewModels;

public class AdminWorkSpaceViewModel:ViewModel
{
    public ICommand ManageUser { get; set; }
    public ICommand ManageRoom { get; set; }
    public ICommand Report { get; set; }

    public void ToUserManage(Navigation navigation)
    {
        navigation.ViewModel = new UserManageViewModel(navigation);
    }

    public void ToRoomManage(Navigation navigation)
    {
        navigation.ViewModel = new RoomManageViewModel(navigation);
    }

    public void ToReport(Navigation navigation)
    {
        navigation.ViewModel = new ReportViewModel();
    }

    public AdminWorkSpaceViewModel(Navigation navigation)
    {
        ManageUser = new BaseCommand(()=>ToUserManage(navigation));
        ManageRoom = new BaseCommand(()=>ToRoomManage(navigation));
        Report = new BaseCommand(()=>ToReport(navigation));
    }
}