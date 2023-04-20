using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class empservices
    {
        List<Empclass> empclasses = new List<Empclass>();
        public void Create_Emp()
        {   
            //This is a function to create the employee objectr and add it  to the list
            Console.WriteLine("Enter the number of Empoyee you want to add");
            string inp = Console.ReadLine();
            int no = Convert.ToInt32(inp);
            if (no == 0)
            {
                Console.WriteLine("Enter the appropriate number of employes you want to add ");
                Create_Emp();
            }
            else
            {
                for (int i = 1; i <= no; i++)
                {
                    Empclass Ei = new Empclass();

                    Console.WriteLine("Enter the Employee Name");
                    Ei.E_Name = Console.ReadLine();
                    Ei.E_Id = empclasses.Count + 1;
                    Console.WriteLine("Enter the Employee Designation");
                    Ei.E_Designation = Console.ReadLine();
                    Console.WriteLine("Enter the Employee Department");
                    Ei.E_Department = Console.ReadLine();
                    Console.WriteLine("Enter the Employee salary");
                    Ei.E_Salary = Convert.ToInt32(Console.ReadLine());
                    empclasses.Add(Ei);
                }
            }
        }

        public void Delete_Emp()
        {
            //This method deletes the employee from the list of emnployee using the id entered from users
            Console.WriteLine("Enter the Id of The Employee You want to Delete : ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (id == 0 || id > empclasses.Count() )
            {
                Console.WriteLine("Emplopyee ID NOT FOUND");
            }
            else
            {
                empclasses.RemoveAt(id - 1 );
            }

        }

        public void Display_Emp()
        {
            //This function displays all the employee avaliable in the list
            if (empclasses.Count == 0 )
            {
                Console.WriteLine("THE LIST OF EMPLOYEES IS EMPTY");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (Empclass Ei in empclasses)
                {
                    
                    Console.WriteLine("|                                    The Name of the Employee is   :" + Ei.E_Name + "            |");
                    Console.WriteLine("|                                    The ID of the Employee is     : " + Ei.E_Id  + "            |");
                    Console.WriteLine("|                                    The Name of the Employee is   :" + Ei.E_Designation + "         |");
                    Console.WriteLine("|                                    The Name of the Employee is   :" + Ei.E_Department + "          |");
                    Console.WriteLine("|                                    The Salary of the Employee is : " + Ei.E_Salary + "         |");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");

                }
            }
        }

        public void Search_Emp_Details()
        {
            //This function searches for the employee on the bases of the id entered from the users
            Console.WriteLine("Enter the Employee Id you want The Details OF : ");
            int QID = Convert.ToInt32(Console.ReadLine());
            if (QID == 0 || QID > empclasses.Count())
            {
                Console.WriteLine("Emplopyee ID NOT FOUND");
            }
            else
            {
                Console.WriteLine("ID          :" + empclasses.ElementAt(QID - 1).E_Id);
                Console.WriteLine("NAME        :" + empclasses.ElementAt(QID - 1).E_Name);
                Console.WriteLine("DESIGNATION :" + empclasses.ElementAt(QID - 1).E_Designation);
                Console.WriteLine("DEPARTMENT  :" + empclasses.ElementAt(QID - 1).E_Department);
                Console.WriteLine("SALARY      :" + empclasses.ElementAt(QID - 1).E_Salary);
            }
        }
    }
}

