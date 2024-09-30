
namespace ConnectDatabase
{
    partial class FormManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn1_connect = new Button();
            btn2_Close = new Button();
            dataGridView1 = new DataGridView();
            btn3_LoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn1_connect
            // 
            btn1_connect.Location = new Point(131, 228);
            btn1_connect.Name = "btn1_connect";
            btn1_connect.Size = new Size(94, 29);
            btn1_connect.TabIndex = 0;
            btn1_connect.Text = "Connect";
            btn1_connect.UseVisualStyleBackColor = true;
            btn1_connect.Click += btn1_connect_Click;
            // 
            // btn2_Close
            // 
            btn2_Close.Location = new Point(443, 228);
            btn2_Close.Name = "btn2_Close";
            btn2_Close.Size = new Size(94, 29);
            btn2_Close.TabIndex = 1;
            btn2_Close.Text = "Close";
            btn2_Close.UseVisualStyleBackColor = true;
            btn2_Close.Click += btn2_Close_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(76, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(525, 188);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn3_LoadData
            // 
            btn3_LoadData.Location = new Point(297, 300);
            btn3_LoadData.Name = "btn3_LoadData";
            btn3_LoadData.Size = new Size(94, 29);
            btn3_LoadData.TabIndex = 3;
            btn3_LoadData.Text = "LoadData";
            btn3_LoadData.UseVisualStyleBackColor = true;
            btn3_LoadData.Click += btn3_LoadData_Click;
            // 
            // FormManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 437);
            Controls.Add(btn3_LoadData);
            Controls.Add(dataGridView1);
            Controls.Add(btn2_Close);
            Controls.Add(btn1_connect);
            Name = "FormManagement";
            Padding = new Padding(10);
            Text = "Form1";
            Load += FormManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void FormManagement_Load(object sender, EventArgs e)
        {
            
        }

       

        #endregion

        private Button btn1_connect;
        private Button btn2_Close;
        private DataGridView dataGridView1;
        private Button btn3_LoadData;
    }
}
