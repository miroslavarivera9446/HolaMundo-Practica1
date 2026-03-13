
Materia CIBERINFRESTUCTURA
Proyecto Practica 1
Miroslava Rivera Villafaña 226394465 
"HolaMundo"

INTRODUCCIÓN 
En esta practica nos solicitaron realizar un proyecto de tipo aplicación “Aplicación DESKTOP de WINFORMS”, incorporando dos campos de texto y un botón y que valide la estructura de una contraseña, la contraseña tendrá que estar conformada por;
•	Al menos una letra mayúscula
•	Al menos una letra minúscula
•	Al menos un símbolo
•	Al menos un número
El proceso deberá correr de la siguiente forma, “si la contraseña ingresada corresponde a las características solicitadas, deberá enviar el mensaje validación y sino deberá la contraseña invalida.
Descripción 
•	Captura de Datos: Recibe dos entradas de texto (tex1 y tex2). 

•	Validación de Formato: Utiliza Expresiones Regulares (Regex) para garantizar la robustez de la contraseña.

•	Validación de Integridad: Compara que ambos campos de contraseña sean idénticos para evitar errores de escritura.
 Proceso 
1.	Inicio: El usuario hace clic en el botón validar.

![imagen_alt](https://github.com/miroslavarivera9446/HolaMundo-Practica1/blob/master/imagen%201.png.jpg)



2.	Filtro de Formato: Se comprueba el patron de Regex.
o	Si falla: Muestra un mensaje de "las contraseñas, no coinciden, favor de verificarlas".


![imagen_alt](https://github.com/miroslavarivera9446/HolaMundo-Practica1/blob/master/imagen%202.jpg)


![imagen_alt](https://github.com/miroslavarivera9446/HolaMundo-Practica1/blob/master/imagen%203.jpg)

3.	Código 
 
using System;
using System.Text.RegularExpressions; // Librería necesaria para usar expresiones regulares
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se dispara al hacer clic en el botón "validar"
        private void validar_Click(object sender, EventArgs e)
        {
            // Obtener el texto de los campos de entrada (TextBox)
            string contraseña1 = tex1.Text;
            string contraseña2 = tex2.Text;

            // Imprime en la consola de depuración de Visual Studio para rastreo
            System.Diagnostics.Debug.WriteLine(contraseña1);

            /* EXPLICACIÓN DEL PATRÓN REGEX:
               ^        : Inicio de la cadena.
               (?=.*[a-z]) : Busca al menos una letra minúscula.
               (?=.*[A-Z]) : Busca al menos una letra mayúscula.
               (?=.*\d)    : Busca al menos un dígito (número).

               (?=.*[\W_]) : Busca al menos un carácter especial (símbolos o guiones).
               .+       : Permite cualquier carácter después de las validaciones.
               $        : Fin de la cadena.
            */
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

            // 1. Validar si la primera contraseña cumple con el formato de seguridad
            if (Regex.IsMatch(contraseña1, patron))
            {
                // 2. Si el formato es correcto, verificar si ambas contraseñas coinciden
                if (contraseña1 == contraseña2)
                {
                    MessageBox.Show("La contraseña ha sido validada correctamente.", "Éxito");
                }
                else
                {
                    // Error si los campos tex1 y tex2 son diferentes
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.", "Error");
                }
            }
            else
            {
                // Error si no cumple con mayúsculas, minúsculas, números o símbolos
                MessageBox.Show("La contraseña debe tener:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo", "Formato inválido");
            }
        }

        // --- Eventos vacíos (pueden eliminarse si no se usan) ---
        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void tex2_TextChanged(object sender, EventArgs e) { }
        private void tex1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
El .* le dice al programa: "busca en cualquier posición de la cadena si existe una minúscula". Sin el asterisco, a veces la validación falla dependiendo de la posición del carácter.
Nota: En el programa aparece el nombre del dominio de la maquina (es prestada CTA CUCEI)
