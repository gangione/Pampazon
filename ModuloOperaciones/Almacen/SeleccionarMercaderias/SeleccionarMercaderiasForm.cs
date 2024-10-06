using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
public partial class SeleccionarMercaderiasForm : Form
{

    public SeleccionarMercaderiasForm()
    {
        InitializeComponent();
    }

    private void groupBoxTransportista_Enter(object sender, EventArgs e)
    {

    }

    private void listViewMercaderiasEnStock_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void buttonSeleccionar_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("Desea confirmar la baja de stock?");

        // Mostrar un MessageBox de confirmación
        DialogResult resultado = MessageBox.Show("¿Está seguro de confirmar la selección?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        // Evaluar la respuesta del usuario
        if (resultado == DialogResult.Yes)
        {
            // Aquí pones el código para confirmar la selección (por ejemplo, guardar los datos, procesar la orden, etc.)
            MessageBox.Show("Selección confirmada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            // Cancelar la operación
            MessageBox.Show("Selección cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
