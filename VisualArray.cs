using System.Data;

namespace Пример_таблицы_WPF;

static class VisualArray
{    
    public static DataTable ToDataTable(float[,] matrix)
    {
        DataTable tempDataGrid = new();

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            tempDataGrid.Columns.Add("#" + (i + 1), typeof(float));
        }

        DataRow row = tempDataGrid.NewRow();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                row[j] = matrix[i, j];
            }

            tempDataGrid.Rows.Add(row);
            row = tempDataGrid.NewRow();
        }

        return tempDataGrid;
    }
}