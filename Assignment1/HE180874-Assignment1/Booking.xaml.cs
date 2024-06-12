using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BussinessObjects.Models;
using BussinessObjects.Repository;
using HE181099_Assignment1.Models;
using Microsoft.EntityFrameworkCore;

namespace HE181099_Assignment1
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class MVVMRoom
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Cap { get; set; }
        public string Type { get; set; }
        public MVVMRoom() {
        }
        public MVVMRoom(int id, string name, string description, decimal price, int cap, string type)
        {
            this.Id = id;
            this.Number = name;
            this.Description = description;
            this.Price = price;
            this.Cap = cap;
            this.Type = type;
        }
    }
    public partial class MVVMBooking
    {
        public int Id { get; set; }

        public DateOnly? BookingDate { get; set; }

        public decimal? TotalPrice { get; set; }

        public byte? Status { get; set; }

        public MVVMBooking()
        {
        }
        public MVVMBooking(int id, DateOnly? date , decimal? price, byte? status)
        {
            this.Id = id;
            this.BookingDate = date;
            this.TotalPrice = price;
            this.Status = status;
        }
    }
    public partial class Booking : Window
    {
        private Boolean inRoomView {  get; set; }
        private readonly int CustomerId;
        public ICollectionView MyMVVMRoomList { get; private set; }
        private readonly IRoomInformationRepository roomInformationRepository;
        private readonly IRoomTypeRepository roomTypeRepository;
        private readonly IBookingReservationRepository bookingRepository;
        public Booking(int uid)
        {
            inRoomView = true;
            CustomerId=uid;
            roomTypeRepository = new RoomTypeRepository();
            roomInformationRepository = new RoomInformationRepository();
            bookingRepository = new BookingReservationRepository();
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Window_Loaded(sender, e);
            inRoomView = true;
            resetInput();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<BookingReservation> reservationList = bookingRepository.GetAllByCustomerId(CustomerId);
                List<MVVMBooking> mVVMBookings = new List<MVVMBooking>();
                foreach (BookingReservation reservation in reservationList)
                {
                    mVVMBookings.Add(new MVVMBooking(reservation.BookingReservationId,
                        reservation.BookingDate, reservation.TotalPrice, reservation.BookingStatus));
                }
                dgData.ItemsSource = mVVMBookings;
                inRoomView = false;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally { resetInput(); }
        }

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            if(txtCapacity.Text != "") MessageBox.Show("Room booked: " + txtRoomNumber.Text);
            else MessageBox.Show("Your reservation: Room " + txtRoomNumber.Text + " with total price is " + txtPrice.Text);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (dataGrid.SelectedIndex < 0) return;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator
                .ContainerFromIndex(dataGrid.SelectedIndex);
            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row)
                .Parent as DataGridCell;
            try
            {
                string id = ((TextBlock)RowColumn.Content).Text;
                if (inRoomView)
                {
                    RoomInformation roomInformation = roomInformationRepository.GetRoomInformationById(Int32.Parse(id));
                    txtRoomID.Text = roomInformation.RoomId.ToString();
                    txtRoomNumber.Text = roomInformation.RoomNumber.ToString();
                    txtPrice.Text = roomInformation.RoomPricePerDay.ToString();
                    txtCapacity.Text = roomInformation.RoomMaxCapacity.ToString();
                    txtDescription.Text = roomInformation.RoomDetailDescription.ToString();
                    txtType.Text = roomInformation.RoomType.RoomTypeName;
                }
                else
                {
                    BookingReservation bookingReservation = bookingRepository.GetBookingReservationById(Int32.Parse(id));
                    txtRoomID.Text = "";
                    foreach (BookingDetail bd in bookingReservation.BookingDetails)
                    {
                        if (txtRoomID.Text=="") txtRoomID.Text += bd?.Room?.RoomId??-1;
                        else txtRoomID.Text += ", "+bd?.Room?.RoomId??"-1";
                    }
                    txtRoomNumber.Text = "";
                    foreach (BookingDetail bd in bookingReservation.BookingDetails)
                    {
                        if (txtRoomNumber.Text == "") txtRoomNumber.Text += bd?.Room?.RoomNumber ?? "-1";
                        else txtRoomNumber.Text += ", " + bd?.Room?.RoomNumber ?? "-1";
                    }
                    foreach (BookingDetail bd in bookingReservation.BookingDetails)
                    {
                        if (txtDescription.Text == "") txtDescription.Text +="Room "+ (bd?.Room?.RoomNumber ?? "-1")+" from " + (bd?.StartDate.ToString() ?? "N/A") +
                                " to " + (bd?.EndDate.ToString() ?? "N/A");
                        else txtDescription.Text += ", " + "Room " + (bd?.Room?.RoomNumber ?? "-1") + " from " + (bd?.StartDate.ToString() ?? "N/A") +
                                " to " + (bd?.EndDate.ToString() ?? "N/A");
                    }
                    txtPrice.Text = bookingReservation.TotalPrice.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                List<MVVMRoom> list = new List<MVVMRoom>();
                /*MyMVVMRoomList = CollectionViewSource.GetDefaultView(list);*/
                DataContext = this;
                foreach (RoomInformation room in roomInformationRepository.GetAll())
                {
                    list.Add(new MVVMRoom(room.RoomId, room.RoomNumber, room.RoomDetailDescription,
                        room.RoomPricePerDay ?? -1.0m, room.RoomMaxCapacity ?? -1, room?.RoomType?.RoomTypeName ?? "N/A"));
                }
                dgData.ItemsSource = list;
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void resetInput()
        {
            txtCapacity.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtRoomID.Text = String.Empty;
            txtRoomNumber.Text = String.Empty;
            txtType.Text = String.Empty;
        }
    }
}
