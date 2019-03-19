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

            /*public String getText
            {
                get { return Text; }
            }*/

        }

        class human
        {
            public String Name = ""; 

        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            //Letter letter = new Letter();
            String body;

            Letter[] let = new Letter[5]; 

            for(int i=0; i<=let.Length; i++)
            {
                body = "body" + rand.Next(1, 4);
                let[i] = new Letter(body, "Тестовое письмо для: " + body);
            }

            

        }
    }
}
