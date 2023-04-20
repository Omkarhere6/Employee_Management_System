using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyFirstApp.Program;

namespace MyFirstApp
{
        
    
    internal class Program
    {

   
        static void Main(string[] args)
        {

            empservices EMP_FUNC = new empservices();
            bool A = true ;
            while (A){
                Console.WriteLine("---------------------------------------- Employee Management System -----------------------------------------------------");
                Console.WriteLine("                         PLEASE SELECT THE CHOICE FROM THE BELOW OPTIONS                          ");
                Console.WriteLine("                                    1.CREATE EMPLOYEE\r\n" + "                                    2.DELETE EMPLOYEE\r\n" + "                                    3.DISPLAY ALL-EMPLOYEE\r\n" + "                                    4.SEARCH EMPLOYEE\r\n" + "                                    5.EXIT\r\n");
                Console.WriteLine("Enter Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0 || choice > 5)
                {
                    Console.WriteLine("Enter the correct choice ");
                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                    switch (choice)
                    {
                        case 1:
                            EMP_FUNC.Create_Emp();
                            break;
                        case 2:
                            EMP_FUNC.Delete_Emp();
                            break;
                        case 3:
                            EMP_FUNC.Display_Emp();
                            break;
                        case 4:
                            EMP_FUNC.Search_Emp_Details();
                            break;
                        case 5:
                            A = false;
                            break;
                    }
                }
            }
        }

    }
}
