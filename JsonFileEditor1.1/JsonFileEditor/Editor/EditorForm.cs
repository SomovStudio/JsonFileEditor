using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using JsonFileEditor.Editor.data;
using JsonFileEditor.Editor.json;
using JsonFileEditor.Editor;

namespace JsonFileEditor.Editor
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        string _safeFileName = "empty.json";
        string _pathFileName = "";

        private void consoleMessage(String message) // вывести информацию в консоль
        {
            try
            {
                consoleRichTextBox.Text = consoleRichTextBox.Text + message + Environment.NewLine;
                consoleRichTextBox.Select(consoleRichTextBox.Text.Length, consoleRichTextBox.Text.Length);
                consoleRichTextBox.ScrollToCaret();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void consoleClear() // очистить консоль
        {
            try
            {
                consoleRichTextBox.Clear();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataForms.CountEditorForms++;
                _pathFileName = _safeFileName;
                toolStripStatusLabel4.Text = _pathFileName;
                treeView1.Nodes.Add(_safeFileName);
                createTable();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void createNewFile() // создать новый файл
        {
            try
            {
                EditorForm editor = new EditorForm();
                editor.Show();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void openFile() // открыть файл
        {
            if (openJsonFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    treeView1.Nodes.Clear();
                    createTable();

                    _safeFileName = openJsonFileDialog.SafeFileName;
                    _pathFileName = openJsonFileDialog.FileName;
                    toolStripStatusLabel4.Text = _pathFileName;

                    StreamReader sr = new StreamReader(_pathFileName, Encoding.UTF8);
                    string jsonText = sr.ReadToEnd();
                    sr.Close();

                    treeView1.Nodes.Add(JsonData.SetDataInTreeView(jsonText, _safeFileName));

                    if (treeView1.Nodes[0].Nodes.Count > 0)
                    {
                        updateEditorRichTextBox();
                    }
                }
                catch (Exception ex)
                {
                    consoleMessage("Ошибка: " + ex.Message);
                }
            }
        }

        private void savefile() // сохранить файл
        {
            try
            {
                if (File.Exists(_pathFileName))
                {

                    if (treeView1.Nodes.Count <= 0)
                    {
                        consoleMessage("Нет данных для сохранения файла");
                        return;
                    }

                    if (treeView1.Nodes[0].Nodes.Count > 0)
                    {
                        JsonData.indexTextLine = 0;
                        editorRichTextBox.Text = JsonData.GetTextFromTreeView(treeView1.Nodes[0].Nodes[0], 0);
                    }

                    using (StreamWriter sw = new StreamWriter(_pathFileName))
                    {
                        foreach (string line in editorRichTextBox.Lines)
                        {
                            sw.WriteLine(line);

                        }
                        sw.Close();
                        this.Text = "Json File Editor v 1.0";
                    }
                }
                else
                {
                    saveFileAs();
                }
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void saveFileAs() // сохранить файл как
        {
            try
            {
                if (treeView1.Nodes.Count <= 0)
                {
                    consoleMessage("Нет данных для сохранения файла");
                    return;
                }

                saveJsonFileDialog.FileName = _safeFileName;
                if (saveJsonFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(saveJsonFileDialog.FileName);
                    _safeFileName = fi.Name;
                    _pathFileName = saveJsonFileDialog.FileName;
                    toolStripStatusLabel4.Text = _pathFileName;

                    if (treeView1.Nodes[0].Nodes.Count > 0)
                    {
                        JsonData.indexTextLine = 0;
                        editorRichTextBox.Text = JsonData.GetTextFromTreeView(treeView1.Nodes[0].Nodes[0], 0);
                    }

                    using (StreamWriter sw = new StreamWriter(_pathFileName))
                    {
                        foreach (string line in editorRichTextBox.Lines)
                        {
                            sw.WriteLine(line);

                        }
                        sw.Close();
                        this.Text = "Json File Editor v 1.0";
                    }
                }
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        DataSet _ds;
        DataTable _dt;
        private void createTable() // инициализация таблицы
        {
            try
            {
                dataGridView1.DataSource = null;
                _ds = new DataSet();
                _dt = new DataTable();
                _dt.Columns.Add("Key", Type.GetType("System.String"));
                _dt.Columns.Add("Value", Type.GetType("System.String"));
                _ds.Tables.Add(_dt);
                dataGridView1.DataSource = _ds.Tables[0];
                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns[0].HeaderText = "Ключ";
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[1].HeaderText = "Значение";
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void clearTable() // очистить таблицу
        {
            try
            {
                _ds.Tables[0].Clear();
                dataGridView1.Update();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        TreeNode _selectedNode;
        private void setNodeInDataGridView() // заполнить таблицу данными из узла
        {
            try
            {
                if (_selectedNode == null) _selectedNode = getSelectNode();
                if (_selectedNode == null)
                {
                    consoleMessage("В дереве объектов нет выбранного узла");
                    return;
                }

                _ds.Tables[0].Rows.Clear();
                DataRow row;

                if (_selectedNode.Text == _safeFileName) return;

                string key = "";
                string value = "";
                string token = "";

                if (_selectedNode.Nodes.Count > 0) // Обработка узла
                {

                    foreach (TreeNode n in _selectedNode.Nodes)
                    {
                        if (n.Text.Contains("\":"))
                        {
                            foreach (char c in n.Text)
                            {
                                if (c == ':' && key == "")
                                {
                                    key = token;
                                    token = "";
                                }
                                else if (c == ':' && key != "")
                                {
                                    token += c;
                                }
                                if (c != ':') token += c;
                            }
                            value = token;
                            token = "";
                        }
                        else
                        {
                            key = "";
                            value = n.Text;
                        }

                        key = key.Trim();
                        value = value.Trim();
                        if (value[value.Length - 1] == ',') value = value.Remove(value.Length - 1, 1);

                        row = _dt.NewRow();
                        row["Key"] = key;
                        row["Value"] = value;
                        _ds.Tables[0].Rows.Add(row);

                        key = "";
                        value = "";
                        token = "";
                    }
                }
                else if (_selectedNode.Text.Contains("[ ]") == false && _selectedNode.Text.Contains("{ }") == false) // Обработка строки
                {
                    if (_selectedNode.Text.Contains("\":"))
                    {
                        foreach (char c in _selectedNode.Text)
                        {
                            if (c == ':' && key == "")
                            {
                                key = token;
                                token = "";
                            }
                            else if (c == ':' && key != "")
                            {
                                token += c;
                            }
                            if (c != ':') token += c;
                        }
                        value = token;
                        token = "";
                    }
                    else
                    {
                        key = "";
                        value = _selectedNode.Text;
                    }

                    key = key.Trim();
                    value = value.Trim();
                    if (value[value.Length - 1] == ',') value = value.Remove(value.Length - 1, 1);

                    row = _dt.NewRow();
                    row["Key"] = key;
                    row["Value"] = value;
                    _ds.Tables[0].Rows.Add(row);

                    key = "";
                    value = "";
                    token = "";
                }

                foreach (DataGridViewRow viewRow in dataGridView1.Rows)
                {
                    if (viewRow.Cells["Value"].Value != null)
                    {
                        if (viewRow.Cells["Value"].Value.ToString() == "{ }") viewRow.Cells["Value"].ReadOnly = true;
                        if (viewRow.Cells["Value"].Value.ToString() == "[ ]") viewRow.Cells["Value"].ReadOnly = true;
                    }
                }

                if (_selectedNode.Text.Contains("{ }") || _selectedNode.Text.Contains("[ ]")) dataGridView1.AllowUserToAddRows = true;
                else dataGridView1.AllowUserToAddRows = false; // запрещаем добавление строк
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private TreeNode getSelectNode() // получить выбранный узел
        {
            try
            {
                if (treeView1.SelectedNode.Text != _safeFileName) return treeView1.SelectedNode;
                else
                {
                    if (treeView1.SelectedNode.Nodes.Count > 0) return null;
                    else return treeView1.SelectedNode;
                }
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
                return null;
            }
        }

        public TreeNode getNodeByLineNumber(object tag, TreeNode rootNode) // получить узел по номеру строки
        {
            try
            {
                foreach (TreeNode node in rootNode.Nodes)
                {
                    if (node.Tag.Equals(tag)) return node;
                    var next = getNodeByLineNumber(tag, node);
                    if (next != null) return next;
                }
                return null;
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
                return null;
            }
        }

        private void addObjectInTree() // добавить объект в дерево
        {
            try
            {
                if (_selectedNode == null) _selectedNode = getSelectNode();
                if (_selectedNode == null)
                {
                    consoleMessage("В дереве объектов нет выбранного узла");
                    return;
                }

                if (_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
                {
                    consoleMessage("Невозможно добавить объект в значение. Объект можно добавить только в другой объект или в массив.");
                    return;
                }

                int count = _selectedNode.Nodes.Count;
                if (count > 0)
                {
                    string text = _selectedNode.Nodes[count - 1].Text;
                    int lenght = text.Length;
                    if (text[lenght - 1] != ',' && text[lenght - 1] != ']' && text[lenght - 1] != '}')
                    {
                        text += ",";
                        _selectedNode.Nodes[count - 1].Text = text;
                    }
                }
                _selectedNode.Nodes.Add("{ }");
                setNodeInDataGridView();

                updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
                this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void addArrayInTree() // добавить массив в дерево
        {
            try
            {
                if (_selectedNode == null) _selectedNode = getSelectNode();
                if (_selectedNode == null)
                {
                    consoleMessage("В дереве объектов нет выбранного узла");
                    return;
                }

                if (_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
                {
                    consoleMessage("Невозможно добавить массив в значение. Массив можно добавить только в объект или в другой массив.");
                    return;
                }

                int count = _selectedNode.Nodes.Count;
                if (count > 0)
                {
                    string text = _selectedNode.Nodes[count - 1].Text;
                    int lenght = text.Length;
                    if (text[lenght - 1] != ',' && text[lenght - 1] != ']' && text[lenght - 1] != '}')
                    {
                        text += ",";
                        _selectedNode.Nodes[count - 1].Text = text;
                    }
                }
                _selectedNode.Nodes.Add("[ ]");
                setNodeInDataGridView();

                updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
                this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void addKeyValueInTree() // добавить ключь/значение в дерево
        {
            try
            {
                if (_selectedNode == null) _selectedNode = getSelectNode();
                if (_selectedNode == null)
                {
                    consoleMessage("В дереве объектов нет выбранного узла");
                    return;
                }

                if (_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
                {
                    consoleMessage("Невозможно добавить значение в другое значение. Значение можно добавить только в объект или в массив.");
                    return;
                }

                int count = _selectedNode.Nodes.Count;
                if (count > 0)
                {
                    string text = _selectedNode.Nodes[count - 1].Text;
                    int lenght = text.Length;
                    if (text[lenght - 1] != ',' && text[lenght - 1] != ']' && text[lenght - 1] != '}')
                    {
                        text += ",";
                        _selectedNode.Nodes[count - 1].Text = text;
                    }
                }
                _selectedNode.Nodes.Add("\"Key\": 0");
                setNodeInDataGridView();

                updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
                this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void addValueInTree() // добавить значение в дерево
        {
            try
            {
                if (_selectedNode == null) _selectedNode = getSelectNode();
                if (_selectedNode == null)
                {
                    consoleMessage("В дереве объектов нет выбранного узла");
                    return;
                }

                if (_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
                {
                    consoleMessage("Невозможно добавить значение в другое значение. Значение можно добавить только в объект или в массив.");
                    return;
                }

                int count = _selectedNode.Nodes.Count;
                if (count > 0)
                {
                    string text = _selectedNode.Nodes[count - 1].Text;
                    int lenght = text.Length;
                    if (text[lenght - 1] != ',' && text[lenght - 1] != ']' && text[lenght - 1] != '}')
                    {
                        text += ",";
                        _selectedNode.Nodes[count - 1].Text = text;
                    }
                }
                _selectedNode.Nodes.Add("0");
                setNodeInDataGridView();

                updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
                this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private void deleteNodeInTree() // удалить узел дерева
        {
            try
            {
                if (_selectedNode == null) _selectedNode = getSelectNode();
                if (_selectedNode == null)
                {
                    consoleMessage("В дереве объектов нет выбранного узла");
                    return;
                }

                if (_selectedNode.Text == _safeFileName)
                {
                    consoleMessage("Невозможно удалить коренной узел который является основой файла " + _safeFileName);
                    return;
                }

                if (MessageBox.Show("Удалить запись '" + _selectedNode.Text + "' безвозвратно?", "Вопрос", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return; // отмена удаления
                }

                TreeNode parent = _selectedNode.Parent;
                _selectedNode.Remove();
                _selectedNode = null;
                dataGridView1.AllowUserToAddRows = false;

                int count = parent.Nodes.Count;
                if (count > 0)
                {
                    string text = parent.Nodes[count - 1].Text;
                    int lenght = text.Length;
                    if (text[lenght - 1] == ',')
                    {
                        text = text.Remove(lenght - 1, 1);
                        parent.Nodes[count - 1].Text = text;
                    }
                }

                clearTable();
                treeView1.Focus();
                setNodeInDataGridView();

                updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
                this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        private int getStringNumber() // получить номер выбранной строки
        {
            try
            {
                int selectLine = editorRichTextBox.GetLineFromCharIndex(editorRichTextBox.SelectionStart) + 1;
                label9.Text = "Строка: " + selectLine.ToString();
                return selectLine;
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
                return 0;
            }
        }

        /* Поиск по тексту */
        int _findIndex = 0;
        int _findLast = 0;
        String _findText = "";
        private void findText(ToolStripComboBox _cbox)
        {
            try
            {
                bool resolution = true;
                for (int k = 0; k < _cbox.Items.Count; k++)
                    if (_cbox.Items[k].ToString() == _cbox.Text) resolution = false;
                if (resolution) _cbox.Items.Add(_cbox.Text);
                if (_findText != _cbox.Text)
                {
                    _findIndex = 0;
                    _findLast = 0;
                    _findText = _cbox.Text;
                }
                if (editorRichTextBox.Find(_cbox.Text, _findIndex, editorRichTextBox.TextLength - 1, RichTextBoxFinds.None) >= 0)
                {
                    editorRichTextBox.Select();
                    _findIndex = editorRichTextBox.SelectionStart + editorRichTextBox.SelectionLength;
                    if (_findLast == editorRichTextBox.SelectionStart)
                    {
                        consoleMessage("Поиск завершен.");
                        _findIndex = 0;
                        _findLast = 0;
                        _findText = _cbox.Text;
                    }
                    else
                    {
                        _findLast = editorRichTextBox.SelectionStart;
                    }
                }
                else
                {
                    consoleMessage("Поиск завершен.");
                    _findIndex = 0;
                    _findLast = 0;
                    _findText = _cbox.Text;
                }

            }
            catch (Exception ex)
            {
                consoleMessage("Во время поиска произошла ошибка! " + ex.Message);
            }
        }

        private void updateEditorRichTextBox(int selectLine = 0)
        {
            try
            {
                if (treeView1.Nodes[0].Nodes.Count > 0)
                {
                    JsonData.indexTextLine = 0;
                    editorRichTextBox.Text = JsonData.GetTextFromTreeView(treeView1.Nodes[0].Nodes[0], 0);
                    editorRichTextBox.BackColor = Color.White;
                }
                else
                {
                    editorRichTextBox.Clear();
                    editorRichTextBox.BackColor = Color.White;
                }

                if (editorRichTextBox.Lines.Length > 0 && editorRichTextBox.Lines.Length >= selectLine)
                {
                    if (selectLine < 0) return;
                    int start = editorRichTextBox.GetFirstCharIndexFromLine(selectLine);
                    int length = editorRichTextBox.Lines[selectLine].Length;
                    editorRichTextBox.Select(start, length);
                    editorRichTextBox.SelectionBackColor = Color.Yellow;
                    editorRichTextBox.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

        /*
		 * СОБЫТИЕ ==========================================================
		 */

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                DataForms.CountEditorForms--;
                if (DataForms.CountEditorForms == 0) DataForms.FMain.Close();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }


    }
}
