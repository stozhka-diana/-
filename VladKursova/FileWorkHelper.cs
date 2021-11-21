using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladKursova
{
    class FileWorkHelper
    {
        public const string fileName = "flats.mdb";

        public static void createFile()
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                fs.Flush();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час створення файлу", ex.Message, MessageBoxButtons.OK);
            }
        }

        public static void addWeekend(Flat flat)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(flat.city);
                    bw.Write(flat.address);
                    bw.Write(flat.actuality);
                    bw.Write(flat.createDateTime.ToString());
                    bw.Write(flat.apartmentsAmn);
                    bw.Write(flat.price);
                    bw.Write(flat.toMetroTime);
                }

                MessageBox.Show("Запис був доданий у файл", "Успішно", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час додавання запису в файл", ex.Message, MessageBoxButtons.OK);
            }
        }

        public static List<Flat> readFile()
        {
            List<Flat> flats = new List<Flat>();

            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    while (true)
                    {
                        Flat rec = new Flat(br.ReadString(), br.ReadString(), br.ReadString(),
                            DateTime.Parse(br.ReadString()), br.ReadInt32(), br.ReadInt32(), br.ReadInt32());

                        flats.Add(rec);
                    }
                }
            }
            catch (EndOfStreamException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час зчитування з файлу", ex.Message, MessageBoxButtons.OK);
            }

            return flats;
        }

        public static void saveFile(List<Flat> flats)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    BinaryWriter bw = new BinaryWriter(fs);

                    for (int i = 0; i < flats.Count; i++)
                    {
                        bw.Write(flats[i].city);
                        bw.Write(flats[i].address);
                        bw.Write(flats[i].actuality);
                        bw.Write(flats[i].createDateTime.ToString());
                        bw.Write(flats[i].apartmentsAmn);
                        bw.Write(flats[i].price);
                        bw.Write(flats[i].toMetroTime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка під час запису в файл", ex.Message, MessageBoxButtons.OK);
            }
        }
    }
}
