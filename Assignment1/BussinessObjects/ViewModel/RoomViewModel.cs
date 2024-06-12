using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Repository;
using HE181099_Assignment1.Models;

namespace BussinessObjects.ViewModel
{
    public class RoomViewModel
    {
        public static readonly RoomViewModel Instance;
        public ObservableCollection<RoomInformation> Rooms
        {
            get;
            private set;
        }
        static RoomViewModel()
        {
            if (Instance==null) Instance = new RoomViewModel();
        }
        public void LoadRooms()
        {
            RoomInformationRepository roomInformationRepository = new RoomInformationRepository();
            Rooms = new ObservableCollection<RoomInformation>(roomInformationRepository.GetAll());
        }
    }
}
