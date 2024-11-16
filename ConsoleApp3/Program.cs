using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Liststudent
{
    class UserAccount
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

       
        public UserAccount(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }

        
        public UserAccount(UserAccount account)
        {
            Email = account.Email;
            Username = account.Username;
            Password = account.Password;
        }
    }
    internal class Program
    {
        
         
       
        static void Main(string[] args)
        {
            ArrayList accounts = new ArrayList();

            
            Console.WriteLine("Enter the number of accounts to create:");
            int numberOfAccounts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfAccounts; i++)
            {
                Console.WriteLine("\nEnter details for Account :"+i++);

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Username: ");
                string username = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                UserAccount account = new UserAccount(email, username, password);

                accounts.Add(new UserAccount(account)); 
            }

            
            Console.WriteLine("\nLogin:");
            Console.Write("Enter Username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Enter Password: ");
            string inputPassword = Console.ReadLine();

            bool isAuthenticated = false;

            foreach (UserAccount account in accounts)
            {
                if (account.Username == inputUsername && account.Password == inputPassword)
                {
                    isAuthenticated = true;
                    break;
                }
            }

            if (isAuthenticated)
            {
                Console.WriteLine("Correct Credentials!//"+DateTime.Now);
            }
            else
            {
                Console.WriteLine("Invalid Credentials!//"+DateTime.Now);
            }
        }
    }
    
}
