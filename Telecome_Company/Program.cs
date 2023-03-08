using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecome_Company
{
    class Program
    {

        static void Main(string[] args)
        {
            Lines lines = new Lines();
            lines.mobileNumber = 011123;
            lines.Package = PackageType.Hekaya20;
            lines.Balance = 20;
            lines.startDate = DateTime.Now;
            lines.renewableDate = DateTime.Now.AddDays(30);
            User user = new User("yousef", "123@@", 1);
            user.Line[0] = lines;
            //user.Line[1] = lines;
            //user.Line[2] = lines;
            //            user.Line[1] = lines;




            //int res2 = user.Change_package_Type(011123, PackageType.Hekaya100);
            //if (res2 == 1)
            //    Console.WriteLine($"Package is changed successfully.");
            //else if (res2 == 2)
            //    Console.WriteLine("The Package is Exisit .");

            //else
            //    Console.WriteLine("Not Change .");

            //int res = user.Renew_his_Subscriptions(011123);
            //if (res == 1)
            //    Console.WriteLine("Your Package is Newed .");
            //else if (res == -1)
            //    Console.WriteLine("Your Balance Is Not Enough .");
            //else if (res == -3)
            //    Console.WriteLine("Number is Not Subscribed in any Package .");
            //else
            //    Console.WriteLine("Number Isn't Exist .");




            //Console.WriteLine(user.Line[0].Balance);
            //user.delcall += lines.updateBalance;
            //user.delmessag += lines.updateBalance;
            //user.makeCall(user, 10);
            //user.sendMessage(user);
            //Console.WriteLine(user.Line[0].Balance);







            int res = user.EnterDataForChargeSerial();
            if (res == -1)
            {
                Console.WriteLine("Serial Number Isn't Correct .");
                user.EnterDataForChargeSerial();
            }
            else if (res == 1)
            {
                Console.WriteLine("Serial Number Is Charged Successfully ^_^.");
            }
            else
                Console.WriteLine("Line Numer isn't Exisit .");

                
        }
    }
}
