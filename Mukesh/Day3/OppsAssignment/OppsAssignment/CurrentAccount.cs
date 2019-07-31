using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsAssignment
{
    public class CurrentAccount : Account
    {
        private double InterestRate;

        public CurrentAccount()
        {
            this.InterestRate = 5;
        }

        public override double CalculateInterest()
        {
            return (Balance+((100*InterestRate)/Balance));
        }
    }
}
