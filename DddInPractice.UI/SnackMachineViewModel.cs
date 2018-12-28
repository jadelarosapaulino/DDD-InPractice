using System.Windows.Controls;
using DddInPractice.Logics;
using DddInPractice.UI.Common;
using System.Collections.Generic;
using Notify;

namespace DddInPractice.UI
{
    public partial class SnackMachineViewModel : ViewModel
    {

        private readonly SnackMachine _snackMachine;

        public override string Caption => "Snack Machine";
        public string MoneyInTransaction => _snackMachine.MoneyInTransaction.ToString();

        private string _message = "";

        public string Message
        {
            get
            {
                return _message;
            }
            private set
            {
                _message = value;
                Notify();
            }
        }

        public Command InsertCentCommand { get; set; }
        public Command InsertTenCentCommand { get; set; }
        public Command InsertQuarterCommand { get; set; }
        public Command InsertDollarCommand { get; set; }
        public Command InsertFiveDollarCommand { get; set; }
        public Command InsertTwentyCommand { get; set; }
        public Command ReturnMoneyCommand { get; private set; }
        public Command BuySnackCommand { get; private set; }

        public SnackMachineViewModel(SnackMachine snackMachine)
        {
            _snackMachine = snackMachine;

            InsertCentCommand = new Command(() => InsertMoney(Money.Cent));
            InsertTenCentCommand = new Command(() => InsertMoney(Money.TenCent));
            InsertQuarterCommand = new Command(() => InsertMoney(Money.Quarter));
            InsertDollarCommand = new Command(() => InsertMoney(Money.Dollar));
            InsertFiveDollarCommand = new Command(() => InsertMoney(Money.FiveDollar));
            InsertTwentyCommand = new Command(() => InsertMoney(Money.TwentyDollar));
            ReturnMoneyCommand = new Command(() => ReturnMoney());
            BuySnackCommand = new Command(() => BuySnack());
        }

        private void BuySnack()
        {
            this._snackMachine.BuySnack();
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(this._snackMachine);
                transaction.Commit();
            }
            {

            }
            NotifyClient("You have bout a snack");
        }

        private void ReturnMoney()
        {
            this._snackMachine.ReturnMoney();
            NotifyClient("Money was returned");
        }

        private void InsertMoney(Money coinOrNote)
        {
            this._snackMachine.InserMoney(coinOrNote);
            NotifyClient("You have inserted" + coinOrNote);
        }

        private void NotifyClient(string message)
        {
            Message = message;
            Notify(nameof(MoneyInTransaction));
            Notify(nameof(MoneyInside));
        }

    }
}
