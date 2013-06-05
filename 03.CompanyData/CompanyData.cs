/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console.
*/
using System;


    class CompanyData
    {
        static void Main(string[] args)
        {
            //Company details
            Console.WriteLine("Insert company name:");
            string cname = Console.ReadLine();
            Console.WriteLine("Insert company address:");
            string caddress = Console.ReadLine();
            Console.WriteLine("Insert company phone number:");
            string cphone = Console.ReadLine();
            Console.WriteLine("Insert company fax number:");
            string cfax = Console.ReadLine();
            Console.WriteLine("Insert company web site:");
            string cweb = Console.ReadLine();
            string cinfo=("Company name: "+cname+"\r\nCompany Address: "+caddress+"\r\nCompany Phone: "+cphone+"\r\nCompany Fax: "+cfax+"\r\nCompany Website: "+cweb+"\r\n");
            //Manager details
            Console.WriteLine("Insert company manager first name:");
            string cmanagerf = Console.ReadLine();
            Console.WriteLine("Insert company manager last name:");
            string cmanagerl = Console.ReadLine();
            string cmanager = cmanagerf +" "+cmanagerl;
            Console.WriteLine("Insert company manager age:");
            string age = Console.ReadLine();
            Console.WriteLine("Insert company manager phone number:");
            string mphone = Console.ReadLine();
            string minfo=("Manager name: "+cmanager+"\r\nManager Age: "+age+"\r\nManager Phone: "+mphone);
            Console.WriteLine();
            Console.WriteLine("\"Company information\"");
            Console.WriteLine(cinfo);
            Console.WriteLine("\"Manager information\"");
            Console.WriteLine(minfo);
            
        }
    }
