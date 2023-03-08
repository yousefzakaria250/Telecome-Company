using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecome_Company
{
    enum PackageType
    {
        none ,
        Hekaya20,
        Hekaya50 ,
        Hekaya100 ,
        Hekaya200
    };
    class Lines
    {
        public int mobileNumber { set; get; }
        public PackageType Package { set; get; }

        public double Balance { set; get; }
        public DateTime startDate { set; get; }
        public DateTime renewableDate { set; get; }


        public void updateBalance( User u , int LineNum ,  int minutes)
        {
            u.Line[LineNum].Balance -= (minutes * 0.25);
        }

        public void updateBalance(User u, int LineNum)
        {
            u.Line[LineNum].Balance -= 0.25;
        }


    }
}
