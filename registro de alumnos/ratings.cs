using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_de_alumnos
{
    internal class ratings
    {
        private int ratings1;
        private int ratings2;

        public int Ratings1 {  get { return ratings1; } set {  ratings1 = value; } }
        public int Ratings2 { get {  return ratings2; } set {  ratings2 = value; } }


        public ratings(int ratings1, int ratings2)
        {
            this.ratings1 = ratings1;
            this.ratings2 = ratings2;
        }

        public ratings()
        {
            this.ratings1 = 0;
            this.ratings2 = 0;
        }

        public override string ToString()
        {
            return "Primera Calificaion: "+ratings1+ "Segunda Calificaion " +ratings2;
        }



    }
}
