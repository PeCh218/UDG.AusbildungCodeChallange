using Data;
using Data.Models;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI
{
    public partial class CsvReader : Form
    {

        private List<Artikel> _artikel = new();
        private int _selectedRow = -1;
        private CsvManager _csvManager = new CsvManager();
        public CsvReader()
        {
            InitializeComponent();
            _artikel = _csvManager.ReadCsvFile().ToList();
            artikelGrid.DataSource = _artikel;

            // Geschrieben aber nicht notwenig.
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(addArticle, "Add");

        }
        private void RefreshGrid()
        {
            artikelGrid.DataSource = null;
            artikelGrid.DataSource = _artikel;
        }

        //Buttons
        private void Add_Click(object sender, EventArgs e)
        {
            _artikel.Add(new Artikel());

            RefreshGrid();
            artikelGrid.CurrentCell = artikelGrid[0, artikelGrid.RowCount - 1];
            artikelGrid.BeginEdit(false);
            _selectedRow = _artikel.Count;
        }
        private void deleteArticle_Click(object sender, EventArgs e)
        {
            //abfangen dass auch ein valider index gegeben ist

            _artikel.RemoveAt(_selectedRow);
            RefreshGrid();
        }
        private void save_Click(object sender, EventArgs e)
        {
            _csvManager.WriteCsvFile(_artikel);
        }

        private void artikelGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;
                    
        }

        private DataTable GetArtikelDataTable()
        {
            var table = new DataTable();

            foreach (PropertyInfo info in typeof(Artikel).GetProperties())
            {
                table.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }
            foreach (var artikel in _artikel)
            {
                DataRow row = table.NewRow();
                foreach (PropertyInfo info in typeof(Artikel).GetProperties())
                {
                    row[info.Name] = info.GetValue(artikel, null) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
    }
}