using DddInPractice.Logics;
using FluentAssertions;
using Xunit;

using  static DddInPractice.Logics.Money;

namespace DDD.Test
{
    using System;

    public class SnackMachineSpecs
    {
        [Fact]
        public void Return_money_in_transaction()
        {
            var snackMachine = new SnackMachine();
            snackMachine.InserMoney(Dollar);

            snackMachine.ReturnMoney();

            snackMachine.MoneyInTransaction.Amount.Should().Be(0m);
        }

        [Fact]
        public void Insert_money_goes_to_money_in_transaction()
        {
            var snackMachine = new SnackMachine();

            snackMachine.InserMoney(Cent);
            snackMachine.InserMoney(Dollar);


            snackMachine.MoneyInTransaction.Amount.Should().Be(1.01m);
        }

        [Fact]
        public void Cannot_insert_more_than_one_coin_or_more_at_a_time()
        {
            var snackMachine = new SnackMachine();
            var twoCent = Cent + Cent;

            Action action = () => snackMachine.InserMoney(twoCent);
            action.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void Money_in_transaction_goes_to_money_inside_after_purchase()
        {
            var snackMachine = new SnackMachine();
            snackMachine.InserMoney(Dollar);
            snackMachine.InserMoney(Dollar);

            snackMachine.BuySnack();

            snackMachine.MoneyInTransaction.Should().Be(None);
            snackMachine.MoneyInsede.Amount.Should().Be(2m);
        }
    }
}
