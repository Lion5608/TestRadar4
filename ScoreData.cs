using System;
using System.Data;

namespace TscoreTable
{
    public class DataProvider
    {
        private DataTable dataTable;

        public DataProvider()
        {
            dataTable = CreateDataTable();
        }

        public DataTable CreateDataTable()
        {
            DataTable sct = new DataTable();

            // Add columns to the data table
            sct.Columns.Add("Column1", typeof(int));
            sct.Columns.Add("Column2", typeof(string));
            sct.Columns.Add("Column3", typeof(int));
            sct.Columns.Add("Column4", typeof(string));
            sct.Columns.Add("Column5", typeof(int));
            return sct;
        }

        public void AddRow(int column1Value, string column2Value, int column3Value, string column4Value, int column5Value)
        {
            DataRow newRow = dataTable.NewRow();
            newRow["Column1"] = column1Value;
            newRow["Column2"] = column2Value;
            newRow["Column3"] = column3Value;
            newRow["Column4"] = column4Value;
            newRow["Column5"] = column5Value;

            dataTable.Rows.Add(newRow);
        }
        public void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataTable.Rows.Count)
            {
                dataTable.Rows.RemoveAt(rowIndex);
            }
        }
    }
}