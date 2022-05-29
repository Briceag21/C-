using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Conectare;
namespace WindowsFormsApp2.Models
{

    public class CursaModel
    {
        //fields
        private int id;
        private int idGara1;
        private int idGara2;
        private double pret;
         private int idOrar;
        private int comfort;
        private string stare;
        private int idTren;
      
    public int IdCursa { get => id; set => id = value; }
        public int IdGara1 { get => idGara1; set => idGara1 = value; }
        public int IdGara2 { get => idGara2; set => idGara2 = value; }
        public double Pret { get => pret; set => pret = value; }
        public int IdOrar { get => idOrar; set => idOrar = value; }
        public int COmfort { get => comfort; set => comfort = value; }
        public int IDTren { get => idTren; set => idTren = value; }
        public string Stare { get => stare; set => stare = value; }
    }
}