using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsAssignment
{
    class Savingccount :Account
    {

        private double InterestRate;

        public Savingccount()
        {
            this.InterestRate = 12.5;
        }
        public override double CalculateInterest()
        {
            return (Balance + ((Balance * InterestRate) / 100));
        }
    }
}
