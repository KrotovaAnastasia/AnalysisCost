using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace AnalysisCosts
{
    public partial class MainForm : Form
    {
        public enum ChangerMode
        {
            Change,
            Add
        }

        private static int IndexOfChangedElem;

        public MainForm()
        {
            InitializeComponent();//dgjh
        }
        
        //загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                 Table.OpenTable("analysis.xml");
            }
            catch
            {
                 Table.NewTable();
                 Table.SaveTable("analysis.xml");
            }
            wayToolStripStatusLabel.Text = Table.LastOpenedFile;
            UpdateTable();
            if (Table.Data.Count == 0) addRadioButton_CheckedChanged(this, new EventArgs());
            else changeRadioButton_CheckedChanged(this, new EventArgs());
        }

        //Вспомогательные методы

        // Обновление данных таблицы
        public void UpdateTable()
        {
            //тут должен быть код
        }
        
        //Очищение всех полей свойств
        public void ClearInfBox()
        {
            
        }

        //Кнопки
        //Таблица (автоматически созданный метод)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //Кнопки изменения режимов
        //Режим добавить
        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //Режим изменить
        private void changeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        //Нажатие на кнопку  Добавить/Изменить
        private void changeTableButton_Click(object sender, EventArgs e)
        {
            
        }
        
        //Кнопка удалить
        private void deleteButton_Click(object sender, EventArgs e)
        {
            
        }
        
        //Кнопка очистить информацию в боксе
        private void clearInfBoxButton_Click(object sender, EventArgs e)
        {
            ClearInfBox();
        }


/// //////////////////////////////////////////// мб проблема где то здесь
        // Возвращает текущее значение режима изменения таблицы
        public ChangerMode GetMode()
        {
            if (addRadioButton.Checked == true) return ChangerMode.Add;
            else return ChangerMode.Change;
        }

        public void SelectRowInGrid(Row row)
        {
            
        }
/// /////////////////////////////////////////////////////

        //События dataGridView1
        //Обновление нумерации в таблице
        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           
        }

        //Обновление данных в таблице
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        public void DoDataGridView1_SelectionChanged()
        {
            dataGridView1_SelectionChanged(this, new EventArgs());
        }

        //Изменение режима на Изменть при двойном щелчке в таблице 
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (changeRadioButton.Checked != true) changeRadioButton.Checked = true;
        }

        

        //Пункты выпадающего спика "Файл"
        //Кнопка создать
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка открыть
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка сохранить
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Кнопка сохранить как
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Кнопки, вызывающиие формы
        //кнопка вызывающая форму справки
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        //кнопка вызывающая форму о программе
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram form = new AboutProgram();
            form.ShowDialog();
        }

        //Кнопка вызывающая форму динамики затрат
        private void button2_Click(object sender, EventArgs e)
        {
            DynamicCostsForm form = new DynamicCostsForm();
            form.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width, dataGridView1.Size.Height);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
