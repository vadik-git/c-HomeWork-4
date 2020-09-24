using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHomeWork
{
    class Client
    {
        string numberPhone;
        string nameClient;
        

        public string NumberPhone { get => numberPhone; set => numberPhone=value??"no phone";}
        public string NameCleint { get=>nameClient; set=>nameClient=value??"Noname"; }

        public Client(string nameClient="noname",string numberPhone="nonphone")
        {
            this.NameCleint = nameClient;
            if (numberPhone.Length > 10 || numberPhone.Length <= 0)
            {
                throw new Exception("Bad number");
            }
            else
            {
                this.NumberPhone = numberPhone;
            }

            
        }

        public override string ToString()
        {
            return $"Name client {NameCleint} :  number phone  : {NumberPhone} ";
        }
    }
}
