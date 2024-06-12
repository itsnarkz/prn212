using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HE181099_Assignment1.Models;

namespace BussinessObjects.Repository
{
    public interface IRoomInformationRepository
    {
        public List<RoomInformation> GetAll();
        public RoomInformation GetRoomInformationById(int roomId);
        public void UpdateRoomInformation(RoomInformation roomInformation);
        
    }
}
