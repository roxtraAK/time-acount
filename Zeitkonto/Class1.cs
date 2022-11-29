using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitkonto
{
    public interface ICar
    {
        public int PS { get; set; }
    }

    public class IMercedesS90 : ICar
    {
        public string Star { get; set; }
        public int PS { get; set; }
    }

    public class IOpelAstra : ICar
    {
        public string Flash { get; set; }
        public int PS { get; set; }
    }

    internal class Class1
    {

        public void Main(string[] args)
        {
            IMercedesS90 _merc = new IMercedesS90();
            IOpelAstra _opel = new IOpelAstra();    

            SumPS(_merc);
            SumPS(_opel);
        }

        public double SumPS(ICar cars)
        {
            return cars.PS;

        }

    }
}
