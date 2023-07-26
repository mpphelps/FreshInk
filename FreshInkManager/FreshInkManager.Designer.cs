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
            this.TextBox_Interval = new System.Windows.Forms.TextBox();
            this.TextBox_TestDocument = new System.Windows.Forms.TextBox();
            this.TargetDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Label_Printers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_RunTest
            // 
            this.Button_RunTest.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Button_RunTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RunTest.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RunTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Button_RunTest.Location = new System.Drawing.Point(12, 243);
            this.Button_RunTest.Name = "Button_RunTest";
            this.Button_RunTest.Size = new System.Drawing.Size(339, 39);
            this.Button_RunTest.TabIndex = 0;
            this.Button_RunTest.Text = "Run Test";
            this.Button_RunTest.UseVisualStyleBackColor = false;
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
            this.ListView_Printers.Location = new System.Drawing.Point(12, 135);
            this.ListView_Printers.Name = "ListView_Printers";
            this.ListView_Printers.Size = new System.Drawing.Size(339, 102);
            this.ListView_Printers.TabIndex = 4;
            this.ListView_Printers.UseCompatibleStateImageBehavior = false;
            this.ListView_Printers.View = System.Windows.Forms.View.List;
            // 
            // TextBox_Interval
            // 
            this.TextBox_Interval.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBox_Interval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Interval.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Interval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.TextBox_Interval.Location = new System.Drawing.Point(162, 48);
            this.TextBox_Interval.Name = "TextBox_Interval";
            this.TextBox_Interval.Size = new System.Drawing.Size(189, 27);
            this.TextBox_Interval.TabIndex = 6;
            // 
            // TextBox_TestDocument
            // 
            this.TextBox_TestDocument.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBox_TestDocument.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_TestDocument.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_TestDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.TextBox_TestDocument.Location = new System.Drawing.Point(162, 81);
            this.TextBox_TestDocument.Name = "TextBox_TestDocument";
            this.TextBox_TestDocument.Size = new System.Drawing.Size(189, 27);
            this.TextBox_TestDocument.TabIndex = 7;
            // 
            // TargetDatePicker
            // 
            this.TargetDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.TargetDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TargetDatePicker.CustomFormat = "MM/dd/yyyy hh:mm";
            this.TargetDatePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TargetDatePicker.Location = new System.Drawing.Point(162, 11);
            this.TargetDatePicker.Name = "TargetDatePicker";
            this.TargetDatePicker.Size = new System.Drawing.Size(189, 31);
            this.TargetDatePicker.TabIndex = 8;
            // 
            // Label_Printers
            // 
            this.Label_Printers.AutoSize = true;
            this.Label_Printers.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Printers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.Label_Printers.Location = new System.Drawing.Point(7, 105);
            this.Label_Printers.Name = "Label_Printers";
            this.Label_Printers.Size = new System.Drawing.Size(89, 27);
            this.Label_Printers.TabIndex = 9;
            this.Label_Printers.Text = "Printers:";
            // 
            // FreshInkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(364, 298);
            this.Controls.Add(this.Label_Printers);
            this.Controls.Add(this.TargetDatePicker);
            this.Controls.Add(this.TextBox_TestDocument);
            this.Controls.Add(this.TextBox_Interval);
            this.Controls.Add(this.ListView_Printers);
            this.Controls.Add(this.Label_TestDocument);
            this.Controls.Add(this.Label_Interval);
            this.Controls.Add(this.Label_TargetDate);
            this.Controls.Add(this.Button_RunTest);
            this.Name = "FreshInkManager";
            this.Text = "Fresh Ink Manager";
            this.Load += new System.EventHandler(this.FreshInkManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_RunTest;
        private System.Windows.Forms.Label Label_TargetDate;
        private System.Windows.Forms.Label Label_Interval;
        private System.Windows.Forms.Label Label_TestDocument;
        private System.Windows.Forms.ListView ListView_Printers;
        private System.Windows.Forms.TextBox TextBox_Interval;
        private System.Windows.Forms.TextBox TextBox_TestDocument;
        private System.Windows.Forms.DateTimePicker TargetDatePicker;
        private System.Windows.Forms.Label Label_Printers;
    }
}

