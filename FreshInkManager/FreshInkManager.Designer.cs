namespace FreshInkManager
{
    partial class FreshInkManager
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
            this.Button_RunTest = new System.Windows.Forms.Button();
            this.Label_TargetDate = new System.Windows.Forms.Label();
            this.Label_Interval = new System.Windows.Forms.Label();
            this.Label_TestDocument = new System.Windows.Forms.Label();
            this.ListView_Printers = new System.Windows.Forms.ListView();
            this.TextBox_TestDocument = new System.Windows.Forms.TextBox();
            this.DatePicker_TargetDate = new System.Windows.Forms.DateTimePicker();
            this.Label_Printers = new System.Windows.Forms.Label();
            this.NumericUpDown_Interval = new System.Windows.Forms.NumericUpDown();
            this.Button_SaveConfig = new System.Windows.Forms.Button();
            this.Button_SelectTestDocument = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_RunTest
            // 
            this.Button_RunTest.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button_RunTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RunTest.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RunTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Button_RunTest.Location = new System.Drawing.Point(12, 349);
            this.Button_RunTest.Name = "Button_RunTest";
            this.Button_RunTest.Size = new System.Drawing.Size(339, 39);
            this.Button_RunTest.TabIndex = 0;
            this.Button_RunTest.Text = "Run Config Test";
            this.Button_RunTest.UseVisualStyleBackColor = false;
            this.Button_RunTest.Click += new System.EventHandler(this.Button_RunTest_Click);
            // 
            // Label_TargetDate
            // 
            this.Label_TargetDate.AutoSize = true;
            this.Label_TargetDate.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TargetDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Label_TargetDate.Location = new System.Drawing.Point(7, 15);
            this.Label_TargetDate.Name = "Label_TargetDate";
            this.Label_TargetDate.Size = new System.Drawing.Size(122, 27);
            this.Label_TargetDate.TabIndex = 1;
            this.Label_TargetDate.Text = "Target Date:";
            // 
            // Label_Interval
            // 
            this.Label_Interval.AutoSize = true;
            this.Label_Interval.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Interval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Label_Interval.Location = new System.Drawing.Point(7, 45);
            this.Label_Interval.Name = "Label_Interval";
            this.Label_Interval.Size = new System.Drawing.Size(149, 27);
            this.Label_Interval.TabIndex = 2;
            this.Label_Interval.Text = "Interval (days):";
            // 
            // Label_TestDocument
            // 
            this.Label_TestDocument.AutoSize = true;
            this.Label_TestDocument.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TestDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Label_TestDocument.Location = new System.Drawing.Point(7, 78);
            this.Label_TestDocument.Name = "Label_TestDocument";
            this.Label_TestDocument.Size = new System.Drawing.Size(154, 27);
            this.Label_TestDocument.TabIndex = 3;
            this.Label_TestDocument.Text = "Test Document:";
            // 
            // ListView_Printers
            // 
            this.ListView_Printers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ListView_Printers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView_Printers.CheckBoxes = true;
            this.ListView_Printers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView_Printers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.ListView_Printers.HideSelection = false;
            this.ListView_Printers.Location = new System.Drawing.Point(12, 196);
            this.ListView_Printers.Name = "ListView_Printers";
            this.ListView_Printers.Size = new System.Drawing.Size(339, 102);
            this.ListView_Printers.TabIndex = 4;
            this.ListView_Printers.UseCompatibleStateImageBehavior = false;
            this.ListView_Printers.View = System.Windows.Forms.View.List;
            // 
            // TextBox_TestDocument
            // 
            this.TextBox_TestDocument.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBox_TestDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_TestDocument.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TestDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.TextBox_TestDocument.Location = new System.Drawing.Point(12, 120);
            this.TextBox_TestDocument.Multiline = true;
            this.TextBox_TestDocument.Name = "TextBox_TestDocument";
            this.TextBox_TestDocument.ReadOnly = true;
            this.TextBox_TestDocument.Size = new System.Drawing.Size(339, 43);
            this.TextBox_TestDocument.TabIndex = 7;
            this.TextBox_TestDocument.Text = "Default";
            // 
            // DatePicker_TargetDate
            // 
            this.DatePicker_TargetDate.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_TargetDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DatePicker_TargetDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DatePicker_TargetDate.CustomFormat = "MM/dd/yyyy hh:mm";
            this.DatePicker_TargetDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker_TargetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker_TargetDate.Location = new System.Drawing.Point(162, 11);
            this.DatePicker_TargetDate.Name = "DatePicker_TargetDate";
            this.DatePicker_TargetDate.Size = new System.Drawing.Size(189, 31);
            this.DatePicker_TargetDate.TabIndex = 8;
            // 
            // Label_Printers
            // 
            this.Label_Printers.AutoSize = true;
            this.Label_Printers.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Printers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Label_Printers.Location = new System.Drawing.Point(7, 166);
            this.Label_Printers.Name = "Label_Printers";
            this.Label_Printers.Size = new System.Drawing.Size(89, 27);
            this.Label_Printers.TabIndex = 9;
            this.Label_Printers.Text = "Printers:";
            // 
            // NumericUpDown_Interval
            // 
            this.NumericUpDown_Interval.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumericUpDown_Interval.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumericUpDown_Interval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.NumericUpDown_Interval.Location = new System.Drawing.Point(162, 48);
            this.NumericUpDown_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Interval.Name = "NumericUpDown_Interval";
            this.NumericUpDown_Interval.Size = new System.Drawing.Size(189, 27);
            this.NumericUpDown_Interval.TabIndex = 10;
            this.NumericUpDown_Interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Button_SaveConfig
            // 
            this.Button_SaveConfig.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button_SaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SaveConfig.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Button_SaveConfig.Location = new System.Drawing.Point(12, 304);
            this.Button_SaveConfig.Name = "Button_SaveConfig";
            this.Button_SaveConfig.Size = new System.Drawing.Size(339, 39);
            this.Button_SaveConfig.TabIndex = 12;
            this.Button_SaveConfig.Text = "Save Config";
            this.Button_SaveConfig.UseVisualStyleBackColor = false;
            this.Button_SaveConfig.Click += new System.EventHandler(this.Button_SaveConfig_Click);
            // 
            // Button_SelectTestDocument
            // 
            this.Button_SelectTestDocument.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button_SelectTestDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SelectTestDocument.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SelectTestDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Button_SelectTestDocument.Location = new System.Drawing.Point(162, 82);
            this.Button_SelectTestDocument.Name = "Button_SelectTestDocument";
            this.Button_SelectTestDocument.Size = new System.Drawing.Size(189, 32);
            this.Button_SelectTestDocument.TabIndex = 13;
            this.Button_SelectTestDocument.Text = "Select Test Document";
            this.Button_SelectTestDocument.UseVisualStyleBackColor = false;
            this.Button_SelectTestDocument.Click += new System.EventHandler(this.Button_SelectTestDocument_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // FreshInkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(364, 397);
            this.Controls.Add(this.Button_SelectTestDocument);
            this.Controls.Add(this.Button_SaveConfig);
            this.Controls.Add(this.NumericUpDown_Interval);
            this.Controls.Add(this.Label_Printers);
            this.Controls.Add(this.DatePicker_TargetDate);
            this.Controls.Add(this.TextBox_TestDocument);
            this.Controls.Add(this.ListView_Printers);
            this.Controls.Add(this.Label_TestDocument);
            this.Controls.Add(this.Label_Interval);
            this.Controls.Add(this.Label_TargetDate);
            this.Controls.Add(this.Button_RunTest);
            this.Name = "FreshInkManager";
            this.Text = "Fresh Ink Manager";
            this.Load += new System.EventHandler(this.FreshInkManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_RunTest;
        private System.Windows.Forms.Label Label_TargetDate;
        private System.Windows.Forms.Label Label_Interval;
        private System.Windows.Forms.Label Label_TestDocument;
        private System.Windows.Forms.ListView ListView_Printers;
        private System.Windows.Forms.TextBox TextBox_TestDocument;
        private System.Windows.Forms.DateTimePicker DatePicker_TargetDate;
        private System.Windows.Forms.Label Label_Printers;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Interval;
        private System.Windows.Forms.Button Button_SaveConfig;
        private System.Windows.Forms.Button Button_SelectTestDocument;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

