using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladKursova
{
    public class Flat
    {
        public string city { get; set; }
        public string address { get; set; }
        public string actuality { get; set; }
        public DateTime createDateTime { get; set; }
        public int apartmentsAmn { get; set; }
        public int price { get; set; }
        public int toMetroTime { get; set; }

        public Flat(string city, string address, string actuality,
            DateTime createDateTime, int apartmentsAmn, int price, int toMetroTime)
        {
            this.city = city;
            this.address = address;
            this.actuality = actuality;
            this.createDateTime = createDateTime;
            this.apartmentsAmn = apartmentsAmn;
            this.price = price;
            this.toMetroTime = toMetroTime;
        }
    }

    public partial class Form1 : Form
    {
        private List<Flat> flats = new List<Flat>();
        private bool searchOn = false;

        public Form1()
        {
            InitializeComponent();
            SearchByCB.SelectedIndex = 0;
            ActualityCB.SelectedIndex = 0;

            if (File.Exists(FileWorkHelper.fileName))
            {
                flats = FileWorkHelper.readFile();
                fillDatagrid(flats, 1);
            }
            else
                FileWorkHelper.createFile();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(CityTB.Text.Trim() == "" || AddressTB.Text.Trim() == "")
            {
                MessageBox.Show("Зповніть всі поля", "Помилка", MessageBoxButtons.OK);
                return;
            }

            Flat flat = new Flat(CityTB.Text.Trim(), AddressTB.Text.Trim(), ActualityCB.Items[ActualityCB.SelectedIndex].ToString(), 
                DateTime.Now, (int)ApartmentsAmnNUD.Value, (int)PriceNUD.Value, (int)ToMetroMinNUD.Value);

            FileWorkHelper.addWeekend(flat);
            flats.Add(flat);

            if (searchOn && flat.actuality == "здана")
                return;

            fillDatagrid(flats, 1);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if ((SearchByCB.SelectedIndex == 1 || SearchByCB.SelectedIndex == 2 || SearchByCB.SelectedIndex == 3) &&
                int.TryParse(SearchQueryTB.Text, out int i) || SearchByCB.SelectedIndex == 0 || SearchByCB.SelectedIndex == 4)
            {
                searchOn = true;
                fillDatagrid(search(SearchQueryTB.Text, SearchByCB.SelectedIndex + 1), 2);
            }
            else
                MessageBox.Show("Перевірте введені дані для пошуку", "Помилка", MessageBoxButtons.OK);
        }

        private void CancelSearchBtn_Click(object sender, EventArgs e)
        {
            searchOn = false;
            fillDatagrid(flats, 1);
        }

        private void fillDatagrid(List<Flat> flts, int type)
        {
            flts = reverse(flts);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < flts.Count; i++)
            {
                if (type == 2)
                {
                    if (flts[i].actuality == "не здана")
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = flts[i].city;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = flts[i].address;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = flts[i].apartmentsAmn;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = flts[i].price;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = flts[i].toMetroTime;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = flts[i].actuality;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Value = flts[i].createDateTime.ToShortDateString() + " " + flts[i].createDateTime.ToShortTimeString();
                    }
                }
                else
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = flts[i].city;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = flts[i].address;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = flts[i].apartmentsAmn;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = flts[i].price;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = flts[i].toMetroTime;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = flts[i].actuality;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Value = flts[i].createDateTime.ToShortDateString() + " " + flts[i].createDateTime.ToShortTimeString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && !searchOn)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                flats.RemoveAt(e.RowIndex);

                FileWorkHelper.saveFile(flats);
            }
        }

        private List<Flat> search(string query, int type)
        {
            List<Flat> flts = new List<Flat>();

            for (int i = 0; i < flats.Count; i++)
            {
                if (type == 1 && flats[i].city == query)
                    flts.Add(flats[i]);
                else if (type == 2 && flats[i].apartmentsAmn >= int.Parse(query))
                    flts.Add(flats[i]);
                else if (type == 3 && flats[i].apartmentsAmn <= int.Parse(query))
                    flts.Add(flats[i]);
                else if (type == 4 && flats[i].toMetroTime <= int.Parse(query))
                    flts.Add(flats[i]);
                else if (type == 5)
                {
                    int query1;
                    bool isDigit = int.TryParse(query, out query1);

                    if (flats[i].city == query || (isDigit && (flats[i].city == query || flats[i].apartmentsAmn == query1
                     || flats[i].toMetroTime <= query1)))
                        flts.Add(flats[i]);
                }
            }

            return flts;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            List<Flat> flts = new List<Flat>();

            for(int i = flats.Count - 1; i >= 0; i--)
            {
                flts.Add(new Flat(flats[i].city, flats[i].address, flats[i].actuality, flats[i].createDateTime, 
                    flats[i].apartmentsAmn, flats[i].price, flats[i].toMetroTime));
            }

            try
            {
                for (int i = 0; i < flts.Count; i++)
                {
                    flts[i].city = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    flts[i].address = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    flts[i].apartmentsAmn = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    flts[i].price = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    flts[i].toMetroTime = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    flts[i].actuality = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    flts[i].createDateTime = DateTime.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Перевірте дані які ви змінили", "Помилка", MessageBoxButtons.OK);
            }

            flats = reverse(flts);
            FileWorkHelper.saveFile(flats);
            MessageBox.Show("Файл збережено успішно", "Успішно", MessageBoxButtons.OK);
        }

        private List<Flat> reverse(List<Flat> flts)
        {
            List<Flat> fltsRes = new List<Flat>();

            for (int i = flts.Count - 1; 0 <= i; i--)
                fltsRes.Add(flts[i]);

            return fltsRes;
        }
    }
}
