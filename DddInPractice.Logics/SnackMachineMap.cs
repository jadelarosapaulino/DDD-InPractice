using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddInPractice.Logics
{
    using FluentNHibernate.Mapping;

    using NHibernate.Type;

    public class SnackMachineMap : ClassMap<SnackMachine>
    {
        public SnackMachineMap()
        {
            this.Id(x => x.Id);

            Component(x => x.MoneyInsede, y =>
                    {
                        y.Map(x => x.OneCentCount); 
                        y.Map(x => x.TenCentCount); 
                        y.Map(x => x.QuarterCount); 
                        y.Map(x => x.OneDollarCount); 
                        y.Map(x => x.FiveDollarCount); 
                        y.Map(x => x.TwentyDollarCount);            
                    });
        }
    }
}
