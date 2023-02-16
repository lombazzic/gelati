using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lombardi.samuele._4h.gelati
{
    public class Gelato
    {
        public string Tipo { get; set; }  
        public string Gusto { get; set; }   
        
        public string Size { get; set; }   

        public Gelato() { }

        public Gelato(string riga)
        {
            string[] colonne = riga.Split(';');
            Tipo= colonne[0];   
            Gusto= colonne[1];   
            Size= colonne[2];

        }

    }

    public class Gelati:List<Gelato> 
    {
        public Gelati() { }
        public Gelati(string nomefile) 
        {
            StreamReader fin = new StreamReader(nomefile);
            fin.ReadLine();
                
            while(!fin.EndOfStream) 
            {
                String riga = fin.ReadLine();
                Gelato g = new Gelato(riga);
                Add(g);
            }    

            fin.Close();
           
        }
    }
}
