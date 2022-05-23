using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace modul5_labpv2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string connectionSQL = "server=localhost;database=filepv;uid=root;password=;";
		Bitmap img;
			string pathimg;
			string SourceFilePath;
			string inputid;
			int intinputid;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			readData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnopenuploadClick(object sender, EventArgs e)
		{
			if(DialogResult.OK ==openFileDialog1.ShowDialog())
			{
				img = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image=img;
				pathimg=openFileDialog1.FileName.ToString();
			}	
		}
		
		void BtnsaveuploadClick(object sender, EventArgs e)
		{
			File2SqlBlob(pathimg);
			readData();
		}
		
		private void File2SqlBlob (string SourceFilePath) {
			try {
				MySqlConnection koneksi = new MySqlConnection(connectionSQL);
				MySqlCommand cmd = new MySqlCommand("INSERT into tablefile(Id,DataFile) values ("+incrementValueId()+",?Picture)", koneksi);
				System.IO.FileStream fs = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[] b = new Byte[fs.Length];
				fs.Read(b, 0, b.Length);
				fs.Close();
				MySqlParameter P= new MySqlParameter("?Picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0,0,null, DataRowVersion.Current, b);
				cmd.Parameters.Add(P);
				koneksi.Open();
				if (cmd.ExecuteNonQuery() ==1)
					MessageBox.Show("Gambar Berhasil disimpan ke database");
				
				koneksi.Close();
			}
			
			catch (MySqlException ex){
				MessageBox.Show(ex.Message);
			}
			
			readData();
		}
		
		void BtnopendownloadClick(object sender, EventArgs e)
		{
			try{
				MySqlConnection koneksi = new MySqlConnection(connectionSQL);
				koneksi.Open();
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(new MySqlCommand("SELECT DataFile FROM tablefile WHERE Id ="+Input_id.Text,koneksi));
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				
				if (dataSet.Tables[0].Rows.Count ==1){
					Byte[] data = new Byte[0];
					data = (Byte[])(dataSet.Tables[0].Rows[0]["DataFile"]);
					MemoryStream mem = new MemoryStream(data);
					pictureBox2.Image = Image.FromStream(mem);
				}
				koneksi.Close();
			}
			
			catch(Exception ex) {
				MessageBox.Show(ex.Message);
			}
			
		}
		
		void BtnsavedownloadClick(object sender, EventArgs e)
		{
			DialogResult dr = saveFileDialog1.ShowDialog();
			if (dr == DialogResult.OK)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "Images|.png;.bmp;*.jpg";
				ImageFormat format = ImageFormat.Png;
				if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					String ext = System.IO.Path.GetExtension(sfd.FileName);
					switch(ext){
						case ".jpg":
								format = ImageFormat.Jpeg;
								break;
						case ".bmp":
								format = ImageFormat.Bmp;
								break;		
					}
					pictureBox2.Image.Save(sfd.FileName, format);
				}
				}
			}
		

		
		private int incrementValueId(){
			int temp = 0;
			try{
				MySqlConnection db = new MySqlConnection(connectionSQL);
				db.Open();
				MySqlCommand dbcmd = db.CreateCommand();
				string sql = "select max(Id) from tablefile";
				dbcmd.CommandText = sql;
				MySqlDataReader reader = dbcmd.ExecuteReader();
				while (reader.Read()){
					if (!reader.IsDBNull(0)){
						return Convert.ToInt16(reader.GetString(0))+1;
						
					}
			}
				return 0;;
			}
			
			catch (MySqlException error){
				MessageBox.Show(error.ToString());
				return 0;
			}
			}
				
		
		public void readData(){
			MySqlConnection koneksi = new MySqlConnection(connectionSQL);
			koneksi.Open();
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("Select * from tablefile", koneksi);
			da.Fill(dt);
			dataGridView1.DataSource = dt.DefaultView;
			koneksi.Close();
		}
				
		}
	}

