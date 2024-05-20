using CoureWork.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureWork
{
	public class Account
	{

		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool IsLoged { get; set; }  // Новое поле
		public virtual Wallet Wallet { get; set; }

        public Account()
        {
            
        }
        public Account(string userName, string password)
        {
            UserName = userName;
            Password = password;
           
        }
    }
}
