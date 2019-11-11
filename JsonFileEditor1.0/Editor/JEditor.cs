/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 13.02.2019
 * Time: 13:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using JsonEditor.Editor.data;
using JsonEditor.Editor.json;
using JsonFileEditor.Editor;

namespace JsonEditor.Editor
{
	/// <summary>
	/// Description of Editor.
	/// </summary>
	public partial class JEditor : Form
	{
		public JEditor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		string _safeFileName = "empty.json";
		string _pathFileName = "";
		
		void consoleMessage(String message) // вывести информацию в консоль
		{
			try{
				consoleRichTextBox.Text = consoleRichTextBox.Text + message + Environment.NewLine;
				consoleRichTextBox.Select(consoleRichTextBox.Text.Length, consoleRichTextBox.Text.Length);
	      		consoleRichTextBox.ScrollToCaret();
      		}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void consoleClear() // очистить консоль
		{
			try {
				consoleRichTextBox.Clear();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void createNewFile() // создать новый файл
		{
			try{
				JEditor editor = new JEditor();
				editor.Show();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void openFile() // открыть файл
		{
			if(openJsonFileDialog.ShowDialog() == DialogResult.OK)
			{
					try{
					treeView1.Nodes.Clear();
					createTable();
					
					_safeFileName = openJsonFileDialog.SafeFileName;
					_pathFileName = openJsonFileDialog.FileName;
					toolStripStatusLabel4.Text = _pathFileName;
					
					StreamReader sr = new StreamReader(_pathFileName, Encoding.UTF8);
	    			string jsonText = sr.ReadToEnd();
	    			sr.Close();
	
	    			treeView1.Nodes.Add(JsonData.SetDataInTreeView(jsonText, _safeFileName));
	    			
	    			if(treeView1.Nodes[0].Nodes.Count > 0)
	    			{
	    				updateEditorRichTextBox();
	    			}
    			}catch(Exception ex){
					consoleMessage("Ошибка: " + ex.Message);
				}
			}
		}
		
		void savefile() // сохранить файл
		{
			try{
				if(File.Exists(_pathFileName)){
					
					if(treeView1.Nodes.Count <= 0) 
					{
						consoleMessage("Нет данных для сохранения файла");
						return;
					}
	    			
					if(treeView1.Nodes[0].Nodes.Count > 0) 
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
				}else{
					saveFileAs();
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void saveFileAs() // сохранить файл как
		{
			try{
				if(treeView1.Nodes.Count <= 0)
				{
					consoleMessage("Нет данных для сохранения файла");
					return;
				}
				
				saveJsonFileDialog.FileName = _safeFileName;
				if(saveJsonFileDialog.ShowDialog() == DialogResult.OK)
				{
					FileInfo fi = new FileInfo(saveJsonFileDialog.FileName);
	    			_safeFileName = fi.Name;
	    			_pathFileName = saveJsonFileDialog.FileName;
					toolStripStatusLabel4.Text = _pathFileName;
					
					if(treeView1.Nodes[0].Nodes.Count > 0)  
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
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		DataSet _ds;
		DataTable _dt;
		void createTable() // инициализация таблицы
		{
			try{
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
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void clearTable() // очистить таблицу
		{
			try{
				_ds.Tables[0].Clear();
				dataGridView1.Update();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		TreeNode _selectedNode;
		void setNodeInDataGridView() // заполнить таблицу данными из узла
		{
			try{
				if(_selectedNode == null) _selectedNode = getSelectNode();
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}
				
				_ds.Tables[0].Rows.Clear();
				DataRow row;
				
				if(_selectedNode.Text == _safeFileName) return;
				
				string key = "";
				string value = "";
				string token = "";
				
				if(_selectedNode.Nodes.Count > 0) // Обработка узла
				{
					
					foreach(TreeNode n in _selectedNode.Nodes)
					{
						if(n.Text.Contains("\":"))
						{
							foreach(char c in n.Text)
							{
								if(c == ':' && key == "")
								{
									key = token;
									token = "";
								}
								else if(c == ':' && key != "")
								{
									token += c;
								}
								if(c != ':') token += c;
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
						if(value[value.Length-1] == ',') value = value.Remove(value.Length-1, 1);
						
						row = _dt.NewRow();
						row["Key"] = key;
						row["Value"] = value;
						_ds.Tables[0].Rows.Add(row);
						
						key = "";
						value = "";
						token = "";
					}
				}
				else if(_selectedNode.Text.Contains("[ ]") == false && _selectedNode.Text.Contains("{ }") == false) // Обработка строки
				{
					if(_selectedNode.Text.Contains("\":"))
					{
						foreach(char c in _selectedNode.Text)
						{
							if(c == ':' && key == "")
							{
								key = token;
								token = "";
							}
							else if(c == ':' && key != "")
							{
								token += c;
							}
							if(c != ':') token += c;
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
					if(value[value.Length-1] == ',') value = value.Remove(value.Length-1, 1);
					
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
					if(viewRow.Cells["Value"].Value != null){
						if(viewRow.Cells["Value"].Value.ToString() == "{ }") viewRow.Cells["Value"].ReadOnly = true;
						if(viewRow.Cells["Value"].Value.ToString() == "[ ]") viewRow.Cells["Value"].ReadOnly = true;
					}
				}
				
				if(_selectedNode.Text.Contains("{ }") || _selectedNode.Text.Contains("[ ]")) dataGridView1.AllowUserToAddRows = true;
				else dataGridView1.AllowUserToAddRows = false; // запрещаем добавление строк
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		TreeNode getSelectNode() // получить выбранный узел
		{
			try{
				if(treeView1.SelectedNode.Text != _safeFileName) return treeView1.SelectedNode;
				else {
					if(treeView1.SelectedNode.Nodes.Count > 0) return null;
					else return treeView1.SelectedNode;
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
				return null;
			}
		}
		
		public TreeNode getNodeByLineNumber(object tag, TreeNode rootNode) // получить узел по номеру строки
        {
			try{
				foreach (TreeNode node in rootNode.Nodes)
	            {
	                if (node.Tag.Equals(tag)) return node;
	                var next = getNodeByLineNumber(tag, node);
	                if (next != null) return next;
	            }
	            return null;
            }catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
				return null;
			}
        }
				
		void addObjectInTree() // добавить объект в дерево
		{
			try{
				if(_selectedNode == null) _selectedNode = getSelectNode();
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}
				
				if(_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
				{
					consoleMessage("Невозможно добавить объект в значение. Объект можно добавить только в другой объект или в массив.");
					return;
				}
				
				int count = _selectedNode.Nodes.Count;
				if(count > 0)
				{
					string text = _selectedNode.Nodes[count-1].Text;
					int lenght = text.Length;
					if(text[lenght-1] != ',' && text[lenght-1] != ']' && text[lenght-1] != '}')
					{
						text += ",";
						_selectedNode.Nodes[count-1].Text = text;
					}
				}
				_selectedNode.Nodes.Add("{ }");
				setNodeInDataGridView();
				
				updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void addArrayInTree() // добавить массив в дерево
		{
			try{
				if(_selectedNode == null) _selectedNode = getSelectNode();
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}
				
				if(_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
				{
					consoleMessage("Невозможно добавить массив в значение. Массив можно добавить только в объект или в другой массив.");
					return;
				}
				
				int count = _selectedNode.Nodes.Count;
				if(count > 0)
				{
					string text = _selectedNode.Nodes[count-1].Text;
					int lenght = text.Length;
					if(text[lenght-1] != ',' && text[lenght-1] != ']' && text[lenght-1] != '}')
					{
						text += ",";
						_selectedNode.Nodes[count-1].Text = text;
					}
				}
				_selectedNode.Nodes.Add("[ ]");
				setNodeInDataGridView();
				
				updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void addKeyValueInTree() // добавить ключь/значение в дерево
		{
			try{
				if(_selectedNode == null) _selectedNode = getSelectNode();
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}
				
				if(_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
				{
					consoleMessage("Невозможно добавить значение в другое значение. Значение можно добавить только в объект или в массив.");
					return;
				}
				
				int count = _selectedNode.Nodes.Count;
				if(count > 0)
				{
					string text = _selectedNode.Nodes[count-1].Text;
					int lenght = text.Length;
					if(text[lenght-1] != ',' && text[lenght-1] != ']' && text[lenght-1] != '}')
					{
						text += ",";
						_selectedNode.Nodes[count-1].Text = text;
					}
				}
				_selectedNode.Nodes.Add("\"Key\": 0");
				setNodeInDataGridView();
				
				updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void addValueInTree() // добавить значение в дерево
		{
			try{
				if(_selectedNode == null) _selectedNode = getSelectNode();
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}
				
				if(_selectedNode.Text.Contains("[ ]") != true && _selectedNode.Text.Contains("{ }") != true && _selectedNode.Text != _safeFileName)
				{
					consoleMessage("Невозможно добавить значение в другое значение. Значение можно добавить только в объект или в массив.");
					return;
				}
				
				int count = _selectedNode.Nodes.Count;
				if(count > 0)
				{
					string text = _selectedNode.Nodes[count-1].Text;
					int lenght = text.Length;
					if(text[lenght-1] != ',' && text[lenght-1] != ']' && text[lenght-1] != '}')
					{
						text += ",";
						_selectedNode.Nodes[count-1].Text = text;
					}
				}
				_selectedNode.Nodes.Add("0");
				setNodeInDataGridView();
				
				updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		void deleteNodeInTree() // удалить узел дерева
		{
			try{
				if(_selectedNode == null) _selectedNode = getSelectNode();
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}
							
				if(_selectedNode.Text == _safeFileName)
				{
					consoleMessage("Невозможно удалить коренной узел который является основой файла " + _safeFileName);
					return;
				}
				
				if(MessageBox.Show("Удалить запись '" + _selectedNode.Text + "' безвозвратно?" , "Вопрос", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return; // отмена удаления
				}
				
				TreeNode parent = _selectedNode.Parent;
				_selectedNode.Remove();
				_selectedNode = null;
				dataGridView1.AllowUserToAddRows = false;
				
				int count = parent.Nodes.Count;
				if(count > 0)
				{
					string text = parent.Nodes[count-1].Text;
					int lenght = text.Length;
					if(text[lenght-1] == ',')
					{
						text = text.Remove(lenght-1, 1);
						parent.Nodes[count-1].Text = text;
					}
				}
				
				clearTable();
				treeView1.Focus();
				setNodeInDataGridView();
				
				updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		int getStringNumber() // получить номер выбранной строки
		{
			try{
				int selectLine = editorRichTextBox.GetLineFromCharIndex(editorRichTextBox.SelectionStart) + 1;
				label9.Text = "Строка: " + selectLine.ToString();
				return selectLine;
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
				return 0;
			}
		}
		
		/* Поиск по тексту */
		int _findIndex = 0;
		int _findLast = 0;
		String _findText = "";
		void findText(ToolStripComboBox _cbox)
		{
			try{
				bool resolution = true;
				for(int k = 0; k < _cbox.Items.Count; k++)
					if(_cbox.Items[k].ToString() == _cbox.Text) resolution = false;
				if(resolution) _cbox.Items.Add(_cbox.Text);
				if(_findText != _cbox.Text){
					_findIndex = 0;
					_findLast = 0;
					_findText = _cbox.Text;
				}
				if(editorRichTextBox.Find(_cbox.Text, _findIndex, editorRichTextBox.TextLength - 1, RichTextBoxFinds.None) >= 0){
					editorRichTextBox.Select();
					_findIndex = editorRichTextBox.SelectionStart + editorRichTextBox.SelectionLength;
					if(_findLast == editorRichTextBox.SelectionStart){
						consoleMessage("Поиск завершен.");
						_findIndex = 0;
						_findLast = 0;
						_findText = _cbox.Text;
					}else{
						_findLast = editorRichTextBox.SelectionStart;
					}
				}else{
					consoleMessage("Поиск завершен.");
					_findIndex = 0;
					_findLast = 0;
					_findText = _cbox.Text;
				}
					
			}catch(Exception ex) {
				consoleMessage("Во время поиска произошла ошибка! " + ex.Message);
			}
		}
		
		void updateEditorRichTextBox(int selectLine = 0)
		{
			try{
				if(treeView1.Nodes[0].Nodes.Count > 0)
				{
					JsonData.indexTextLine = 0;
					editorRichTextBox.Text = JsonData.GetTextFromTreeView(treeView1.Nodes[0].Nodes[0], 0);
					editorRichTextBox.BackColor = Color.White;
				}else{
					editorRichTextBox.Clear();
					editorRichTextBox.BackColor = Color.White;
				}
				
				if(editorRichTextBox.Lines.Length > 0 && editorRichTextBox.Lines.Length >= selectLine)
				{
					if(selectLine < 0) return;
		  			int start = editorRichTextBox.GetFirstCharIndexFromLine(selectLine);
		  			int length = editorRichTextBox.Lines[selectLine].Length;
		  			editorRichTextBox.Select(start, length);
		  			editorRichTextBox.SelectionBackColor = Color.Yellow;
		  			editorRichTextBox.ScrollToCaret();
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
		/*
		 * СОБЫТИЕ ==========================================================
		 */
		
		void JEditorLoad(object sender, EventArgs e)
		{
			try{
				DataForms.CountEditorForms++;
				_pathFileName = _safeFileName;
				toolStripStatusLabel4.Text = _pathFileName;
				treeView1.Nodes.Add(_safeFileName);
				createTable();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void JEditorFormClosed(object sender, FormClosedEventArgs e)
		{
			try{
				DataForms.CountEditorForms--;
				if(DataForms.CountEditorForms == 0) DataForms.FMain.Close();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ЗакрытьToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		void ОткрытьФайлToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFile();
		}
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			openFile();
		}
		void ToolStripButton8Click(object sender, EventArgs e)
		{
			try{
				treeView1.CollapseAll();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ToolStripButton9Click(object sender, EventArgs e)
		{
			try{
				treeView1.BeginUpdate();
				treeView1.ExpandAll();
				treeView1.EndUpdate();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void НовыйФайлToolStripMenuItemClick(object sender, EventArgs e)
		{
			createNewFile();
		}
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			createNewFile();
		}
		void СохранитьФайлToolStripMenuItemClick(object sender, EventArgs e)
		{
			savefile();
		}
		void ToolStripButton5Click(object sender, EventArgs e)
		{
			savefile();
		}
		void СохранитьФайлКакToolStripMenuItemClick(object sender, EventArgs e)
		{
			saveFileAs();
		}
		void СвернутьВсеУзлыToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				treeView1.CollapseAll();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void РазвернутьВсеУзлыToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				treeView1.BeginUpdate();
				treeView1.ExpandAll();
				treeView1.EndUpdate();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ДобавитьОбъектToolStripMenuItemClick(object sender, EventArgs e)
		{
			addObjectInTree();
		}
		void ДобавитьМассивToolStripMenuItemClick(object sender, EventArgs e)
		{
			addArrayInTree();
		}
		void ДобавитьЗаписьKeyValueToolStripMenuItemClick(object sender, EventArgs e)
		{
			addKeyValueInTree();
		}
		void ДобавитьЗаписьТолькоЗначениеToolStripMenuItem1Click(object sender, EventArgs e)
		{
			addValueInTree();
		}
		void УдалитьToolStripMenuItem1Click(object sender, EventArgs e)
		{
			deleteNodeInTree();
		}
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			try{
				editorRichTextBox.Select(0, editorRichTextBox.Text.Length);
				editorRichTextBox.SelectionBackColor = Color.White;
				
				_selectedNode = e.Node;
				
				if(_selectedNode != null && e.Node.Text != _safeFileName)
				{
					setNodeInDataGridView();
					
					if(editorRichTextBox.Lines.Length > 0)
					{
						int line = Convert.ToInt32(_selectedNode.Tag);
			  			if(line < 0) return;
			  			int start = editorRichTextBox.GetFirstCharIndexFromLine(line);
			  			int length = editorRichTextBox.Lines[line].Length;
			  			editorRichTextBox.Select(start, length);
			  			editorRichTextBox.SelectionBackColor = Color.Yellow;
			  			editorRichTextBox.ScrollToCaret();
					}
				}else if(e.Node.Text == _safeFileName)
				{
					clearTable();
					dataGridView1.AllowUserToAddRows = false; // запрещаем добавление строк
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void DataGridView1CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try{
				// узел не выбран
				if(_selectedNode == null) 
				{
					consoleMessage("В дереве объектов нет выбранного узла");
					return;
				}	
	
				string k = "";
				string v = "";
				
				// добавление новых данных -----------------
				if(e.RowIndex > _ds.Tables[0].Rows.Count-1)	
				{
					k = dataGridView1.Rows[e.RowIndex].Cells["Key"].Value.ToString();
					v = dataGridView1.Rows[e.RowIndex].Cells["Value"].Value.ToString();
				
					k = k.Trim();
					v = v.Trim();
					if(k.Length > 0)
					{
						if(k[0] != '"' && k[k.Length-1] != '"') k = "\""+k+"\"";
						else if(k[0] != '"') k = "\""+k;
						else if(k[k.Length-1] != '"') k = k+"\"";
					}	
					if(v.Length > 0)
					{
						if(v[0] == '[' && v[v.Length-1] == ']') v = "[ ]";
						else if(v[0] == '{' && v[v.Length-1] == '}') v = "{ }";
						else if(v[0] == '[') v = "[ ]";
						else if(v[0] == '{') v = "{ }";
						else if(v[0] == ']') v = "[ ]";
						else if(v[0] == '}') v = "{ }";
					}
					
					List<string> validationResultNewStr = JsonData.ValidateJson(k, v);
					if(validationResultNewStr.Count > 0)
					{
						foreach(string error in validationResultNewStr) consoleMessage(error);
					}
					
					int countNodes = _selectedNode.Nodes.Count;
					if(_selectedNode.Nodes.Count > 0) {
						int checkIndexChar = _selectedNode.Nodes[countNodes-1].Text.Length - 1;
						string text = _selectedNode.Nodes[countNodes-1].Text;
						if(text[checkIndexChar] != ',' && 
						   text[checkIndexChar] != ']' && 
						   text[checkIndexChar] != '}')
						{
							_selectedNode.Nodes[countNodes-1].Text += ",";
						}
					}
					if(k != "" && v != "")	_selectedNode.Nodes.Add(k + ": " + v);
					else if(k != "" && v == "") {
						_selectedNode.Nodes.Add(k + ": 0");
						consoleMessage("Ключу " + k + " по умолчанию было присвоено значение 0");
					}
					else if(k == "" && v != "") _selectedNode.Nodes.Add(v);
					
					setNodeInDataGridView();
					
					updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
					this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
					return;
				}
	
				// редактирование данных -------------------
				int index = e.RowIndex;
				DataRow row = _ds.Tables[0].Rows[index];
				int count = _ds.Tables[0].Rows.Count;
				string value = "";
				
				k = row[0].ToString();
				v = row[1].ToString();			
				k = k.Trim();
				v = v.Trim();
				if(k.Length > 0)
				{
					if(k[0] != '"' && k[k.Length-1] != '"') k = "\""+k+"\"";
					else if(k[0] != '"') k = "\""+k;
					else if(k[k.Length-1] != '"') k = k+"\"";
				}
				if(v.Length > 0)
				{
					if(v[0] == '[' && v[v.Length-1] == ']') v = "[ ]";
					else if(v[0] == '{' && v[v.Length-1] == '}') v = "{ }";
					else if(v[0] == '[') v = "[ ]";
					else if(v[0] == '{') v = "{ }";
					else if(v[0] == ']') v = "[ ]";
					else if(v[0] == '}') v = "{ }";
				}
				
				List<string> validationResult = JsonData.ValidateJson(k, v);
				if(validationResult.Count > 0)
				{
					foreach(string error in validationResult)
					{
						consoleMessage(error);
					}
					return;
				}
				
				if(_selectedNode.Text.Contains("{ }") || _selectedNode.Text.Contains("[ ]"))
				{			
					if(k != "" && v != "" && index != (count-1)) value = k + ": " + v + ",";
					else if(k != "" && v != "" && index == (count-1)) value = k + ": " + v;
					else if(k == "" && v != "" && index != (count-1)) value = v + ",";
					else if(k == "" && v != "" && index == (count-1)) value = v;
					else if(k != "" && v == "" && index != (count-1)) 
					{
						value = k + ": 0,";
						consoleMessage("Ключу " + k + " по умолчанию было присвоено значение 0");
					}
					else if(k != "" && v == "" && index == (count-1)) 
					{
						value = k + ": 0";
						consoleMessage("Ключу " + k + " по умолчанию было присвоено значение 0");
					}
				
					_selectedNode.Nodes[index].Text = value;
				}
				else
				{
					bool lastLine;
					if(_selectedNode.Text[_selectedNode.Text.Length-1] == ',') lastLine = false;
					else lastLine = true;
					
					if(k != "" && v != "" && lastLine == false) value = k + ": " + v + ",";
					else if(k != "" && v != "" && lastLine == true) value = k + ": " + v;
					else if(k == "" && v != "" && lastLine == false) value = v + ",";
					else if(k == "" && v != "" && lastLine == true) value = v;
					else if(k != "" && v == "" && lastLine == false) 
					{
						value = k + ": 0,";
						consoleMessage("Ключу " + k + " по умолчанию было присвоено значение 0");
					}
					else if(k != "" && v == "" && lastLine == true) 
					{
						value = k + ": 0";
						consoleMessage("Ключу " + k + " по умолчанию было присвоено значение 0");
					}
				
					_selectedNode.Text = value;
				}
				
				setNodeInDataGridView();
				updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void DataGridView1UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{
			// добавление новой строки
		}
		void DataGridView1UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			// после удаления
			try{
				if(_selectedNode == null)
				{
					_ds.Tables[0].Clear();
				}
				this.Text = "Json File Editor v 1.0 [ изменения не сохранены ]";
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void DataGridView1UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			try{
				// во время удаления
				if(_selectedNode == null) {
					e.Cancel = true;
					return; // узел не выбран
				}
				
				int index = e.Row.Index;
				
				if(MessageBox.Show("Удалить запись ?" , "Вопрос", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					e.Cancel = true;
					return; // отмена удаления
				}
				
				if(_selectedNode.Text.Contains("{ }") || _selectedNode.Text.Contains("[ ]"))
				{
					_selectedNode.Nodes[index].Remove();
					int count = _selectedNode.Nodes.Count;
					if(count > 0)
					{
						string text = _selectedNode.Nodes[count-1].Text;
						int lenght = text.Length;
						if(text[lenght-1] == ',')
						{
							text = text.Remove(lenght-1, 1);
							_selectedNode.Nodes[count-1].Text = text;
						}
					}
					updateEditorRichTextBox(Convert.ToInt32(_selectedNode.Tag));
				}
				else
				{
					TreeNode parent = _selectedNode.Parent;				
					_selectedNode.Remove();
					_selectedNode = null;
					dataGridView1.AllowUserToAddRows = false;
					
					if(parent != null)
					{
						int count = parent.Nodes.Count;
						if(count > 0)
						{
							string text = parent.Nodes[count-1].Text;
							int lenght = text.Length;
							if(text[lenght-1] == ',')
							{
								text = text.Remove(lenght-1, 1);
								parent.Nodes[count-1].Text = text;
							}
						}
						updateEditorRichTextBox(Convert.ToInt32(parent.Tag));
					}
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ДобавитьОбъектToolStripMenuItem2Click(object sender, EventArgs e)
		{
			addObjectInTree();
		}		
		void ДобавитьМассивToolStripMenuItem2Click(object sender, EventArgs e)
		{
			addArrayInTree();
		}
		void ДобавитьЗаписьКлючЗначениеToolStripMenuItemClick(object sender, EventArgs e)
		{
			addKeyValueInTree();
		}
		void ДобавитьЗаписьТолькоЗначениеToolStripMenuItem2Click(object sender, EventArgs e)
		{
			addValueInTree();
		}
		void УдалитьToolStripMenuItemClick(object sender, EventArgs e)
		{
			deleteNodeInTree();
		}
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			addObjectInTree();
		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			addArrayInTree();
		}
		void ToolStripMenuItem3Click(object sender, EventArgs e)
		{
			addKeyValueInTree();
		}
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
			addValueInTree();
		}
		void ToolStripMenuItem5Click(object sender, EventArgs e)
		{
			deleteNodeInTree();
		}
		void ОчиститьКонсольОтСообщенийToolStripMenuItemClick(object sender, EventArgs e)
		{
			consoleClear();
		}
		void EditorRichTextBoxTextChanged(object sender, EventArgs e)
		{
			getStringNumber();
		}
		void EditorRichTextBoxMouseClick(object sender, MouseEventArgs e)
		{
			try{
				int line = getStringNumber();
				TreeNode node = getNodeByLineNumber(line-1, treeView1.Nodes[0]);
				if(node != null){
					node.EnsureVisible();
					node.ExpandAll();
					//node.Checked = true;
					treeView1.SelectedNode = node;
					treeView1.Focus();
				}
				else
				{
					//consoleMessage("Строка " + line + ": нет соответствующего узла в окне навигации");
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void OnlineJSONValidatorToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(@"https://jsonformatter.curiousconcept.com/");
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ToolStripComboBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			try{
				if(e.KeyChar.GetHashCode().ToString() == "851981"){
					findText(toolStripComboBox1);
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ToolStripButton6Click(object sender, EventArgs e)
		{
			findText(toolStripComboBox1);
		}
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				About about = new About();
				about.ShowDialog();
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			try{
				fontDialog1.Font = editorRichTextBox.Font;
				if(fontDialog1.ShowDialog() == DialogResult.OK) editorRichTextBox.Font = fontDialog1.Font;
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void ШрифтПредставленияToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				fontDialog1.Font = editorRichTextBox.Font;
				if(fontDialog1.ShowDialog() == DialogResult.OK) editorRichTextBox.Font = fontDialog1.Font;
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		void КопироватьВесьТекстJsonФайлаToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				if(!string.IsNullOrEmpty(editorRichTextBox.Text))
				{
					Clipboard.SetText(editorRichTextBox.Text);
				}
			}catch(Exception ex){
				consoleMessage("Ошибка: " + ex.Message);
			}
		}
		
	}
}
