using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Proxy;

namespace DddInPractice.Logics
{            
    public abstract class Entity
    {
        public long Id { get; protected set; }

        public abstract Snack Snack { get; set; }

        public abstract int Quantity { get; set; }

        public abstract decimal Price { get; set; }

        public abstract SnackMachine SnackMachine { get; set; }

        public abstract int Position { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            if (GetType() != other.GetType())
            {
                return false;
            }
            if (Id == 0)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            {
                return true;
            }
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (this.GetRealType().ToString() + Id).GetHashCode();
        }

        private Type GetRealType()
        {
            return NHibernateProxyHelper.GetClassWithoutInitializingProxy(this);
        }
    }
}
