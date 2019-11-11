using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JsonFileEditor.Editor;
using JsonFileEditor.Editor.data;

namespace JsonFileEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            createEditor();
        }

        private void createEditor()
        {
            DataForms.FMain = this;
            DataForms.FMain.Visible = false;
            DataConfig.ProgramClose = false;

            EditorForm editor = new EditorForm();
            editor.Show();
        }
    }
}
