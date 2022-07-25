using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_SQL
{
    public class ImportCSV
    {
        List<Records> recordsList;
        MySQLDB mysql;
        public ImportCSV()
        {
            mysql = new MySQLDB();
        }

        public List<Records> OpenFile(string filePath)
        {
            recordsList = new List<Records>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                   
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    try
                    {
                        recordsList.Add(new Records()
                        {
                            Date = values[0],
                            CustomerID = int.Parse(values[1]),
                            PerformanceID = int.Parse(values[2]),
                            Price = double.Parse(values[3]),
                            Quantity = int.Parse(values[4])
                        });
                    }
                    catch (Exception e)
                    {
                    }
                }
                reader.Close();
                return recordsList;
            }
        }

        public List<Records> FindDublicates()
        {
            List<Records> list = recordsList;
            // Überprüft ob die vorhandenen Datarecords existieren und filtert die doppelten raus
            var data = mysql.sqlRead("select * from Performance_DataRecords;");

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (recordsList[j].Equals(data[i]))
                    {
                        list.Remove(list[j]);
                        break;
                    }
                }
            }
            
            return list;
        }

    }
}
