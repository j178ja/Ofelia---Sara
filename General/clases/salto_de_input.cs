using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofelia_Sara
{
    public class salto_de_input : Form
    {
        public salto_de_input()
        {
            // Asociar el evento KeyDown
            this.KeyPreview = true;
            this.KeyDown += salto_de_input_KeyDown;
        }

        private void salto_de_input_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener el control activo
                Control activeControl = this.ActiveControl;

                // Encontrar el siguiente control en el orden de tabulación
                Control nextControl = this.GetNextControl(activeControl, true);

                // Mover el foco al siguiente control si existe
                if (nextControl != null)
                {
                    nextControl.Focus();
                }

                // Indicar que hemos manejado el evento
                e.Handled = true;
            }
        }
    }
}
