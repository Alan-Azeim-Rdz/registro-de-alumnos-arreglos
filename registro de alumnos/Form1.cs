using Microsoft.VisualBasic.Logging;

namespace registro_de_alumnos
{
    public partial class Form1 : Form
    {
        int[] prom = new int[10];
        ratings[,] rating = new ratings[3, 3];
        alumno[,,] students = new alumno[3, 3, 3];
        int index = 0;
        int matriz = 0;

        public Form1()
        {
            InitializeComponent();

            for (int row = 0; row < rating.GetLength(0); row++)
            {
                for (int column = 0; column < rating.GetLength(1); column++)
                {
                    rating[row, column] = new ratings();
                }
            }




            for (int x = 0; x < students.GetLength(0); x++)
            {
                for (int y = 0; y < students.GetLength(1); y++)
                {
                    for (int z = 0; z < students.GetLength(2); z++)
                    {
                        students[x, y, z] = new alumno();
                    }
                }
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (index == students.Length)
            {
                MessageBox.Show("El array está lleno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string nombre = NombreTxt.Text;
                int edad = int.Parse(EdadTxt.Text);
                int semestre = int.Parse(SemestreTxt.Text);

                students[index / 9, (index / 3) % 3, index % 3] = new alumno(nombre, edad, semestre);
                index++;

                MostrarInformacion();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduzca un número entero en el campo de edad y semestre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void MostrarInformacion()
        {
            // Limpiar el contenido actual del GroupBox
            StundentView.Controls.Clear();

            // Recorrer el array students y agregar etiquetas para mostrar la información
            for (int x = 0; x < students.GetLength(0); x++)
            {
                for (int y = 0; y < students.GetLength(1); y++)
                {
                    for (int z = 0; z < students.GetLength(2); z++)
                    {
                        alumno currentAlumno = students[x, y, z];
                        if (currentAlumno != null)
                        {
                            Label label = new Label();
                            label.Text = $"Nombre: {currentAlumno.Name}, Edad: {currentAlumno.Age}, Semestre: {currentAlumno.Semester}";
                            label.AutoSize = true;
                            label.Location = new Point(10, 20 + StundentView.Controls.Count * 20); // Ajusta la ubicación vertical de la etiqueta
                            StundentView.Controls.Add(label);
                        }
                       
                    }
                }
            }
        }

        private void StundentView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (matriz == rating.Length)
            {
                MessageBox.Show("El array está lleno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int calificacion1 = int.Parse(ratingTxt.Text);
                int calificacion2 = int.Parse(ratingTxt2.Text);

                rating[matriz / 9, (matriz / 3) % 3] = new ratings(calificacion1, calificacion2);
                matriz++;

                // Guardar el promedio del arreglo bidimensional en el arreglo unidimensional
                GuardarPromedio(matriz / 9);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduzca un número entero en el campo de edad y semestre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarPromedio(int matriz)
        {
            // Calcular el promedio del arreglo bidimensional
            double suma = 0;
            int calificacion1 = int.Parse(ratingTxt.Text);
            int calificacion2 = int.Parse(ratingTxt2.Text);
            suma = (calificacion2 + calificacion1) / 2;

            prom[matriz] = (int)(suma / rating.Length); // Guardar el promedio en el arreglo unidimensional

            promLabel.Text = suma.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Limpiar el array de alumnos
            students = new alumno[3, 3, 3];

            // Limpiar el array de calificaciones
            rating = new ratings[3, 3];

            // Limpiar el array de promedios
            prom = new int[10];

            // Reiniciar el índice
            index = 0;
            matriz = 0;

            // Limpiar la vista de estudiantes
            StundentView.Controls.Clear();

            MessageBox.Show("Los arreglos han sido limpiados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
