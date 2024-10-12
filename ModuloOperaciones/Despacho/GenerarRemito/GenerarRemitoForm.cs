using Pampazon.ModuloOperaciones.Despacho.GenerarRemito.Utilidades;

namespace Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
public partial class GenerarRemitoForm : Form
{
    public GenerarRemitoForm()
    {
        InitializeComponent();
    }

    #region Eventos

    private void buttonDespachar_Click(object sender, EventArgs e)
    {
        if (listViewOrdenesDePreparacionPreparadas.SelectedItems.Count > 0)
        {
            // Obtener el ítem seleccionado
            ListViewItem ordenDePreparacionSelected = listViewOrdenesDePreparacionPreparadas.SelectedItems[0];

            foreach (ListViewItem item in listViewMercaderiasAEntregar.Items)
            {
                if (item.SubItems[0].Text.ToUpper() == ordenDePreparacionSelected.SubItems[0].Text.ToUpper())
                {
                    Alerta.MostrarAdvertencia("Esta orden de preparación ya ha sido agregada. \n" +
                        "Eliminela de la selección e ingresela nuevamente.");
                    return;
                }
            }

            //// Validación para Despacho/Generar Remito? 
            //ListViewItem aSeleccionar = new(ordenDePreparacionSelected.Text);

            //if (listViewOrdenesASeleccionar.Items.Count > 0)
            //{
            //    if (ordenDePreparacionSelected.SubItems[3].Text != listViewOrdenesASeleccionar.Items[0].SubItems[2].Text)
            //    {
            //        Alerta.MostrarAdvertencia("Las ordenes a seleccionar deben ser del mismo cliente.");
            //        return;
            //    }
            //}

        }
        else
        {
            Alerta.MostrarAdvertencia("Debe seleccionar una orden de preparación para despachar.");
            return;
        }
    }

    private void buttonGenerarOrden_Click(object sender, EventArgs e)
    {
        DialogResult resultado = Alerta.PedirConfirmacion("¿Desea confirmar el despacho y la genereación del remito?");

        if (resultado == DialogResult.Yes)
        {
            Alerta.MostrarInfo("Despacho y remito confirmado.");

            //List<string> errores = ValidarFormularioRemito();

            //if (errores.Count > 0)
            //{
            //    Alerta.MostrarErrores(errores);
            //    return;
            //}

            //var resultado = _generarRemitoModel.DespacharOrdenesDePreparacion();

            //if (resultado.Exitoso)
            //{
            //    Alerta.MostrarInfo(resultado.Mensaje);
            //    CargarFormulario();
            //}
            //else
            //    Alerta.MostrarError(resultado.Mensaje);
        }
    }

    #endregion
}