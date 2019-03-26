namespace Adt.Gui
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl = new System.Windows.Forms.TabControl();
			this.connectionlessPage = new System.Windows.Forms.TabPage();
			this.disconnectedGridView = new System.Windows.Forms.DataGridView();
			this.connectedPage = new System.Windows.Forms.TabPage();
			this.connectedGridView = new System.Windows.Forms.DataGridView();
			this.loadButton = new System.Windows.Forms.Button();
			this.countTxtBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.tabControl.SuspendLayout();
			this.connectionlessPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.disconnectedGridView)).BeginInit();
			this.connectedPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.connectedGridView)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.connectionlessPage);
			this.tabControl.Controls.Add(this.connectedPage);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(776, 390);
			this.tabControl.TabIndex = 0;
			// 
			// connectionlessPage
			// 
			this.connectionlessPage.Controls.Add(this.disconnectedGridView);
			this.connectionlessPage.Location = new System.Drawing.Point(4, 22);
			this.connectionlessPage.Name = "connectionlessPage";
			this.connectionlessPage.Padding = new System.Windows.Forms.Padding(3);
			this.connectionlessPage.Size = new System.Drawing.Size(768, 364);
			this.connectionlessPage.TabIndex = 0;
			this.connectionlessPage.Text = "Disconnected";
			this.connectionlessPage.UseVisualStyleBackColor = true;
			// 
			// disconnectedGridView
			// 
			this.disconnectedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.disconnectedGridView.Location = new System.Drawing.Point(9, 6);
			this.disconnectedGridView.Name = "disconnectedGridView";
			this.disconnectedGridView.Size = new System.Drawing.Size(753, 352);
			this.disconnectedGridView.TabIndex = 0;
			// 
			// connectedPage
			// 
			this.connectedPage.Controls.Add(this.connectedGridView);
			this.connectedPage.Location = new System.Drawing.Point(4, 22);
			this.connectedPage.Name = "connectedPage";
			this.connectedPage.Padding = new System.Windows.Forms.Padding(3);
			this.connectedPage.Size = new System.Drawing.Size(768, 364);
			this.connectedPage.TabIndex = 1;
			this.connectedPage.Text = "Connected";
			this.connectedPage.UseVisualStyleBackColor = true;
			// 
			// connectedGridView
			// 
			this.connectedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.connectedGridView.Location = new System.Drawing.Point(6, 6);
			this.connectedGridView.Name = "connectedGridView";
			this.connectedGridView.Size = new System.Drawing.Size(756, 352);
			this.connectedGridView.TabIndex = 0;
			// 
			// loadButton
			// 
			this.loadButton.Location = new System.Drawing.Point(209, 416);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(97, 23);
			this.loadButton.TabIndex = 1;
			this.loadButton.Text = "Load";
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.LoadButtton_Click);
			// 
			// countTxtBox
			// 
			this.countTxtBox.Location = new System.Drawing.Point(103, 418);
			this.countTxtBox.Name = "countTxtBox";
			this.countTxtBox.Size = new System.Drawing.Size(100, 20);
			this.countTxtBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 421);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Number of rows";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(768, 364);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Generated";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(7, 7);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(755, 351);
			this.dataGridView1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.countTxtBox);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.connectionlessPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.disconnectedGridView)).EndInit();
			this.connectedPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.connectedGridView)).EndInit();
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage connectionlessPage;
		private System.Windows.Forms.TabPage connectedPage;
		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.DataGridView disconnectedGridView;
		private System.Windows.Forms.DataGridView connectedGridView;
		private System.Windows.Forms.TextBox countTxtBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

