namespace VisualizeAlgorithmV2
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
            this.pbSort = new System.Windows.Forms.PictureBox();
            this.lbNelements = new System.Windows.Forms.Label();
            this.lbSSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.cbNelements = new System.Windows.Forms.ComboBox();
            this.btSort = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btFinish = new System.Windows.Forms.Button();
            this.cbSortList = new System.Windows.Forms.ComboBox();
            this.lbSortList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeExecute = new System.Windows.Forms.Label();
            this.ArrayAccesses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSort
            // 
            this.pbSort.Location = new System.Drawing.Point(15, 12);
            this.pbSort.Name = "pbSort";
            this.pbSort.Size = new System.Drawing.Size(1257, 521);
            this.pbSort.TabIndex = 0;
            this.pbSort.TabStop = false;
            // 
            // lbNelements
            // 
            this.lbNelements.AutoSize = true;
            this.lbNelements.Location = new System.Drawing.Point(12, 544);
            this.lbNelements.Name = "lbNelements";
            this.lbNelements.Size = new System.Drawing.Size(101, 13);
            this.lbNelements.TabIndex = 1;
            this.lbNelements.Text = "Number of elements";
            // 
            // lbSSpeed
            // 
            this.lbSSpeed.AutoSize = true;
            this.lbSSpeed.Location = new System.Drawing.Point(12, 612);
            this.lbSSpeed.Name = "lbSSpeed";
            this.lbSSpeed.Size = new System.Drawing.Size(74, 13);
            this.lbSSpeed.TabIndex = 2;
            this.lbSSpeed.Text = "Sorting Speed";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(120, 604);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(123, 45);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.TickFrequency = 10;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // cbNelements
            // 
            this.cbNelements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNelements.FormattingEnabled = true;
            this.cbNelements.Items.AddRange(new object[] {
            "10",
            "100",
            "600"});
            this.cbNelements.Location = new System.Drawing.Point(120, 541);
            this.cbNelements.Name = "cbNelements";
            this.cbNelements.Size = new System.Drawing.Size(123, 21);
            this.cbNelements.TabIndex = 4;
            this.cbNelements.SelectedIndexChanged += new System.EventHandler(this.cbNelements_SelectedIndexChanged);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(279, 539);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(97, 86);
            this.btSort.TabIndex = 5;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(419, 539);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(97, 86);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Pause";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btFinish
            // 
            this.btFinish.Location = new System.Drawing.Point(559, 539);
            this.btFinish.Name = "btFinish";
            this.btFinish.Size = new System.Drawing.Size(97, 86);
            this.btFinish.TabIndex = 7;
            this.btFinish.Text = "Finish";
            this.btFinish.UseVisualStyleBackColor = true;
            this.btFinish.Click += new System.EventHandler(this.btFinish_Click);
            // 
            // cbSortList
            // 
            this.cbSortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortList.FormattingEnabled = true;
            this.cbSortList.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort",
            "Selection Sort",
            "Insertion Sort",
            "Interchange Sort"});
            this.cbSortList.Location = new System.Drawing.Point(120, 573);
            this.cbSortList.Name = "cbSortList";
            this.cbSortList.Size = new System.Drawing.Size(123, 21);
            this.cbSortList.TabIndex = 8;
            // 
            // lbSortList
            // 
            this.lbSortList.AutoSize = true;
            this.lbSortList.Location = new System.Drawing.Point(12, 576);
            this.lbSortList.Name = "lbSortList";
            this.lbSortList.Size = new System.Drawing.Size(45, 13);
            this.lbSortList.TabIndex = 9;
            this.lbSortList.Text = "Sort List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delay: 0%";
            // 
            // TimeExecute
            // 
            this.TimeExecute.AutoSize = true;
            this.TimeExecute.Location = new System.Drawing.Point(276, 636);
            this.TimeExecute.Name = "TimeExecute";
            this.TimeExecute.Size = new System.Drawing.Size(77, 13);
            this.TimeExecute.TabIndex = 13;
            this.TimeExecute.Text = "Run time: 0 ms";
            // 
            // ArrayAccesses
            // 
            this.ArrayAccesses.AutoSize = true;
            this.ArrayAccesses.Location = new System.Drawing.Point(416, 636);
            this.ArrayAccesses.Name = "ArrayAccesses";
            this.ArrayAccesses.Size = new System.Drawing.Size(92, 13);
            this.ArrayAccesses.TabIndex = 14;
            this.ArrayAccesses.Text = "Array Accesses: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.ArrayAccesses);
            this.Controls.Add(this.TimeExecute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSortList);
            this.Controls.Add(this.cbSortList);
            this.Controls.Add(this.btFinish);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.cbNelements);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lbSSpeed);
            this.Controls.Add(this.lbNelements);
            this.Controls.Add(this.pbSort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSort;
        private System.Windows.Forms.Label lbNelements;
        private System.Windows.Forms.Label lbSSpeed;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.ComboBox cbNelements;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btFinish;
        private System.Windows.Forms.ComboBox cbSortList;
        private System.Windows.Forms.Label lbSortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TimeExecute;
        private System.Windows.Forms.Label ArrayAccesses;
    }
}

