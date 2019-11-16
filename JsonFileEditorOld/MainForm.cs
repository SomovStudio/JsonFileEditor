/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 10.02.2019
 * Time: 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using JsonEditor.Editor;
using JsonEditor.Editor.data;

namespace JsonEditor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			createEditor();
		}
		
		void createEditor()
		{
			DataForms.FMain = this;
			DataForms.FMain.Visible = false;
			DataConfig.programClose = false;
			
			JEditor jeditor = new JEditor();
			jeditor.Show();
		}
	}
}
