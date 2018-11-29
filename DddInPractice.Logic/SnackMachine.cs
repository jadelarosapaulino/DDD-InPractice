﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddInPractice.Logic
{
    public sealed class SnackMachine
    {
        public Money MoneyInsede { get; private set; }
        public Money MoneyTransaction { get; private set; }

        public void InserMoney(Money money)
        {
            MoneyTransaction += money;
        }

        public void ReturnMoney()
        {
            //MoneyTransaction = 0;
        }

        public void BuySnack()
        {
            MoneyInsede += MoneyTransaction;
            //MoneyTransaction = 0;
        }
    }
}