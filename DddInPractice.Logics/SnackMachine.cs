using System;

using static DddInPractice.Logics.Money;


namespace DddInPractice.Logics
{
    using System.Linq;

    public class SnackMachine : Entity
    {
        public Money MoneyInsede { get; protected set; } = None;

        public Money MoneyInTransaction { get; protected set; } = None;


        public virtual void InserMoney(Money money)
        {
            Money[] coinsAndNotes = { Cent, TenCent, Quarter, Dollar, FiveDollar, TwentyDollar };

            if (!coinsAndNotes.Contains(money))
                throw new InvalidOperationException();

            MoneyInTransaction += money;
        }

        public virtual void ReturnMoney()
        {
            MoneyInTransaction = None;
        }

        public virtual void BuySnack()
        {
            MoneyInsede += MoneyInTransaction;

            MoneyInTransaction = None;
        }
    }
}
