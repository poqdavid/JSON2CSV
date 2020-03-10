using ChoETL;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JSON2CSV
{
    public partial class J2C_Form : Form
    {
        public List<String> file_list = new List<string>();
        public Dictionary<string, string> data_list = new Dictionary<string, string>();
        public Dictionary<string, JsonTextReader> json_list = new Dictionary<string, JsonTextReader>();
        public Dictionary<string, StringBuilder> csv_list = new Dictionary<string, StringBuilder>();
        public Dictionary<int, Dictionary<string, string>> json_data = new Dictionary<int, Dictionary<string, string>>();
        public Dictionary<string, KeyValuePair<string, string>> csv_cols_data = new Dictionary<string, KeyValuePair<string, string>>();
        public List<String> col_list = new List<string>();

        public J2C_Form()
        {
            InitializeComponent();
        }

        private void J2C_Form_Load(object sender, EventArgs e)
        {
        }

        private void J2C_Convert_Click(object sender, EventArgs e)
        {
            J2C_Button_Save.Enabled = false;
            J2C_Button_Convert.Enabled = false;
            J2C_SaveToolStripMenuItem.Enabled = false;

            file_list.Clear();
            data_list.Clear();
            json_list.Clear();
            csv_list.Clear();
            json_data.Clear();
            csv_cols_data.Clear();
            col_list.Clear();
            J2C_DataGridView.Rows.Clear();
            J2C_DataGridView.Columns.Clear();

            foreach (String item in J2C_ListBox_Folder.Items)
            {
                foreach (String file in Directory.GetFiles(item, "*.json", SearchOption.AllDirectories))
                {
                    file_list.Add(file);
                }
            }

            foreach (String file in file_list)
            {
                try
                {
                    string jsonString = File.ReadAllText(file);

                    this.json_list.Add(file, new JsonTextReader(new StringReader(jsonString)));
                }
                catch (Exception ex)
                {
                    J2C_ListBox_Logs.Items.Add(file);
                    J2C_ListBox_Logs.Items.Add(ex.StackTrace);
                    J2C_ListBox_Logs.Items.Add(ex.Message);
                }
            }

            List<string> line = new List<string>();
            foreach (String fullpath in json_list.Keys)
            {
                try
                {
                    JsonTextReader obj = json_list[fullpath];
                    StringBuilder csvData = new StringBuilder();

                    using (var r = new ChoJSONReader().Load(obj).WithJSONPath(J2C_TextBox_JPath.Text))
                    {
                        using (var w = new ChoCSVWriter(csvData).WithFirstLineHeader())
                        {
                            w.Write(r);
                        }
                    }

                    csv_list.Add(fullpath, csvData);
                    line.Add(csvData.ToString());
                }
                catch (Exception ex)
                {
                    J2C_ListBox_Logs.Items.Add(fullpath);
                    J2C_ListBox_Logs.Items.Add(ex.StackTrace);
                    J2C_ListBox_Logs.Items.Add(ex.Message);
                }
            }

            foreach (String fullpath in csv_list.Keys)
            {
                StringBuilder csvData = csv_list[fullpath];
                string col1 = csvData.ToString().Split("\n").ToArray()[0];
                string col2 = NumReplace(col1, 200);
                col2 = col2.Replace("\n", "");
                csv_cols_data.Add(fullpath, new KeyValuePair<string, string>(col1, col2));

                foreach (string key in col2.Split(","))
                {
                    string txtout = RemoveChars(key);
                    if (!col_list.Contains(txtout))
                    {
                        col_list.Add(txtout);
                    }
                }
            }

            foreach (string key in col_list)
            {
                try
                {
                    DataGridViewColumn DGVC = new DataGridViewColumn();
                    DGVC.Name = key;
                    DGVC.HeaderText = key;
                    DGVC.HeaderCell.Value = key;
                    DGVC.CellTemplate = new DataGridViewTextBoxCell();
                    J2C_DataGridView.Columns.Add(DGVC);
                }
                catch (Exception ex2)
                {
                    J2C_ListBox_Logs.Items.Add(key);
                    J2C_ListBox_Logs.Items.Add(ex2.Message);
                }
            }

            foreach (String fullpath in csv_list.Keys)
            {
                J2C_DataGridView.Rows.Add();
            }

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                int i = 0;

                foreach (String fullpath in csv_list.Keys)
                {
                    try
                    {
                        DataGridViewRow DGVC = new DataGridViewRow();

                        string csv = csv_list[fullpath].ToString();
                        KeyValuePair<string, string> cols = csv_cols_data[fullpath];

                        string[] cols1 = cols.Key.Split(",");
                        string[] cols2 = cols.Value.Split(",");

                        int colindex = 0;
                        foreach (string colx in cols2)
                        {
                            string colnameorg = cols1[colindex];
                            string colname = RemoveChars(cols2[colindex]);
                            string colvalue = RemoveChars(csv_list[fullpath].ToString().Split("\n")[1].Split(",")[colindex]);

                            J2C_DataGridView.Invoke((Action)delegate
                            {
                                string valx = J2C_DataGridView.Rows[i].Cells[colname].Value == null ? string.Empty : J2C_DataGridView.Rows[i].Cells[colname].Value.ToString();

                                if (valx.IsEmpty())
                                {
                                    J2C_DataGridView.Rows[i].Cells[colname].Value = colvalue;

                                    J2C_DataGridView.Rows[i].Cells[colname].ToolTipText = colnameorg + "<>" + colvalue;
                                }
                                else
                                {
                                    J2C_DataGridView.Rows[i].Cells[colname].Value += J2C_TextBox_JSep.Text + colvalue;
                                    J2C_DataGridView.Rows[i].Cells[colname].ToolTipText += J2C_TextBox_JSep.Text + colnameorg + "<>" + colvalue;
                                }
                            });

                            colindex++;
                        }

                        i++;
                    }
                    catch (Exception ex)
                    {
                        J2C_ListBox_Logs.Items.Add("DG: " + fullpath);
                        J2C_ListBox_Logs.Items.Add(ex.StackTrace);
                        J2C_ListBox_Logs.Items.Add(ex.Message);
                    }
                }
                J2C_Button_Convert.Invoke((Action)delegate
                {
                    J2C_Button_Convert.Enabled = true;
                });

                J2C_Button_Save.Invoke((Action)delegate
                {
                    J2C_Button_Save.Enabled = true;
                });
            }).Start();
        }

        private void J2C_AddFolder_Click(object sender, EventArgs e)
        {
            var cofd = new CommonOpenFileDialog
            {
                EnsurePathExists = true,
                EnsureFileExists = false,
                AllowNonFileSystemItems = false,
                DefaultFileName = "Select Folder",
                IsFolderPicker = true,
                Title = "Select a Folder"
            };

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                J2C_ListBox_Folder.Items.Add(Directory.Exists(cofd.FileName) ? cofd.FileName : Path.GetDirectoryName(cofd.FileName));
            }
        }

        private void J2C_Save_Click(object sender, EventArgs e)
        {
            var csfd = new CommonSaveFileDialog
            {
                DefaultFileName = "data.csv",
                Title = "Save File",
                AlwaysAppendDefaultExtension = true,
                DefaultExtension = ".csv"
            };
            csfd.Filters.Add(new CommonFileDialogFilter("Comma-separated values", "*.csv"));

            if (csfd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SaveDataGridViewToCSV2(csfd.FileName);
            }
        }

        public static string NumReplace(string inpute, int max)
        {
            string outx = inpute;

            for (int i = 0; i < max;)
            {
                outx = outx.ToString().Replace("_" + i + "_", "_");
                i++;
            }

            for (int i = 0; i < max;)
            {
                outx = outx.ToString().Replace("_" + i, "");
                i++;
            }

            return outx;
        }

        public static string RemoveChars(string input)
        {
            string txtout = input;
            string[] charactersToReplace = new string[] { "\t", "\n", "\r", "\n\r", "\r\n", " " };
            foreach (string s in charactersToReplace)
            {
                txtout = txtout.Replace(s, "");
            }

            return txtout;
        }

        public void SaveDataGridViewToCSV2(string filename)
        {
            var sb = new StringBuilder();

            var headers = J2C_DataGridView.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in J2C_DataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            System.IO.File.WriteAllText(filename, sb.ToString());
        }

        private void J2C_About_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void J2C_Button_Save_EnabledChanged(object sender, EventArgs e)
        {
            J2C_SaveToolStripMenuItem.Enabled = J2C_Button_Save.Enabled;
        }
    }
}