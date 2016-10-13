using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

        //Constructor
		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

        //Property 1
		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}
        //Property 2
        public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}
        //Property 3
        public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

        //Methods
		public string GetDisplayText()
		{
            if(firstName.Length > 30)
            {
                MessageBox.Show("Your first name is greater than 30 characters. That is " + Math.Abs((30 - firstName.Length)) + " characters over the limit!", "Error!");
                return "false";
            }
            if (lastName.Length > 30)
            {
                MessageBox.Show("Your last name is greater than 30 characters. That is " + Math.Abs((30 - lastName.Length)) + " characters over the limit!", "Error!");
                return "false";
            }
            if (email.Length > 30)
            {
                MessageBox.Show("Your email is greater than 30 characters. That is " + Math.Abs((30 - email.Length)) + " characters over the limit!", "Error!");
                return "false";
                
            }
            else
            {
                //Everything is good!
                return firstName + " " + lastName + ", " + email;
            }
            
		}
	}
}
