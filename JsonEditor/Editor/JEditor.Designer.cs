/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 13.02.2019
 * Time: 13:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace JsonEditor.Editor
{
	partial class JEditor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новыйФайлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьФайлКакToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem навигацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem свернутьВсеУзлыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem развернутьВсеУзлыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьОбъектToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьМассивToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьKeyValueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openJsonFileDialog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox consoleRichTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SaveFileDialog saveJsonFileDialog;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton toolStripButton8;
		private System.Windows.Forms.ToolStripButton toolStripButton9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.RichTextBox editorRichTextBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьТолькоЗначениеToolStripMenuItem1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem добавитьОбъектToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem добавитьМассивToolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьКлючЗначениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьТолькоЗначениеToolStripMenuItem2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem очиститьКонсольОтСообщенийToolStripMenuItem;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem onlineJSONValidatorToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem шрифтПредставленияToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
		private System.Windows.Forms.ToolStripMenuItem копироватьВесьТекстJsonФайлаToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JEditor));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новыйФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьФайлКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.навигацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.свернутьВсеУзлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.развернутьВсеУзлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.добавитьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьМассивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьЗаписьKeyValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.шрифтПредставленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.onlineJSONValidatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openJsonFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
			this.добавитьОбъектToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьМассивToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.добавитьЗаписьКлючЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label3 = new System.Windows.Forms.Label();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.editorRichTextBox = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.копироватьВесьТекстJsonФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.consoleRichTextBox = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.очиститьКонсольОтСообщенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.saveJsonFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.panel3.SuspendLayout();
			this.contextMenuStrip3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton1,
			this.toolStripButton4,
			this.toolStripButton5,
			this.toolStripSeparator1,
			this.toolStripComboBox1,
			this.toolStripButton6,
			this.toolStripSeparator5,
			this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Новый файл";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "Открыть файл";
			this.toolStripButton4.Click += new System.EventHandler(this.ToolStripButton4Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "Сохранить файл";
			this.toolStripButton5.Click += new System.EventHandler(this.ToolStripButton5Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripComboBox1KeyPress);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton6.Text = "Поиск";
			this.toolStripButton6.Click += new System.EventHandler(this.ToolStripButton6Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "Шрифт представления";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripStatusLabel2,
			this.toolStripStatusLabel3,
			this.toolStripStatusLabel4});
			this.statusStrip1.Location = new System.Drawing.Point(0, 707);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
			this.toolStripStatusLabel1.Text = "2019 © Somov Evgeniy";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
			this.toolStripStatusLabel2.Text = " | ";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel3.Text = "Файл:";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
			this.toolStripStatusLabel4.Text = "...";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.файлToolStripMenuItem,
			this.навигацияToolStripMenuItem,
			this.настройкиToolStripMenuItem,
			this.сервисToolStripMenuItem,
			this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.новыйФайлToolStripMenuItem,
			this.открытьФайлToolStripMenuItem,
			this.сохранитьФайлToolStripMenuItem,
			this.сохранитьФайлКакToolStripMenuItem,
			this.toolStripSeparator2,
			this.закрытьToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// новыйФайлToolStripMenuItem
			// 
			this.новыйФайлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("новыйФайлToolStripMenuItem.Image")));
			this.новыйФайлToolStripMenuItem.Name = "новыйФайлToolStripMenuItem";
			this.новыйФайлToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.новыйФайлToolStripMenuItem.Text = "Новый файл";
			this.новыйФайлToolStripMenuItem.Click += new System.EventHandler(this.НовыйФайлToolStripMenuItemClick);
			// 
			// открытьФайлToolStripMenuItem
			// 
			this.открытьФайлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьФайлToolStripMenuItem.Image")));
			this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
			this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.открытьФайлToolStripMenuItem.Text = "Открыть файл";
			this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьФайлToolStripMenuItemClick);
			// 
			// сохранитьФайлToolStripMenuItem
			// 
			this.сохранитьФайлToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьФайлToolStripMenuItem.Image")));
			this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
			this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
			this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.СохранитьФайлToolStripMenuItemClick);
			// 
			// сохранитьФайлКакToolStripMenuItem
			// 
			this.сохранитьФайлКакToolStripMenuItem.Name = "сохранитьФайлКакToolStripMenuItem";
			this.сохранитьФайлКакToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.сохранитьФайлКакToolStripMenuItem.Text = "Сохранить файл как...";
			this.сохранитьФайлКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьФайлКакToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
			// 
			// закрытьToolStripMenuItem
			// 
			this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
			this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.закрытьToolStripMenuItem.Text = "Закрыть";
			this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьToolStripMenuItemClick);
			// 
			// навигацияToolStripMenuItem
			// 
			this.навигацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.свернутьВсеУзлыToolStripMenuItem,
			this.развернутьВсеУзлыToolStripMenuItem,
			this.toolStripSeparator3,
			this.добавитьОбъектToolStripMenuItem,
			this.добавитьМассивToolStripMenuItem,
			this.добавитьЗаписьKeyValueToolStripMenuItem,
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem1,
			this.удалитьToolStripMenuItem1});
			this.навигацияToolStripMenuItem.Name = "навигацияToolStripMenuItem";
			this.навигацияToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
			this.навигацияToolStripMenuItem.Text = "Инструменты";
			// 
			// свернутьВсеУзлыToolStripMenuItem
			// 
			this.свернутьВсеУзлыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("свернутьВсеУзлыToolStripMenuItem.Image")));
			this.свернутьВсеУзлыToolStripMenuItem.Name = "свернутьВсеУзлыToolStripMenuItem";
			this.свернутьВсеУзлыToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.свернутьВсеУзлыToolStripMenuItem.Text = "Свернуть все узлы";
			this.свернутьВсеУзлыToolStripMenuItem.Click += new System.EventHandler(this.СвернутьВсеУзлыToolStripMenuItemClick);
			// 
			// развернутьВсеУзлыToolStripMenuItem
			// 
			this.развернутьВсеУзлыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("развернутьВсеУзлыToolStripMenuItem.Image")));
			this.развернутьВсеУзлыToolStripMenuItem.Name = "развернутьВсеУзлыToolStripMenuItem";
			this.развернутьВсеУзлыToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.развернутьВсеУзлыToolStripMenuItem.Text = "Развернуть все узлы";
			this.развернутьВсеУзлыToolStripMenuItem.Click += new System.EventHandler(this.РазвернутьВсеУзлыToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(276, 6);
			// 
			// добавитьОбъектToolStripMenuItem
			// 
			this.добавитьОбъектToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьОбъектToolStripMenuItem.Image")));
			this.добавитьОбъектToolStripMenuItem.Name = "добавитьОбъектToolStripMenuItem";
			this.добавитьОбъектToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.добавитьОбъектToolStripMenuItem.Text = "Добавить объект { }";
			this.добавитьОбъектToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьОбъектToolStripMenuItemClick);
			// 
			// добавитьМассивToolStripMenuItem
			// 
			this.добавитьМассивToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("добавитьМассивToolStripMenuItem.Image")));
			this.добавитьМассивToolStripMenuItem.Name = "добавитьМассивToolStripMenuItem";
			this.добавитьМассивToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.добавитьМассивToolStripMenuItem.Text = "Добавить массив [ ]";
			this.добавитьМассивToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьМассивToolStripMenuItemClick);
			// 
			// добавитьЗаписьKeyValueToolStripMenuItem
			// 
			this.добавитьЗаписьKeyValueToolStripMenuItem.Name = "добавитьЗаписьKeyValueToolStripMenuItem";
			this.добавитьЗаписьKeyValueToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.добавитьЗаписьKeyValueToolStripMenuItem.Text = "Добавить запись \"Ключ\": \"Значение\"";
			this.добавитьЗаписьKeyValueToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьЗаписьKeyValueToolStripMenuItemClick);
			// 
			// добавитьЗаписьТолькоЗначениеToolStripMenuItem1
			// 
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem1.Name = "добавитьЗаписьТолькоЗначениеToolStripMenuItem1";
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem1.Text = "Добавить запись только \"Значение\"";
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem1.Click += new System.EventHandler(this.ДобавитьЗаписьТолькоЗначениеToolStripMenuItem1Click);
			// 
			// удалитьToolStripMenuItem1
			// 
			this.удалитьToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("удалитьToolStripMenuItem1.Image")));
			this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
			this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
			this.удалитьToolStripMenuItem1.Text = "Удалить";
			this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.УдалитьToolStripMenuItem1Click);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.шрифтПредставленияToolStripMenuItem});
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			// 
			// шрифтПредставленияToolStripMenuItem
			// 
			this.шрифтПредставленияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("шрифтПредставленияToolStripMenuItem.Image")));
			this.шрифтПредставленияToolStripMenuItem.Name = "шрифтПредставленияToolStripMenuItem";
			this.шрифтПредставленияToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.шрифтПредставленияToolStripMenuItem.Text = "Шрифт представления";
			this.шрифтПредставленияToolStripMenuItem.Click += new System.EventHandler(this.ШрифтПредставленияToolStripMenuItemClick);
			// 
			// сервисToolStripMenuItem
			// 
			this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.onlineJSONValidatorToolStripMenuItem});
			this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
			this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.сервисToolStripMenuItem.Text = "Сервис";
			// 
			// onlineJSONValidatorToolStripMenuItem
			// 
			this.onlineJSONValidatorToolStripMenuItem.Name = "onlineJSONValidatorToolStripMenuItem";
			this.onlineJSONValidatorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.onlineJSONValidatorToolStripMenuItem.Text = "Online JSON Validator";
			this.onlineJSONValidatorToolStripMenuItem.Click += new System.EventHandler(this.OnlineJSONValidatorToolStripMenuItemClick);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.оПрограммеToolStripMenuItem.Text = "О программе...";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItemClick);
			// 
			// openJsonFileDialog
			// 
			this.openJsonFileDialog.Filter = "*.json|*.json";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(1008, 658);
			this.splitContainer1.SplitterDistance = 540;
			this.splitContainer1.TabIndex = 7;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label4);
			this.splitContainer2.Panel1.Controls.Add(this.panel2);
			this.splitContainer2.Panel1.Controls.Add(this.label3);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
			this.splitContainer2.Size = new System.Drawing.Size(1008, 540);
			this.splitContainer2.SplitterDistance = 286;
			this.splitContainer2.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.SteelBlue;
			this.label4.Location = new System.Drawing.Point(4, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(279, 2);
			this.label4.TabIndex = 3;
			this.label4.Text = "  Консоль:";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.treeView1);
			this.panel2.Controls.Add(this.toolStrip2);
			this.panel2.Location = new System.Drawing.Point(4, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(279, 521);
			this.panel2.TabIndex = 2;
			// 
			// treeView1
			// 
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 25);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(277, 494);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripMenuItem1,
			this.toolStripMenuItem2,
			this.toolStripMenuItem3,
			this.toolStripMenuItem4,
			this.toolStripMenuItem5});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(280, 114);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(279, 22);
			this.toolStripMenuItem1.Text = "Добавить объект { }";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(279, 22);
			this.toolStripMenuItem2.Text = "Добавить массив [ ]";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(279, 22);
			this.toolStripMenuItem3.Text = "Добавить запись \"Ключ\": \"Значение\"";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(279, 22);
			this.toolStripMenuItem4.Text = "Добавить запись только \"Значение\"";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(279, 22);
			this.toolStripMenuItem5.Text = "Удалить";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5Click);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton8,
			this.toolStripButton9,
			this.toolStripSeparator8,
			this.toolStripDropDownButton4});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(277, 25);
			this.toolStrip2.TabIndex = 1;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripButton8
			// 
			this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
			this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton8.Text = "Свернуть все узлы";
			this.toolStripButton8.Click += new System.EventHandler(this.ToolStripButton8Click);
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton9.Text = "Развернуть все узлы";
			this.toolStripButton9.Click += new System.EventHandler(this.ToolStripButton9Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton4
			// 
			this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.добавитьОбъектToolStripMenuItem2,
			this.добавитьМассивToolStripMenuItem2,
			this.toolStripSeparator7,
			this.добавитьЗаписьКлючЗначениеToolStripMenuItem,
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem2,
			this.toolStripSeparator9,
			this.удалитьToolStripMenuItem});
			this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
			this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
			this.toolStripDropDownButton4.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton4.Text = "toolStripDropDownButton4";
			// 
			// добавитьОбъектToolStripMenuItem2
			// 
			this.добавитьОбъектToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("добавитьОбъектToolStripMenuItem2.Image")));
			this.добавитьОбъектToolStripMenuItem2.Name = "добавитьОбъектToolStripMenuItem2";
			this.добавитьОбъектToolStripMenuItem2.Size = new System.Drawing.Size(279, 22);
			this.добавитьОбъектToolStripMenuItem2.Text = "Добавить объект { }";
			this.добавитьОбъектToolStripMenuItem2.Click += new System.EventHandler(this.ДобавитьОбъектToolStripMenuItem2Click);
			// 
			// добавитьМассивToolStripMenuItem2
			// 
			this.добавитьМассивToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("добавитьМассивToolStripMenuItem2.Image")));
			this.добавитьМассивToolStripMenuItem2.Name = "добавитьМассивToolStripMenuItem2";
			this.добавитьМассивToolStripMenuItem2.Size = new System.Drawing.Size(279, 22);
			this.добавитьМассивToolStripMenuItem2.Text = "Добавить массив [ ]";
			this.добавитьМассивToolStripMenuItem2.Click += new System.EventHandler(this.ДобавитьМассивToolStripMenuItem2Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(276, 6);
			// 
			// добавитьЗаписьКлючЗначениеToolStripMenuItem
			// 
			this.добавитьЗаписьКлючЗначениеToolStripMenuItem.Name = "добавитьЗаписьКлючЗначениеToolStripMenuItem";
			this.добавитьЗаписьКлючЗначениеToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.добавитьЗаписьКлючЗначениеToolStripMenuItem.Text = "Добавить запись \"Ключ\": \"Значение\"";
			this.добавитьЗаписьКлючЗначениеToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьЗаписьКлючЗначениеToolStripMenuItemClick);
			// 
			// добавитьЗаписьТолькоЗначениеToolStripMenuItem2
			// 
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem2.Name = "добавитьЗаписьТолькоЗначениеToolStripMenuItem2";
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem2.Size = new System.Drawing.Size(279, 22);
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem2.Text = "Добавить запись только \"Значение\"";
			this.добавитьЗаписьТолькоЗначениеToolStripMenuItem2.Click += new System.EventHandler(this.ДобавитьЗаписьТолькоЗначениеToolStripMenuItem2Click);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(276, 6);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("удалитьToolStripMenuItem.Image")));
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItemClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.SteelBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Навигация:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.label6);
			this.splitContainer3.Panel1.Controls.Add(this.panel3);
			this.splitContainer3.Panel1.Controls.Add(this.label5);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.label8);
			this.splitContainer3.Panel2.Controls.Add(this.panel4);
			this.splitContainer3.Panel2.Controls.Add(this.label7);
			this.splitContainer3.Size = new System.Drawing.Size(718, 540);
			this.splitContainer3.SplitterDistance = 293;
			this.splitContainer3.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Location = new System.Drawing.Point(3, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(711, 2);
			this.label6.TabIndex = 4;
			this.label6.Text = "  Консоль:";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.editorRichTextBox);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Location = new System.Drawing.Point(3, 16);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(711, 274);
			this.panel3.TabIndex = 3;
			// 
			// editorRichTextBox
			// 
			this.editorRichTextBox.AcceptsTab = true;
			this.editorRichTextBox.BackColor = System.Drawing.Color.White;
			this.editorRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.editorRichTextBox.ContextMenuStrip = this.contextMenuStrip3;
			this.editorRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editorRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.editorRichTextBox.Name = "editorRichTextBox";
			this.editorRichTextBox.ReadOnly = true;
			this.editorRichTextBox.Size = new System.Drawing.Size(709, 252);
			this.editorRichTextBox.TabIndex = 0;
			this.editorRichTextBox.Text = "";
			this.editorRichTextBox.WordWrap = false;
			this.editorRichTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditorRichTextBoxMouseClick);
			this.editorRichTextBox.TextChanged += new System.EventHandler(this.EditorRichTextBoxTextChanged);
			// 
			// contextMenuStrip3
			// 
			this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.копироватьВесьТекстJsonФайлаToolStripMenuItem});
			this.contextMenuStrip3.Name = "contextMenuStrip3";
			this.contextMenuStrip3.Size = new System.Drawing.Size(198, 48);
			// 
			// копироватьВесьТекстJsonФайлаToolStripMenuItem
			// 
			this.копироватьВесьТекстJsonФайлаToolStripMenuItem.Name = "копироватьВесьТекстJsonФайлаToolStripMenuItem";
			this.копироватьВесьТекстJsonФайлаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.копироватьВесьТекстJsonФайлаToolStripMenuItem.Text = "Копировать весь текст";
			this.копироватьВесьТекстJsonФайлаToolStripMenuItem.Click += new System.EventHandler(this.КопироватьВесьТекстJsonФайлаToolStripMenuItemClick);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.ForeColor = System.Drawing.Color.SlateBlue;
			this.label9.Location = new System.Drawing.Point(0, 252);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(709, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Строка: 0";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.SteelBlue;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 15);
			this.label5.TabIndex = 2;
			this.label5.Text = "Представление:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BackColor = System.Drawing.Color.SteelBlue;
			this.label8.Location = new System.Drawing.Point(3, 15);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(711, 2);
			this.label8.TabIndex = 5;
			this.label8.Text = "  Консоль:";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Location = new System.Drawing.Point(3, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(711, 223);
			this.panel4.TabIndex = 4;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(709, 221);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellEndEdit);
			this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridView1UserAddedRow);
			this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridView1UserDeletedRow);
			this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridView1UserDeletingRow);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.SteelBlue;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(3, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 15);
			this.label7.TabIndex = 3;
			this.label7.Text = "Редактор:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.MediumPurple;
			this.label2.Location = new System.Drawing.Point(3, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1002, 2);
			this.label2.TabIndex = 1;
			this.label2.Text = "  Консоль:";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.consoleRichTextBox);
			this.panel1.Location = new System.Drawing.Point(3, 15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1002, 96);
			this.panel1.TabIndex = 2;
			// 
			// consoleRichTextBox
			// 
			this.consoleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.consoleRichTextBox.ContextMenuStrip = this.contextMenuStrip2;
			this.consoleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.consoleRichTextBox.Name = "consoleRichTextBox";
			this.consoleRichTextBox.ReadOnly = true;
			this.consoleRichTextBox.Size = new System.Drawing.Size(1000, 94);
			this.consoleRichTextBox.TabIndex = 0;
			this.consoleRichTextBox.Text = "";
			this.consoleRichTextBox.WordWrap = false;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.очиститьКонсольОтСообщенийToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(176, 26);
			// 
			// очиститьКонсольОтСообщенийToolStripMenuItem
			// 
			this.очиститьКонсольОтСообщенийToolStripMenuItem.Name = "очиститьКонсольОтСообщенийToolStripMenuItem";
			this.очиститьКонсольОтСообщенийToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.очиститьКонсольОтСообщенийToolStripMenuItem.Text = "Очистить консоль";
			this.очиститьКонсольОтСообщенийToolStripMenuItem.Click += new System.EventHandler(this.ОчиститьКонсольОтСообщенийToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MediumPurple;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "    Консоль:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// saveJsonFileDialog
			// 
			this.saveJsonFileDialog.Filter = "*.json|*.json";
			// 
			// JEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "JEditor";
			this.Text = "Json File Editor v 1.0";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JEditorFormClosed);
			this.Load += new System.EventHandler(this.JEditorLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.contextMenuStrip3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
