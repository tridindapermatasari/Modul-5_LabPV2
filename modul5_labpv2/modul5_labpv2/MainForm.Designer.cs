/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 20/5/2022
 * Time: 5:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace modul5_labpv2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Input_id = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnopendownload = new System.Windows.Forms.Button();
			this.btnsavedownload = new System.Windows.Forms.Button();
			this.btnopenupload = new System.Windows.Forms.Button();
			this.btnsaveupload = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(378, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tes Download File";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(76, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tes Upload File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(76, 347);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(544, 34);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data Dari Database";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.LightGray;
			this.label4.Location = new System.Drawing.Point(378, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Input ID untuk di load";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Input_id
			// 
			this.Input_id.Location = new System.Drawing.Point(497, 253);
			this.Input_id.Name = "Input_id";
			this.Input_id.Size = new System.Drawing.Size(123, 20);
			this.Input_id.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pictureBox1.Location = new System.Drawing.Point(76, 53);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(243, 220);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.pictureBox2.Location = new System.Drawing.Point(378, 53);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(242, 204);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// btnopendownload
			// 
			this.btnopendownload.Location = new System.Drawing.Point(400, 290);
			this.btnopendownload.Name = "btnopendownload";
			this.btnopendownload.Size = new System.Drawing.Size(100, 23);
			this.btnopendownload.TabIndex = 7;
			this.btnopendownload.Text = "Open Download";
			this.btnopendownload.UseVisualStyleBackColor = true;
			this.btnopendownload.Click += new System.EventHandler(this.BtnopendownloadClick);
			// 
			// btnsavedownload
			// 
			this.btnsavedownload.Location = new System.Drawing.Point(506, 290);
			this.btnsavedownload.Name = "btnsavedownload";
			this.btnsavedownload.Size = new System.Drawing.Size(102, 23);
			this.btnsavedownload.TabIndex = 8;
			this.btnsavedownload.Text = "Save Download";
			this.btnsavedownload.UseVisualStyleBackColor = true;
			this.btnsavedownload.Click += new System.EventHandler(this.BtnsavedownloadClick);
			// 
			// btnopenupload
			// 
			this.btnopenupload.Location = new System.Drawing.Point(95, 290);
			this.btnopenupload.Name = "btnopenupload";
			this.btnopenupload.Size = new System.Drawing.Size(98, 23);
			this.btnopenupload.TabIndex = 9;
			this.btnopenupload.Text = "Open Upload";
			this.btnopenupload.UseVisualStyleBackColor = true;
			this.btnopenupload.Click += new System.EventHandler(this.BtnopenuploadClick);
			// 
			// btnsaveupload
			// 
			this.btnsaveupload.Location = new System.Drawing.Point(201, 290);
			this.btnsaveupload.Name = "btnsaveupload";
			this.btnsaveupload.Size = new System.Drawing.Size(102, 23);
			this.btnsaveupload.TabIndex = 10;
			this.btnsaveupload.Text = "Save Upload";
			this.btnsaveupload.UseVisualStyleBackColor = true;
			this.btnsaveupload.Click += new System.EventHandler(this.BtnsaveuploadClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(76, 384);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(544, 159);
			this.dataGridView1.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(680, 561);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnsaveupload);
			this.Controls.Add(this.btnopenupload);
			this.Controls.Add(this.btnsavedownload);
			this.Controls.Add(this.btnopendownload);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Input_id);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Modul 5";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnsaveupload;
		private System.Windows.Forms.Button btnopenupload;
		private System.Windows.Forms.Button btnsavedownload;
		private System.Windows.Forms.Button btnopendownload;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox Input_id;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
