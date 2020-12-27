using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AnalysisCosts
{
    /// <summary>
    /// Класс с таблицей
    /// </summary>
    public static class Table
    {
        public static BindingList<Row> Data { get; private set; }

        /// <summary>
        /// Поле с актуальным файлом таблицы
        /// </summary>
        public static string LastOpenedFile { get; private set; }

        public static void NewTable()
        {
            Data = new BindingList<Row>();
        }

        //Открытие таблицы
        public static void OpenTable(string way)
        {
            XmlSerializer formater = new XmlSerializer(typeof(BindingList<Row>));
            using (FileStream fs = new FileStream(way, FileMode.OpenOrCreate))
            {
                BindingList<Row> newData = (BindingList<Row>)formater.Deserialize(fs);
                Table.Data = newData;
            }
            LastOpenedFile = way;
        }

        //Сохранение таблицы
        public static void SaveTable(string way)
        {
            if (File.Exists(way)) File.Delete(way);
            XmlSerializer formater = new XmlSerializer(typeof(BindingList<Row>));
            using (FileStream fs = new FileStream(way, FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, Table.Data);
            }
            LastOpenedFile = way;
        }

        //Удаление таблицы
        public static void Delete(Row row)
        {
            Data.Remove(row);
        }

        //Изменение таблицы
        public static void Change(Row row, int index)
        {
            if (!Table.Data.Contains(row))
            {
                Table.Data[index].CostItem = row.CostItem;
                Table.Data[index].PlannedСosts = row.PlannedСosts;
                Table.Data[index].ActualСosts = row.ActualСosts;
                Table.Data[index].Deviations = Row.CalculationOfDeviations(row);
                Table.Data[index].PlannedCostStructure = Row.CalculationPlannedCostsStructure(row);
                Table.Data[index].ActualСostsStructure = Row.CalculationActualСostsStructure(row);
                Table.Data[index].DeviationsСostsStructure = Row.CalculationDeviationsСostsStructure(row);
            }
            else MessageBox.Show("Такой объект уже существует");
        }

        //Добавление в таблицу
        public static void Add(Row row)
        {
            if (!Table.Data.Contains(row))
            {
                row.Deviations = Row.CalculationOfDeviations(row);
                row.PlannedCostStructure = Row.CalculationPlannedCostsStructure(row);
                row.ActualСostsStructure = Row.CalculationActualСostsStructure(row);
                row.DeviationsСostsStructure = Row.CalculationDeviationsСostsStructure(row);
                Table.Data.Add(row);
            }
            else MessageBox.Show("Такой объект уже существует");
        }
    }

    [Serializable]
    public class Row
    {
        private string costItem;
        public string CostItem
        {
            get { return costItem; }
            set
            {
                if (value != "") costItem = value;
                else throw new Exception();

            }
        }

        private double plannedСosts;
        public double PlannedСosts
        {
            get { return plannedСosts; }
            set
            {
                if (value >= 0) plannedСosts = value;
                else throw new Exception();
            }
        }

        private double actualСosts;
        public double ActualСosts
        {
            get { return actualСosts; }
            set
            {
                if (value >= 0) actualСosts = value;
                else throw new Exception();
            }
        }
        public double Deviations { get; set; }
        public int PlannedCostStructure { get; set; }
        public int ActualСostsStructure { get; set; }
        public int DeviationsСostsStructure { get; set; }

        // Расчет отклонений по статям затрат в руб
        public static double CalculationOfDeviations(Row row)
        {
            return Math.Abs(row.ActualСosts - row.PlannedСosts);
        }

        // Расчет плановой структуры затрат, %
        public static int CalculationPlannedCostsStructure(Row row)
        {
            return 1;  //написать код
        }

        // Расчет фактической структуры затрат, %
        public static int CalculationActualСostsStructure(Row row)
        {
            return 1;  //написать код
        }

        // Расчет отклонений по статьям затрат, %
        public static int CalculationDeviationsСostsStructure(Row row)
        {
            return 1;  //написать код
        }

    /*    //Сравнитель
        public override bool Equals(object obj)
        {
            Row row = (Row)obj;
            if
                (
                this.CostItem == row.CostItem &&
                this.PlannedСosts == row.PlannedСosts &&
                this.ActualСosts == row.ActualСosts
                )
                return true;
            else return false;
        }

        /// Visual studio создал это сам, так как мы переопределили Equals
        public override int GetHashCode()
        {
            var hashCode = 279289732;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CostItem);
            hashCode = hashCode * -1521134295 + PlannedСosts.GetHashCode();
            hashCode = hashCode * -1521134295 + ActualСosts.GetHashCode();
            hashCode = hashCode * -1521134295 + Deviations.GetHashCode();
            hashCode = hashCode * -1521134295 + PlannedCostStructure.GetHashCode();
            hashCode = hashCode * -1521134295 + ActualСostsStructure.GetHashCode();
            hashCode = hashCode * -1521134295 + DeviationsСostsStructure.GetHashCode();
            return hashCode;
        }*/

        public Row() { }
        //Конструктор
        public Row(string costItem, double plannedСosts, double actualСosts)
        {
            this.CostItem = costItem;
            this.PlannedСosts = plannedСosts;
            this.ActualСosts = actualСosts;
            this.Deviations = CalculationOfDeviations(this);
            this.PlannedCostStructure = CalculationPlannedCostsStructure(this);
            this.ActualСostsStructure = CalculationActualСostsStructure(this);
            this.DeviationsСostsStructure = CalculationDeviationsСostsStructure(this);
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
