using SpaUserControl.Common.Validation;
using SpaUserControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("jefferson", "jeffersonshibuya@yahoo.com.br");

            try
            {
                user.setPassword("", "andre");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(user.Nome);
            Console.ReadKey();
        }
    }
}
