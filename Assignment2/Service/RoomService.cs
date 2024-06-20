using Assignment1PRN.Models;

namespace Assignment1PRN.Service;

public class RoomService
{
    public List<RoomInformation> GetAllRoomInformations()
    {
        return FuminiHotelManagementContext.Instance().RoomInformations.ToList();
    }

    public void DeleteRoom(int id)
    {
        RoomInformation r = FuminiHotelManagementContext.Instance().RoomInformations.Find(id);
        FuminiHotelManagementContext.Instance().RoomInformations.Remove(r);
        FuminiHotelManagementContext.Instance().SaveChanges();
    }

    public RoomInformation GetRoomInformation(int id)
    {
        return FuminiHotelManagementContext.Instance().RoomInformations.Find(id);
    }

    public void UpdateRoom(int id,string roomNumber, string description, int? roomMaxCapacity,int roomTypeId,byte? roomStatus,decimal? price)
    {
        RoomInformation r = FuminiHotelManagementContext.Instance().RoomInformations.Find(id);
        if (r == null) return;
        r.RoomNumber = roomNumber;
        r.RoomDetailDescription = description;
        r.RoomMaxCapacity = roomMaxCapacity;
        r.RoomTypeId = roomTypeId;
        r.RoomStatus = roomStatus;
        r.RoomPricePerDay = price;
        FuminiHotelManagementContext.Instance().SaveChanges();
    }

    public void AddRoom(string roomNumber, string description, int? roomMaxCapacity, int roomTypeId, byte? roomStatus, decimal? price)
    {
        RoomInformation r = new RoomInformation();
        
        r.RoomNumber = roomNumber;
        r.RoomDetailDescription = description;
        r.RoomMaxCapacity = roomMaxCapacity;
        r.RoomTypeId = roomTypeId;
        r.RoomStatus = roomStatus;
        r.RoomPricePerDay = price;
        FuminiHotelManagementContext.Instance().RoomInformations.Add(r);
        FuminiHotelManagementContext.Instance().SaveChanges();
    }

    public RoomType GetRoomType(int id)
    {
        RoomType r = FuminiHotelManagementContext.Instance().RoomTypes.Find(id);
        return r;
    }
}