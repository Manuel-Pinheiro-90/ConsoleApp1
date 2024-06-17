// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

class Program
{
    public static void Main(string[] args)
    {
        Atleta a = new Atleta();
        a.Nome = "Gianni";
        a.Cognome = "Bulli";
        a.Età = 20;
        a.Sport = "Golf";
        a.Sportivo();



        Dipendente d = new Dipendente();
        d.Nome = "Lala";
        d.Cognome = "Bulli";
        d.Età = 34;
        d.Contratto = "determinato";
        d.Umore = " irrascibile";
        d.Tipo();



        Animale dra = new Animale();
        dra.Nome = "Fuffy";
        dra.Età = 1500;
        dra.Razza = "Drago";
        dra.Colore = "nero";
        dra.Coda();


        Veicolo v = new Veicolo();
        v.Nome = "Abrams M1";
        v.Tipo = "carro pesante";
        v.Anno = 1979;
        v.Colore = "sabbia";
        v.Tank();






    }






}