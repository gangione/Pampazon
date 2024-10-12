using System.Collections;

public class ListViewItemComparer : IComparer
{
    private int _columna;
    private SortOrder _orden;

    public ListViewItemComparer(int columna, SortOrder orden)
    {
        _columna = columna;
        _orden = orden;
    }

    public int Compare(object x, object y)
    {
        ListViewItem itemX = x as ListViewItem;
        ListViewItem itemY = y as ListViewItem;

        string valorX = itemX.SubItems[_columna].Text;
        string valorY = itemY.SubItems[_columna].Text;

        int resultado = string.Compare(valorX, valorY);

        // Si el orden es descendente, invierte el resultado
        if (_orden == SortOrder.Descending)
            resultado *= -1;

        return resultado;
    }
}