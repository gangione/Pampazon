﻿namespace Pampazon.ModuloOperaciones.Preparacion.GenerarOrdenDeEntrega.Utilidades;

public static class Alerta
{
    public static DialogResult PedirConfirmacion(string mensaje)
    {
        return MessageBox.Show(
            mensaje,
            "¿Estás seguro?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );
    }
    public static void MostrarInfo(string mensaje)
    {
        MessageBox.Show(
            mensaje,
            "Información!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }
    public static void MostrarAdvertencia(string mensaje)
    {
        MessageBox.Show(
            mensaje,
            "Advertencia!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );
    }
}