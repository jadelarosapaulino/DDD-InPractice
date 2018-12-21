using System;

using static DddInPractice.Logics.Money;


namespace DddInPractice.Logics
{
    using System.Linq;

    public sealed class SnackMachine : Entity
    {
        public Money MoneyInsede { get; private set; } = None;

        public Money MoneyInTransaction { get; private set; } = None;


        public void InserMoney(Money money)
        {
            Money[] coinsAndNotes = { Cent, TenCent, Quarter, Dollar, FiveDollar, TwentyDollar };

            if (!coinsAndNotes.Contains(money))
                throw new InvalidOperationException();

            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            MoneyInTransaction = None;
        }

        public void BuySnack()
        {
            MoneyInsede += MoneyInTransaction;

            MoneyInTransaction = None;
        }
    }
}
