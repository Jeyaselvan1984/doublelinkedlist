using System;

namespace DoubleLinkedList
{
    class Customer
    {
        string FirstName;
        string LastName;
        DateTime? DateOfBirth;
        Customer next;
        Customer prev;
       
        Customer()
        {
            FirstName = null;
            LastName = null;
            next = null;
            prev = null;
            DateOfBirth = null;
        }

        static void Main(string[] args)
        {
            
            Customer cHead = new Customer();
            Customer cHeadVal = new Customer();
            Customer cNull = new Customer(); ;
            Customer cTemp = new Customer { FirstName = "Joe", LastName = "smith", DateOfBirth = new DateTime(1998, 04, 30, 0, 0, 0), next = null,prev=null };
            Customer cTemp1 = new Customer { FirstName = "FN2", LastName = "LN2", DateOfBirth = new DateTime(2005, 04, 30, 0, 0, 0)};
            Customer cTemp2 = new Customer { FirstName = "FN3", LastName = "LN3", DateOfBirth = new DateTime(2016, 04, 30, 0, 0, 0) };
           // Customer CTemp3 = new Customer();
            cHeadVal = cHead = cNull;

            //cHead = cHead.next;
            cHeadVal.insertCustomer(ref cHead, ref cTemp);
          
            cHead = cHead.next;

            //cHead = cHead.next;
            cHeadVal.insertCustomer(ref cHead,ref cTemp1);
            cHead = cHead.next;
           //cHead = cHead.next;
            cHeadVal.insertCustomer(ref cHead,ref cTemp2);
            //cHeadVal.next = CTemp3;
            //cHead = cHead.next;
            //cHead = cNull;
            // cHead.next = cHeadVal;
            cHeadVal = cHeadVal.next;
           int maxCustomer =  PrintCustomersForward(ref cHeadVal);
            cHead = cHead.next;
            PrintCustomersBackward(ref cHead, maxCustomer);
        }

        void insertCustomer(ref Customer cHead, ref Customer c)
        {
            if (cHead == null)
            {

                cHead = c;
       
                //c.next = this;
            }
            else
            {
                c.prev = cHead;
                cHead.next = c;
         
               
                //c.next = this;

            }
            
        }

        static void PrintCustomersBackward(ref Customer cHeadValue, int max)
        {
            Customer cTemp = cHeadValue;
          
            while (cTemp.prev != null)
            {
                Console.WriteLine("Customer {0}", max);
                Console.WriteLine("First Name {0}", cTemp?.FirstName);
                DateTime presentDt = DateTime.Now;
                if (cTemp.DateOfBirth != null)
                {
                    Console.WriteLine("Age {0}", (presentDt.Year - cTemp.DateOfBirth.Value.Year));
                }
                max--;
                cTemp = cTemp.prev;

            }
        }

        static int PrintCustomersForward(ref Customer cHeadVal)
        {
            Customer cTemp = cHeadVal;
            int cstNo = 1;

            while(cTemp!=null)
            {
                Console.WriteLine("Customer {0}", cstNo);
                Console.WriteLine("First Name {0}", cTemp?.FirstName);
                DateTime presentDt = DateTime.Now;
                if (cTemp.DateOfBirth != null)
                {
                    Console.WriteLine("Age {0}", (presentDt.Year - cTemp.DateOfBirth.Value.Year));
                }
                cstNo++;
                cTemp = cTemp.next;

            }
            return cstNo-1;
        }
       
    }
}
