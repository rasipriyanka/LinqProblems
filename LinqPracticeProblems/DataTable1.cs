using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace LinqPracticeProblems
{
    public class DataTable1
    {
        public static void AddDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductId", typeof(string));
            table.Columns.Add("UserId", typeof(string));
            table.Columns.Add("Rating", typeof(float));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));


            table.Rows.Add("1", "ttt@gmail.com", "5", "Excellent", "true");
            table.Rows.Add("2", "kkk@gmail.com", "4", "Good", "true");
            table.Rows.Add("3", "ggh@gmail.com", "3", "Average", "false");
            table.Rows.Add("4", "abc@gmail.com", "2", "BelowAvg", "false");
            Table(table);

        }

        public static void Table(DataTable table)
        {
            var res = (from product in table.AsEnumerable() select product.Field<string>("Review")).ToList();
            foreach (var item in res)
            {
                Console.WriteLine("Review:" + item);
            }
        }
    }
}
