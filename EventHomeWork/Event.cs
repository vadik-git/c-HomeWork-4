using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    назва
    кількість осіб заходу

    місце проведення

    час проведення(стандартна структура DateTime)

    ІД події(автоматично присвоюється 1, 2, 3, ...), формується на основі статичного поля counter

    counter - статичне поле, що рахує кількість створених екземплярів

    клієнт(посилання на Клієнта, що замовив захід)
Методи
    конструктор(и)

    перенесення події на певне число днів вперед(метод AddDay структури DateTime)
https://docs.microsoft.com/en-us/dotnet/api/system.datetime.adddays?view=netframework-4.8
	перенесення події на певне число тижнів вперед

Визначити  властивості для полів класу.
*Перевіряти правильність дати події(не раніше сьогоднішньої), властивості DateTime.Today, DateTime.Now
Перевизначити(override) метод ToString()*/

namespace EventHomeWork
{
    class Event
    {
       public  DateTime dateEvent;

        string nameEvent;
        uint quantituPersonEvent;
        string cityEvent;
        static uint IdEvent = 0;
        uint id = 0;
       public  Client client;
        


        public uint QuantituPerson { get=>quantituPersonEvent; set=>quantituPersonEvent=value; }
        public string NameEvent { get=>nameEvent; set=>nameEvent=value??"not event"; }
        public string CityEvent{ get=>cityEvent; set=>cityEvent=value??"Noname city"; }

        public Event(string nameEvent, uint quantituPersonEvent , string cityEvent , Client client, DateTime date)
        {
            this.NameEvent = nameEvent;
            this.QuantituPerson = quantituPersonEvent;
            this.CityEvent = cityEvent;
            this.client = client;
            if (date < DateTime.Today)
            {
                throw new Exception("Bad date");
            }
            else
            {
                this.dateEvent = date;
            }

            id= ++IdEvent;
        }

        public void addDay(double day)
        {
            if (day <= 0)
            {
                throw new Exception("Bad days");
            }
            else
            {
                DateTime today = this.dateEvent;
                this.dateEvent = today.AddDays(day);
            }
        }
        public void addWeeks(double weeks)
        {
            if (weeks<= 0)
            {
                throw new Exception("Bad days");
            }
            else
            {
                double days = weeks * 7;
                DateTime today = this.dateEvent;
                this.dateEvent = today.AddDays(days);
            }
        }


        public override string ToString()
        {
            return$" ID Event {id} : Name event {NameEvent} : quantitu people event {QuantituPerson}  City event :  {CityEvent} : Client => {client} : Date event {dateEvent}";
        }



    }
}
