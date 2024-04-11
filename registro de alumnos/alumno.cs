using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro_de_alumnos
{
    internal class alumno
    {
        private string name;
        private int age;
        private int semester;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        { 
            get { return age; } 
            set { age = value; } 
        }
        public int Semester
        { 
            get { return semester; } 
            set { semester = value; } 
        }

        

        public alumno()
        {
            this.name = "No hay nombre existente";
            this.age = 0;
            this.semester = 0;
        }

        public alumno(string name, int edad, int semester)
        {
            this.name = name;
            this.age = edad;
            this.semester = semester;
        }



        public override string ToString() 
        {
            return "Nombre:" + name + " Edad:" + age + " Semestre:" + semester ;
        
        }

    }
}
