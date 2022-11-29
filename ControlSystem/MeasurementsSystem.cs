using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    public class MeasurementsSystem
    {
        public MeasuredQuantity mq = new MeasuredQuantity();
        public Senzor se = new Senzor();
        public Signal si = new Signal();
        public SignalConditioner sc = new SignalConditioner();
        public SignalSuitable ss = new SignalSuitable();
        public ValueOFQuantity voq = new ValueOFQuantity();

        public MeasurementsSystem() { }

    }
}
