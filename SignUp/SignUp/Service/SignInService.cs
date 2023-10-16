using SignUp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.Service
{
    public class SignInService
    {



        


        public void SignInMethod()
        {
            SignInModel signInModel = new SignInModel();
            Console.Write("Email = ");
            signInModel.Email = Console.ReadLine();
            Console.Write("Password = ");
            signInModel.Password = Console.ReadLine();

            string path = "Baza.txt";
            bool res = File.Exists(path);
            if (res) 
            {
                string[] malumot = File.ReadAllLines(path);
                bool tekshir = false;
                for (int i = 0; i < malumot.Length; i++)
                {
                    if (signInModel.Email == malumot[i] && signInModel.Password == malumot[i + 1])
                    {
                        Console.WriteLine("Welcome");
                        tekshir = true;
                    }

                }
                if(!tekshir)
                {
                    Console.WriteLine("Not Found");

                }

            }
            else
            {
                Console.WriteLine("Baza hali shakilanmagan");
            }


        }




    }
}
