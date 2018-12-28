using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddInPractice.Logics
{
    public class Slot : Entity
    {
        public virtual Snack Snack { get; protected set; }
        public virtual int Quantity { get; protected set; }   
        public virtual decimal Price { get; protected set; }  
        public virtual SnackMachine SnackMachine { get; protected set; }     
        public virtual int Position { get; protected set; }

        protected Slot()
        {

        }

        public Slot(
            Snack snack,
            int quantity,
            decimal price,
            SnackMachine snackMachine,
            int position)
            : this()
        {
            Snack = snack;
            Quantity = quantity;
            Price = price;
            SnackMachine = snackMachine;
            Position = position;
        }
    }
}