using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok = 0;
        private DateTime letrejott = new DateTime();
        private DateTime szerkesztve = new DateTime();

        public Bejegyzes(string szerzo, string tartalom)
        {

            this.szerzo = szerzo;
            this.tartalom = tartalom;
            likeok = 0;
            letrejott = DateTime.Now;
            szerkesztve = DateTime.Now;
 
        }



        public string Szerzo
        {
            get
            {
                return szerzo;
            }
        }


        public string Tartalom
        {
            get
            {
                return tartalom;
            }
            set
            {
                if (tartalom != value)
                {
                    szerkesztve = DateTime.Now;
                }
                tartalom = value;

            }
        }

        public int Likeok
        {
            get
            {
                return likeok;
            }
        }


        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }
        }

        public DateTime Szerkesztve
        {
            get
            {
                return szerkesztve;
            }
        }


        public void Like()
        {
            likeok++;
        }

        public void Kiir()
        {
            Console.WriteLine("{0} -- {1} -- {2} \br" +
                "Szerkesztve: {3}"+
                "{4}", szerzo, likeok, letrejott,szerkesztve,tartalom
                );

            return ;
        }









    }
}
