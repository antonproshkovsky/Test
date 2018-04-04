using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport_Time
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //создадим таблицу вывода товаров с колонками 
            //Название, Цена, Остаток

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Имя"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = false; //значение в этой колонке нельзя править
            column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Должность";
            column2.Name = "position";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Время работы";
            column3.Name = "workTime";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            dataGridView1.AllowUserToAddRows = true; //запрешаем пользователю самому добавлять строки

            for (int i = 0; i < 5; ++i)
            {
                dataGridView1.Rows.Add("Иван" + i,"Работник Аеропорта", "18:00 - 04.00");
            }

            /*for (int i = 0; i < 5; ++i)
            {
                dataGridView1.Rows.Add();
                dataGridView1["name", dataGridView1.Rows.Count - 1].Value = "Иван" + i;
                dataGridView1["position", dataGridView1.Rows.Count - 1].Value = "Работник Аеропорта";
                dataGridView1["workTime", dataGridView1.Rows.Count - 1].Value = "18:00 - 04.00";
            }*/

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                {
                    object o = dataGridView1[j, i].Value;
                }
            }
        }
    }
}
