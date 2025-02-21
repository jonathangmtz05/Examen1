
using System.Windows.Forms;

namespace Examen1
{
    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void butAbrir_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialogAbrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialogAbrir.FileName;
                try
                {
                    string texto = File.ReadAllText(filePath);
                    string[] Doc_excel = texto.Split('\n');
                    string[] Archi = Doc_excel[0].Split(',');
                    int x = Archi.Length;
                    dataGridView1.ColumnCount = x;
                    dataGridView1.RowCount = Doc_excel.Length;
                    for (int i = 0; i < x; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = Archi[i];
                    }

                    for (int i = 1; i < (Doc_excel.Length) - 1; i++)
                    {
                        Archi = Doc_excel[i].Split(',');
                        for (int j = 0; j < x; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = Archi[j];
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error no es Posible abrir el archivo: " + ex.Message);
                }
            }

        }

        private void butCalculo_Click(object sender, EventArgs e)
        {
         string ruta = openFileDialogAbrir.FileName;
                string contenido = File.ReadAllText(ruta);
                string[] lineas = contenido.Split();

                dataGridView1.Columns.Clear();
                string[] encabezados = lineas[0].Split(',');

                dataGridView1.Columns.Add("CURP", "CURP");
                dataGridView1.Columns.Add("Promedio", "Promedio");
                dataGridView1.Columns.Add("Edad", "Edad");
                dataGridView1.Columns.Add("Sexo", "Sexo");

                for (int i = 0; i < encabezados.Length; i++)
                {
                    if (encabezados[i] != "RFC" && encabezados[i] != "Promedio")
                    {
                        dataGridView1.Columns.Add(encabezados[i].Trim(), encabezados[i].Trim());
                    }
                }

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] valores = lineas[i].Split(',');

                    if (valores.Length == encabezados.Length)
                    {
                        
                        string curp = valores[0].Trim();
                        string promedio = valores[1].Trim();

                        int edad = CalcularEdad(curp);
                        string sexo = DeterminarSexo(curp);

                        string[] fila = new string[dataGridView1.Columns.Count];
                        fila[0] = curp;
                        fila[1] = promedio; 
                        fila[2] = edad.ToString(); 
                        fila[3] = sexo;
                    for (int j = 2; j < valores.Length; j++)
                    {
                        fila[j + 2] = valores[j];
                    }
                    dataGridView1.Rows.Add(fila);
                    }
                }
      
            
        }
        private int CalcularEdad(string curp)
        {
            int año = int.Parse(curp.Substring(4, 2));
            int mes = int.Parse(curp.Substring(6, 2));
            int dia = int.Parse(curp.Substring(8, 2));

            año += (año >= 30) ? 1900 : 2000;
            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public string DeterminarSexo(string curp)
        {
       
            int sexo = curp[10]; 

            if (sexo == 'H')
                return "Masculino";
            else if (sexo == 'M')
                return "Femenino";
            else
                return "Desconocido";
        }
    }
}
    