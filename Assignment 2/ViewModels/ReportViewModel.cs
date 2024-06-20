using Assignment1PRN.Command;
using Assignment1PRN.Service;
using Assignment1PRN.Util;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Assignment1PRN.ViewModels;

public class ReportViewModel:ViewModel
{
    private ReportService reportService;
    private DateOnly _startDate;
    private DateOnly _endDate;
    private ObservableCollection<Report> _reports;

    public DateOnly StartDate { get => _startDate; set=>SetField(ref _startDate,value); }
    public DateOnly EndDate { get => _endDate; set => SetField(ref _endDate, value); }
    public ICommand Filter{ get; set; }
    public ICommand GoBack{ get; set; }
    public ObservableCollection<Report> Reports { get=>_reports; set=>SetField(ref _reports,value); }
    public void DoFilter()
    {
        Reports = new ObservableCollection<Report>(reportService.ReportsWithinDate(StartDate, EndDate));
    }
    public void DoGoBack(Navigation navigation)
    {
        navigation.ViewModel = new AdminWorkSpaceViewModel(navigation);
    }
    public ReportViewModel(Navigation navigation)
    {
        reportService = new ReportService();
        Reports = new ObservableCollection<Report>(reportService.GetAllReports());
        Filter = new BaseCommand(()=>DoFilter());
        GoBack = new BaseCommand(() => DoGoBack(navigation));
    }
}