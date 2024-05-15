using AtencionAPacientes;
using System.Windows.Forms;

namespace GonzaloCeballos
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Gustavo", "Rivas", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Lautaro", "Galarza", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Mathias", "Bustamante", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Ferrini", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Lucas", "Rodriguez", new DateTime(1912, 12, 12), "LaBoca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellin"));
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Object medicoSeleccionado = lstMedicos.SelectedItem;
            Object pacienteSeleccionado = lstPacientes.SelectedItem;
            if ((medicoSeleccionado is not null && medicoSeleccionado is PersonalMedico) && (pacienteSeleccionado is not null && pacienteSeleccionado is Paciente))
            {
                Paciente paciente = (Paciente)pacienteSeleccionado;                
                Consulta consulta = new Consulta(DateTime.Now, paciente);
                MessageBox.Show("Consulta Finalizada");
            } else
            {
                MessageBox.Show("Error en los datos");
            }

            

            lstMedicos.ClearSelected();
            lstPacientes.ClearSelected();
        }
    }
}
