using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*Клієнт(Client)

    ім'я	
	номер телефону
Визначити конструктор(и) та властивості для полів класу
* Перевіряти правильність телефону
Перевизначити(override) метод ToString()


Захід(Event)

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
Перевизначити(override) метод ToString()

EventService
    список запланованих(замовлених) заходів, List<Event>
Методи

    додавання події до списку подій
    видалення події
    очищення списку подій(Clear)

    пошук(вивід) подій замовлених на певну дату
    пошук(вивід) подій замовлених на певний діапазон дат(дати можна порівнювати операціями >, <, методом CompareTo)

    пошук(вивід) подій замовлених певним клієнтом*/





namespace EventHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Client vadim = new Client("Vadim","096029978");
            Client sasha = new Client("Sasha", "0998398741");
            Client vasya = new Client("vasya", "0998394545");
            Console.WriteLine(vadim);
            Console.WriteLine(sasha);

            Event fot = new Event("fotbol",20,"Kiev",vadim,new DateTime(2020,9,24));
            Event bot = new Event("party", 100, "rivne", sasha, new DateTime(2020, 10, 24));
           // Event sh = new Event("party", 100, "rivne", sasha, new DateTime(2020, 10, 24));
            Console.WriteLine(fot);
            Console.WriteLine(bot);
            fot.addDay(2);
            Console.WriteLine(fot);
            fot.addWeeks(2);
            Console.WriteLine(fot);
            EventService a=new EventService();
            a.addEvent(fot);
            a.addEvent(bot);
            Console.WriteLine("listttt");
            a.printList();
            a.deleteEvent(fot);
            Console.WriteLine("list del");
            a.printList();

            Console.WriteLine("event list");
            a.EventClient(sasha);


            //a.EventClient(vasya);

            Console.WriteLine("find");
            a.findData(new DateTime(2020, 10, 24));


            Console.WriteLine("find from to ");
            a.FindFromTo(new DateTime(2020, 9, 24), new DateTime(2020, 10, 24));



        }
    }
}
