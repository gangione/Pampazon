﻿using Pampazon.ModuloOperaciones.Almacen.SeleccionarMercaderias;
using Pampazon.ModuloOperaciones.Despacho.GenerarRemito;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega;
using Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeSeleccion;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarOrdenesDePrepracion;
using Pampazon.ModuloOperaciones.Recepcion.ConsultarStockDeMercaderias;
using Pampazon.ModuloOperaciones.Recepcion.GenerarOrdenDePreparacion;

namespace Pampazon.MenuInicio
{
    public partial class MenuInicioForm : Form
    {
        public MenuInicioForm()
        {
            InitializeComponent();
        }

        private void buttonPedirMercaderiasDeCliente_Click(object sender, EventArgs e)
        {
            var generarOrdenDePreparacion = new GenerarOrdenDePreparacionForm();
            generarOrdenDePreparacion.ShowDialog();
        }

        private void buttonOrdenDeSeleccion_Click(object sender, EventArgs e)
        {
            var generarOrdenDeSeleccion = new GenerarOrdenDeSeleccionForm();
            generarOrdenDeSeleccion.ShowDialog();
        }

        private void buttonSeleccionMercaderias_Click(object sender, EventArgs e)
        {
            var seleccionMercaderias = new SeleccionarMercaderiasForm();
            seleccionMercaderias.ShowDialog();
        }

        private void buttonEmpaquetar_Click(object sender, EventArgs e)
        {
            var ordenDeEntrega = new GenerarOrdenDeEntregaForm();
            ordenDeEntrega.ShowDialog();
        }

        private void buttonDespachar_Click(object sender, EventArgs e)
        {
            var despachar = new GenerarRemitoForm();
            despachar.ShowDialog();
        }

        private void buttonConsultarOrdenesDePreparacion_Click(object sender, EventArgs e)
        {
            var consultarOps = new ConsultarOrdenesDePreparacionForm();
            consultarOps.ShowDialog();
        }

        private void buttonConsultarStockDeMercaderias_Click(object sender, EventArgs e)
        {
            var consultarStock = new ConsultarStockDeMercaderiasForm();
            consultarStock.ShowDialog();
        }
    }
}