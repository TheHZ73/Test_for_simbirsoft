using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//автор Яковлев Дмитрий Александрович
//сотовый 89176203326
//e-mail dddd73@yandex.ru
namespace FindWord_in_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PuthDictionary.Text = @"словарь.txt";
            PuthTestFile.Text = @"проверяемый файл.txt";
        }
        //создание html документа
        private void CreateDocButton_Click(object sender, EventArgs e)
        {
            string Expansion1 = Path.GetExtension(PuthDictionary.Text), Expansion2 = Path.GetExtension(PuthTestFile.Text);

            if ((File.Exists(PuthDictionary.Text)) && (File.Exists(PuthTestFile.Text)))
            {
                if ((Expansion1 == ".txt") && (Expansion2 == ".txt"))
                {
                    FileInfo file = new FileInfo(PuthTestFile.Text);
                    if ((file.Length < 2000000) || (ProcessBigFile.Checked == true))
                    {
                        if ((File.ReadAllLines(PuthDictionary.Text).Length < 100000) || (ProcessBigFile.Checked == true))
                        {
                            var words = File.ReadLines(PuthDictionary.Text, Encoding.Default).Select(i => i.Trim()).ToArray();


                            string result = " ";
                            int Counter_N = 0, z = 0;
                            using (var reader = new StreamReader(PuthTestFile.Text, Encoding.Default))
                            {
                                while (!reader.EndOfStream)
                                {
                                    var w = reader.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                                    for (int i = 0; i < w.Length; i++)
                                    {
                                        if (words.Contains(w[i]))
                                        {
                                            result += @"<b><i>" + w[i] + @"</i></b>" + " ";
                                        }
                                        else
                                        {
                                            result += w[i] + " ";
                                        }
                                    }

                                    Counter_N++;
                                    result += "<br/>";
                                    if (Counter_N == KolStrokHtml.Value)
                                    {
                                        string header = @"<!DOCTYPE html>
                                    <html>
                                    <head>
                                    <title>Прочитанный файл</title>
                                    <meta http-equiv=""content-type"" content=""text/html; charset=windows-1251"" />
                                    </head>
                                    <body>
                                    <div style=""margin:30px"">
                                    <p>" + result + @"</p>
                                    </div>
                                    </body>
                                    </html> ";
                                        File.WriteAllText("default" + z + ".html", header, Encoding.Default);
                                        z++;
                                        result = "";
                                        Counter_N = 0;
                                    }
                                }
                                if (z == 0)
                                {
                                    string header = @"<!DOCTYPE html>
                                    <html>
                                    <head>
                                    <title>Прочитанный файл</title>
                                    <meta http-equiv=""content-type"" content=""text/html; charset=windows-1251"" />
                                    </head>
                                    <body>
                                    <div style=""margin:30px"">
                                    <p>" + result + @"</p>
                                    </div>
                                    </body>
                                    </html> ";
                                    File.WriteAllText("default.html", header, Encoding.Default);
                                    MessageBox.Show("Файл сформирован и лежит в корневой папке под именем default.html");
                                }

                                if (z >= 1)
                                    MessageBox.Show("Файлы сфорированы и лежат в корневой папке под именами default0.html, default1.html...");
                            }
                        }
                        else MessageBox.Show("Строк в файле словаря более 100 тысяч");
                    }
                    else MessageBox.Show("Размер проверочного файла больше 2 Мб");
                }
                else MessageBox.Show("Расширение файла словаря или проверямого файла не .txt");
            }
            else MessageBox.Show("Не найден файл словаря или проверяемый файл");
        }

        //выбирает файл словаря
        private void OpenDict_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PuthDictionary.Text=openFileDialog1.FileName;
            }
        }
        
        //выбирает файл с текстом
        private void PutProvFail_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                PuthTestFile.Text = openFileDialog2.FileName;
            }
        }
    }
}
