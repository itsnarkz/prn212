using Assignment1PRN.Command;
using Assignment1PRN.Models;
using Assignment1PRN.Service;
using Assignment1PRN.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Assignment1PRN.ViewModels
{
    public class AdminAddRoomViewModel:ViewModel
    {
        private string roomNumber;
        private string roomDetailDescription;
        private int? roomMaxCapacity;
        private int roomTypeId;
        private byte? _status;
        private decimal? roomPricePerDay;
        private RoomService _roomService;
        public string RoomDetailDescription { get => roomDetailDescription; set => SetField(ref roomDetailDescription, value); }

        public string RoomNumber { get => roomNumber; set => SetField(ref roomNumber, value); }

        public int? RoomMaxCapacity { get => roomMaxCapacity; set => SetField(ref roomMaxCapacity, value); }

        public int RoomTypeId { get => roomTypeId; set => SetField(ref roomTypeId, value); }

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

        public AdminAddRoomViewModel( Navigation navigation)
        {
            _roomService = new RoomService();
            Confirm = new BaseCommand(() => DoConfirm( navigation));
            Cancel = new BaseCommand(() => DoCancel(navigation));
        }

        void DoConfirm(Navigation navigation)
        {
            _roomService.AddRoom(RoomNumber, roomDetailDescription, roomMaxCapacity, roomTypeId, _status, roomPricePerDay);
            navigation.ViewModel = new RoomManageViewModel(navigation);
        }

        void DoCancel(Navigation navigation)
        {
            navigation.ViewModel = new RoomManageViewModel(navigation);
        }
    }
}
