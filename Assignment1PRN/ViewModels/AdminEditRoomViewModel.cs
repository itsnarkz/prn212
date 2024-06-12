using System.Windows.Input;
using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;

namespace Assignment1PRN.ViewModels;

public class AdminEditRoomViewModel:ViewModel
{
    private string roomNumber;
    private string roomDetailDescription;
    private int? roomMaxCapacity ;
    private int roomTypeId;
    private byte? _status;
    private decimal? roomPricePerDay;
    private RoomService _roomService;
    public string RoomDetailDescription { get=>roomDetailDescription; set=>SetField(ref roomDetailDescription,value); }
    
    public string RoomNumber { get=>roomNumber; set=>SetField(ref roomNumber,value); }
    
    public int? RoomMaxCapacity { get=>roomMaxCapacity; set=>SetField(ref roomMaxCapacity,value); }
    
    public int RoomTypeId { get=>roomTypeId; set=>SetField(ref roomTypeId,value); }
    
    public decimal? RoomPricePerDay
    {
        get => roomPricePerDay;
        set => SetField(ref roomPricePerDay, value);
    }
    
    public byte? Status
    {
        get => _status;
        set => SetField(ref _status, value);
    }
    
    public ICommand Confirm { get; set; }
    public ICommand Cancel { get; set; }

    public AdminEditRoomViewModel(RoomInformation roomInformation,Navigation navigation)
    {
        _roomService = new RoomService();
        RoomNumber = roomInformation.RoomNumber;
        RoomDetailDescription = roomInformation.RoomDetailDescription;
        RoomMaxCapacity = roomInformation.RoomMaxCapacity;
        RoomTypeId = roomInformation.RoomTypeId;
        Status = roomInformation.RoomStatus;
        RoomPricePerDay = roomInformation.RoomPricePerDay;
        Confirm = new BaseCommand(() => DoConfirm(roomInformation,navigation));
        Cancel = new BaseCommand(() => DoCancel(navigation));
    }

    void DoConfirm(RoomInformation roomInformation,Navigation navigation)
    {
        _roomService.UpdateRoom(roomInformation.RoomId,RoomNumber,roomDetailDescription,roomMaxCapacity,roomTypeId,_status, roomPricePerDay);
        navigation.ViewModel = new RoomManageViewModel(navigation);
    }

    void DoCancel(Navigation navigation)
    {
        navigation.ViewModel = new RoomManageViewModel(navigation);
    }
}