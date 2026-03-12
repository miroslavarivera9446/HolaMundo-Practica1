using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void validar_Click(object sender, EventArgs e)
        {
            string contraseña1 = tex1.Text;
            string contraseña2 = tex2.Text;
            System.Diagnostics.Debug.WriteLine(contraseña1);

            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

            if (Regex.IsMatch(contraseña1, patron))
            {
                if (contraseña1 == contraseña2)
                {
                    MessageBox.Show("La contraseña ha sido validada correctamente.", "Éxito");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.", "Error");
                }
            }
            else
            {
                MessageBox.Show("La contraseña debe tener:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo", "Formato inválido");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tex1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

