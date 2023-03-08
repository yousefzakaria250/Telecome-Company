using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecome_Company
{
    delegate void delCall( User u , int LineNumber , int minutes);
    delegate void delMessage(User u, int LineNumber);
    class User
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Address { set; get; }

        public string Email { set; get; }
        public int NumOfLines { set; get; }
        public Lines[] Line { set; get; }
        public delCall delcall;
        public delMessage delmessag; 
        public User(string _Name, string _Pass , int _NumOfLines)
        {
            Name = _Name;
            Password = _Pass;
            Line = new Lines[_NumOfLines];
           
        }
        public User()
        {
            //Line = new Lines[3];
           // Line
        }

        public int Renew_his_Subscriptions(int number)
        {
            for (int i = 0; i < Line.Length; i++)
            {
                if (Line[i].mobileNumber == number)
                {

                    if (Line[i].Package == PackageType.Hekaya20)
                    {
                        if (Line[i].Balance >= 20)
                        {
                            Line[i].Balance -= 20;
                            return 1;
                        }
                        else
                            return -1;

                    }

                    else if (Line[i].Package == PackageType.Hekaya50)
                    {
                        if (Line[i].Balance >= 50)
                        {
                            Line[i].Balance -= 50;
                            return 1;
                        }
                        else
                            return -1;

                    }

                    else if (Line[i].Package == PackageType.Hekaya100)
                    {
                        if (Line[i].Balance >= 100)
                        {
                            Line[i].Balance -= 100;
                            return 1;
                        }
                        else
                            return -1;

                    }

                    else if (Line[i].Package == PackageType.Hekaya200)
                    {
                        if (Line[i].Balance >= 200)
                        {
                            Line[i].Balance -= 200;
                            return 1;
                        }
                        else
                            return -1;

                    }
                    else
                    {
                        return -3;//number Not shared in any Package
                    }
                }
            }
            
                return -2;
            
        }

        public int Change_package_Type(int Line_number , PackageType type)
        {
            for (int i = 0; i < Line.Length; i++)
            {
                if (Line[i].Package == type)
                    return 2; // Package Type is Exist on Line ;
                else if (Line[i].mobileNumber == Line_number )
                {
                    Line[i].Package = type;
                    return 1; // Package is changed to another Type
                }
            }
            return -1; // Number isn't Exist .

        }

        public int callOptions()
        {
            Console.WriteLine($"Do You Want To Call On Any Line from {this.NumOfLines + 1}");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public int messageOptions()
        {
            Console.WriteLine($"Do You Want To Message On Any Line from {this.NumOfLines + 1}");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        public void makeCall(User user , int minutes)
        {
            int res = callOptions();
             delcall.Invoke( user , res - 1 , minutes);
            
        }
            

    public void sendMessage(User user)
        {
            int res = messageOptions();
            delmessag.Invoke(user, res - 1);

        }

     public int ChargeSerialNumber( string serialNumber , int Linenumber , int amount)
        {
            if(!( serialNumber.Length == 14))
            {
                return -1;

            }
            else
            {
                for( int i = 0; i < Line.Length; i++)
                {
                    if(Linenumber == Line[i].mobileNumber)
                    {
                        Line[i].Balance += amount;
                        return 1;
                    }
                }
            }

      return 2;

        }
        
        public int EnterDataForChargeSerial()
        {
            string serial;
            Console.WriteLine("Enter a Serial : ");
            serial = Console.ReadLine();

            int teleNum;
            Console.WriteLine("Enter a Telephone Number : ");
            teleNum = int.Parse(Console.ReadLine());


            int amount;
            Console.WriteLine("Enter Amount : ");
            amount = int.Parse(Console.ReadLine());


           int res = ChargeSerialNumber(serial, teleNum, amount);
            return res;
        }
        

                //else if (Line[1].mobileNumber == number)
                //{
                //    if (Line[1].Package == PackageType.Hekaya20)
                //    {
                //        if (Line[1].Balance >= 20)
                //        {
                //            Line[1].Balance -= 20;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else if (Line[1].Package == PackageType.Hekaya50)
                //    {
                //        if (Line[1].Balance >= 50)
                //        {
                //            Line[1].Balance -= 50;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else if (Line[1].Package == PackageType.Hekaya100)
                //    {
                //        if (Line[1].Balance >= 100)
                //        {
                //            Line[1].Balance -= 100;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else if (Line[1].Package == PackageType.Hekaya200)
                //    {
                //        if (Line[1].Balance >= 200)
                //        {
                //            Line[1].Balance -= 200;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }
                //    else
                //        return -3; // Number Not Shered in any Package

                //}


                //else if (Line[2].mobileNumber == number)
                //{
                //    if (Line[2].Package == PackageType.Hekaya20)
                //    {
                //        if (Line[2].Balance >= 20)
                //        {
                //            Line[2].Balance -= 20;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else if (Line[2].Package == PackageType.Hekaya50)
                //    {
                //        if (Line[2].Balance >= 50)
                //        {
                //            Line[2].Balance -= 50;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else if (Line[2].Package == PackageType.Hekaya100)
                //    {
                //        if (Line[2].Balance >= 100)
                //        {
                //            Line[2].Balance -= 100;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else if (Line[2].Package == PackageType.Hekaya200)
                //    {
                //        if (Line[2].Balance >= 200)
                //        {
                //            Line[2].Balance -= 200;
                //            return 1;
                //        }
                //        else
                //            return -1;

                //    }

                //    else
                //        return -3;

                //}




            



    }
}
