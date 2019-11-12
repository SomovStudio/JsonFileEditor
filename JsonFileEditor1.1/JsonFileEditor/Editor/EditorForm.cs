using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JsonFileEditor.Editor.data;

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
                //createTable();
            }
            catch (Exception ex)
            {
                consoleMessage("Ошибка: " + ex.Message);
            }
        }

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
