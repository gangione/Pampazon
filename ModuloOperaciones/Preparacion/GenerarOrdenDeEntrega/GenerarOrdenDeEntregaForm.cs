using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ModuloOperaciones.Empaquetado.GenerarOrdenDeEntrega;
public partial class GenerarOrdenDeEntregaForm : Form
{
    public GenerarOrdenDeEntregaForm()
    {
        InitializeComponent();
    }

    private void buttonSeleccionar_Click(object sender, EventArgs e)
    {
       
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("Desea confirmar la baja de stock?");

        // Mostrar un MessageBox de confirmación
        DialogResult resultado = MessageBox.Show("¿Está seguro de que desea confirmar la entrega?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // Evaluar la respuesta del usuario
        if (resultado == DialogResult.Yes)
        {
            // Aquí pones el código para confirmar la selección (por ejemplo, guardar los datos, procesar la orden, etc.)
            MessageBox.Show("Orden confirmada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Cancelar la operación
            MessageBox.Show("Orden cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
