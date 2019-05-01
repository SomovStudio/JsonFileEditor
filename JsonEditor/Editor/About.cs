/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 22.02.2019
 * Time: 15:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JsonFileEditor.Editor
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public partial class About : Form
	{
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LinkLabel4LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(@"https://www.gnu.org/licenses/gpl-3.0.en.html");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(@"mailto:somov.studio@gmail.com");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(@"https://somov-qa.github.io");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(@"https://github.com/Somov-QA/JsonFileEditor");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
	}
}
