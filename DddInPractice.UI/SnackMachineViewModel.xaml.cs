using System.Windows.Controls;
using DddInPractice.Logics;
using  DddInPractice.UI.Common;
using Notify;

namespace DddInPractice.UI
{
    using System;

    /// <summary>
    /// Interaction logic for SnackMachineViewModel.xaml
    /// </summary>
    public partial class SnackMachineViewModel //: ViewModel
    {

        //private readonly SnackMachine _snackMachine;

        //public override string Caption => "Snack Machine";
        //public string MoneyInTransaction => _snackMachine.MoneyInTransaction.ToString();

        //private string _message = "";

        //public string Message
        //{
        //    get
        //    {
        //        return _message;
        //    }
        //    private set
        //    {
        //        _message = value;
        //        Notify();
        //    }
        //}

        //public SnackMachine InsertCentCommand { get; set; }
        //public SnackMachine InsertTenCentCommand { get; set; }
        //public SnackMachine InsertQuarterCommand { get; set; }
        //public SnackMachine InsertDollarCommand { get; set; }
        //public SnackMachine InsertFiveDollarCommand { get; set; }
        //public SnackMachine InsertTwentyCommand { get; set; }

        //public SnackMachineViewModel(SnackMachine snackMachine)
        //{
        //    _snackMachine = snackMachine;

        //    InsertCentCommand = new Command(() => InsertMoney(Money.Cent));
        //    InsertTenCentCommand = new Command(() => InsertMoney(Money.TenCent));
        //    InsertQuarterCommand = new Command(() => InsertMoney(Money.Quarter));
        //    InsertDollarCommand = new Command(() => InsertMoney(Money.Dollar));
        //    InsertFiveDollarCommand = new Command(() => InsertMoney(Money.FiveDollar));
        //    InsertTwentyCommand = new Command(() => InsertMoney(Money.TwentyDollar));
        //}

        //private void BuySnack()
        //{
        //    this._snackMachine.BuySnack();

        //    NotifyClient("You have bout a snack");
        //}

        //private void ReturnMoney()
        //{
        //   this._snackMachine.ReturnMoney();
        //   NotifyClient("Money was returned");
        //}

        //private void InsertMoney(Money coinOrNote)
        //{
        //    this._snackMachine.InserMoney(coinOrNote);
        //    NotifyClient("You have inserted" + coinOrNote);
        //}

        //private void NotifyClient(string message)
        //{
        //    Message = message;
        //    Notify(nameof(MoneyInTransaction));
        //    Notify(nameof(MoneyInside));
        //}

    }
}
