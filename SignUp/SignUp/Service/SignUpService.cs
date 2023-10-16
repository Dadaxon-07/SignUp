
using SignUp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp.Service
{
    public class SignUpService
    {

       
        public void SignUpMethod()
        {
            SignUpModel _signUpModel = new SignUpModel();
            Console.Write("Id = ");
            _signUpModel.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("FirstName = ");
            _signUpModel.FirstName = Console.ReadLine();
            Console.Write("LastName = ");
            _signUpModel.LastName = Console.ReadLine();
            Console.Write("Age  = ");
            _signUpModel.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email = ");
            _signUpModel.Email = Console.ReadLine();
            Console.Write("Password = ");
            _signUpModel.Password = Console.ReadLine();
            Console.Write("ComfirmPassword = ");
            _signUpModel.ComfirmPassword = Console.ReadLine();

            string path = "Baza.txt";
            bool res = File.Exists(path);
            //Baza.txt shakilanmagan vazyat
            if (!res) 
            {
                File.AppendAllText(path,_signUpModel.Id.ToString() + "\n" + _signUpModel.FirstName + "\n" + _signUpModel.LastName + "\n" + _signUpModel.Age.ToString() + "\n" +
                                    _signUpModel.Email + "\n" + _signUpModel.Password + "\n" + _signUpModel.ComfirmPassword + "\n");
                Console.WriteLine("Ruyhatga olindi");
            }
            //Baza.txt mavjud vazyat
            else if(res == true)
            {
                List<string> malumot = File.ReadAllLines(path).ToList();
                bool tekshir = false;
                for (int i = 0; i < malumot.Count; i++)
                {
                    //Baza.txt ni ichida foydalanuvchi mavjud bulsa
                    if(_signUpModel.FirstName == malumot[i] && _signUpModel.Email == malumot[i + 3] && _signUpModel.Password == malumot[i + 4])
                    {
                        tekshir = true;
                        Console.WriteLine("Bu foydalanuvchi mavjud");

                    }


                }
                //Baza.txt ni ichida foydalanuvchi mavjud bulmasa
                if (!tekshir)
                {
                    malumot.Add(_signUpModel.Id.ToString());
                    malumot.Add(_signUpModel.FirstName);
                    malumot.Add(_signUpModel.LastName);
                    malumot.Add(_signUpModel.Age.ToString());
                    malumot.Add(_signUpModel.Email);
                    malumot.Add(_signUpModel.Password);
                    malumot.Add(_signUpModel.ComfirmPassword);
                    File.Delete(path);
                    File.AppendAllLines(path, malumot);
                    
                    Console.WriteLine("muvoffaqiyatli qushildi");



                }

            }
        }
        



    }
}
