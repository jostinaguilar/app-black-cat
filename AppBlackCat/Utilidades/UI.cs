using System;
using System.Collections.Generic;
using System.Text;

namespace AppBlackCat.Utilidades
{
    internal class UI
    {
        public static void CargarData<T>(DataGridView grid, List<T> datos)
        {
            grid.DataSource = null;
            grid.DataSource = datos;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;

            grid.Columns["Id"]?.Visible = false;
            grid.MultiSelect = false;
            grid.ClearSelection();
        }
    }
}
