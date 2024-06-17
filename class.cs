using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Atleta
    {
        string nome;
        string cognome;
        string sport;
        int età;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public string Sport { get { return sport; } set { sport = value; } }
        public int Età { get { return età; } set { età = value; } }
        public void Sportivo()
        {

            Console.WriteLine("Ciao a tutti sono " + nome + " " + cognome + " ho " + età + " anni e pratico " + sport);
        }

    }
    internal class Dipendente
    {
        string nome;
        string cognome;
        int età;
        string contratto;
        string umore;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cognome { get { return cognome; } set { cognome = value; } }
        public int Età { get { return età; } set { età = value; } }
        public string Contratto { get { return contratto; } set { contratto = value; } }
        public string Umore { get { return umore; } set { umore = value; } }

        public void Tipo()
        {

            Console.WriteLine("Ciao a tutti sono " + nome + " " + cognome + " ho " + età + " anni e sono " + umore + " perchè  il mio contratto è a tempo " + contratto);
        }
    }


    internal class Animale
    {
        string nome;
        string razza;
        int età;
        string colore;

        public string Nome { get { return nome; } set { nome = value; } }
        public string Razza { get { return razza; } set { razza = value; } }
        public int Età { get { return età; } set { età = value; } }
        public string Colore { get { return colore; } set { colore = value; } }

        public void Coda()
        {

            Console.WriteLine("Ciao a tutti questo è il mio animale " + nome + " se non aveste capito è un " + razza + " ha " + età + " anni ed è di colore " + colore);
        }

    }

            internal class Veicolo
            {
                string nome;
                string tipo;
                int anno;
                string colore;

                public string Nome { get { return nome; } set { nome = value; } }
                public string Tipo { get { return tipo; } set { tipo = value; } }
                public int Anno { get { return anno; } set { anno = value; } }
                public string Colore { get { return colore; } set { colore = value; } }

                public void Tank()
                {

                    Console.WriteLine("ammirate questro modello di " + nome + " un " + tipo + " del " + anno + " con la sua bellissima colorazione " + colore);
                }

























            }















        
    
}
