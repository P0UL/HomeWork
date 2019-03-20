using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {

        class Letter
        {
            public String addres = "";
            private String text = "";
            public bool open = false;
            public bool read = false;

            public Letter(String Addres, String Text)
            {
                addres = Addres;
                text = Text;
            }

            public String GetText
            {
                get { return text; } 
            }

        }

        class human
        {
            public String Name = ""; 

        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            String body;
            String name;
            String question;
            String addres = "";
            String dateTime = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
            Letter[] let = new Letter[5]; 

            for(int i=0; i<let.Length; i++)
            {
                body = "body" + rand.Next(1, 4);
                let[i] = new Letter(body, $"{dateTime}  Тестовое письмо для: {body}");
                //addres += body == "" ? addres : ", "+body;
            }

            Console.WriteLine($"Введите имя: ");//{addres}");
            name = Console.ReadLine();

            for(int i=0; i<let.Length; i++)
            {
                if (let[i].addres == name)
                {
                    Console.WriteLine("Открыть письмо? (y/n)");
                    question = Console.ReadLine();
                    if (question == "y" || let[i].open)
                    {
                        let[i].open = true;
                        let[i].read = true;
                        Console.WriteLine(let[i].GetText);
                    }
                }
            }
            Console.Read();
        }
    }
}
