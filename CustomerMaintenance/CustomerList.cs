using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace CustomerMaintenance
{
    public class CustomerList
    {

        private int indexer;


        public CustomerList()
        {
        }

        //Constructor
        public CustomerList(int indexer)
        {
            this.Count = indexer;
        }


        //Property 1
        public int Count
        {
            get
            {
                return indexer;
            }
            set
            {
                indexer = value;
            }
        }

        //Methods
        public void Add(List<Customer> customer)
        {
            MessageBox.Show("Passed variable: " + customer, "Hint");
            string dir = @"C:\C# 2012\Files\";
            string path = dir + "Customers.txt";

            // create the output stream for a text file that exists
            StreamWriter textOut =
                    new StreamWriter(
                    new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            Customer c = new Customer();
            for (int i = 0; i < this.Count; i++)
            {
                textOut.Write(c.FirstName + "|");
                textOut.Write(c.LastName + "|");
                textOut.WriteLine(c.Email);
            }

            // write the end of the document
            textOut.Close();


        }

        public void Remove(string customer)
        {
            MessageBox.Show("Passed variable: " + customer, "Hint");
        }
        public void Fill()
        {
            MessageBox.Show("Passed variable:", "Hint");
        }
        public void Save()
        {

        }
    }



}

