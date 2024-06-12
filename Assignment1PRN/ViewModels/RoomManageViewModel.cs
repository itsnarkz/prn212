using System.Collections.ObjectModel;
using System.Windows.Input;
using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;


namespace Assignment1PRN.ViewModels;

public class RoomManageViewModel:ViewModel
{
    private RoomService _roomService;
    public ObservableCollection<RoomInformation> RoomInformations { get; set; }
    public ICommand Delete { get; set; }
    public ICommand Update { get; set; }
    public ICommand GoBack { get; set; }
    public RoomManageViewModel(Navigation navigation)
    {
        _roomService = new RoomService();
        RoomInformations = new ObservableCollection<RoomInformation>(_roomService.GetAllRoomInformations());
        Delete = new ParamCommand((id)=>navigation.ViewModel=new ConfirmDeleteViewModel(new BaseCommand(() => DoConfirm((int)id, navigation)),new BaseCommand(() => DoCancel(navigation))));
        Update = new ParamCommand((id) => DoUpdate((int)id, navigation));
        GoBack = new BaseCommand(() => DoGoBack(navigation));
    }
    public void DoConfirm(int roomId,Navigation navigation)
    { 
        _roomService.DeleteRoom(roomId);
        navigation.ViewModel = new RoomManageViewModel(navigation);

    }
    public void DoCancel(Navigation navigation) { 
        navigation.ViewModel = new RoomManageViewModel(navigation);
    }
    public void DoUpdate(int id, Navigation navigation)
    {
        navigation.ViewModel = new AdminEditRoomViewModel(_roomService.GetRoomInformation(id), navigation);
    }

    public void DoGoBack(Navigation navigation)
    {
        navigation.ViewModel = new AdminWorkSpaceViewModel(navigation);
    }
}