using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects.Models;
using HE181099_Assignment1.Models;

namespace BussinessObjects.Repository
{
    public class RoomInformationRepository : IRoomInformationRepository
    {
        public List<RoomInformation> GetAll()
        {
            using(MyDbContext dbContext = new MyDbContext())
            {
                try
                {
                    return dbContext.RoomInformations.ToList();
                } catch(Exception ex)
                {
                    throw new Exception("RI repo :"+ex.Message);
                }
            }
        }

        public RoomInformation GetRoomInformationById(int roomId)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                try
                {
                    RoomInformation roomInformation = dbContext.RoomInformations.SingleOrDefault(c=>c.RoomId==roomId);
                    if (roomInformation == null) { return null; }
                    else
                    {
                        roomInformation.RoomType = dbContext.RoomTypes.SingleOrDefault(t => t.RoomTypeId == roomInformation.RoomTypeId);
                        return roomInformation;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("RI repo :" + ex.Message);
                }
            }
        }

        public void UpdateRoomInformation(RoomInformation roomInformation)
        {
            throw new NotImplementedException();
        }
    }
}
