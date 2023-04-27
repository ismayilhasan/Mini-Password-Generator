using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Password_Generator
{
    internal class PasswordValidator
    {
        private string _password;
        private int _passowrdLength;
        public bool isValid ;
        public PasswordValidator(string password, int passowrdLength)
        {
            _password = password;
            _passowrdLength = passowrdLength;
        }


        public string _Password { 
            get 
            {
                return _password;
                
            } 
            set
            {
            
                if(value.Length != _passowrdLength)
                {
                    Console.WriteLine($"$Your password must be contain {_passowrdLength} character");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }

                bool isNumber = int.TryParse(value, out int result);
               


                // For Just Numbers
                if (!isNumber)
                {
                    Console.WriteLine("Password must be contain just numbers");
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }


                // For letters
                //bool isLetter = _password.All(char.IsLetter);
                //if (!isLetter)
                //{
                //    Console.WriteLine("Password must be contain just letters");
                //    isValid = false;
                //}
                //else
                //{
                //    isValid = true;
                //}
                //

           


            }
        }

      

      
    }
}
