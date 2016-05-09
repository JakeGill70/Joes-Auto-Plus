namespace JoesAutoPlus {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.routineServicesGroup = new System.Windows.Forms.GroupBox();
            this.chk_transmission = new System.Windows.Forms.CheckBox();
            this.chk_muffler = new System.Windows.Forms.CheckBox();
            this.chk_radiator = new System.Windows.Forms.CheckBox();
            this.chk_tire = new System.Windows.Forms.CheckBox();
            this.chk_inspection = new System.Windows.Forms.CheckBox();
            this.chk_lube = new System.Windows.Forms.CheckBox();
            this.chk_oil = new System.Windows.Forms.CheckBox();
            this.nonRoutineServicesGroup = new System.Windows.Forms.GroupBox();
            this.txt_labor = new System.Windows.Forms.TextBox();
            this.txt_parts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notesGroup = new System.Windows.Forms.GroupBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_comments = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_comments = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_condition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.summaryGroup = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.controlsGroup = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routineServicesGroup.SuspendLayout();
            this.nonRoutineServicesGroup.SuspendLayout();
            this.notesGroup.SuspendLayout();
            this.summaryGroup.SuspendLayout();
            this.controlsGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // routineServicesGroup
            // 
            this.routineServicesGroup.Controls.Add(this.chk_transmission);
            this.routineServicesGroup.Controls.Add(this.chk_muffler);
            this.routineServicesGroup.Controls.Add(this.chk_radiator);
            this.routineServicesGroup.Controls.Add(this.chk_tire);
            this.routineServicesGroup.Controls.Add(this.chk_inspection);
            this.routineServicesGroup.Controls.Add(this.chk_lube);
            this.routineServicesGroup.Controls.Add(this.chk_oil);
            this.routineServicesGroup.Location = new System.Drawing.Point(12, 27);
            this.routineServicesGroup.Name = "routineServicesGroup";
            this.routineServicesGroup.Size = new System.Drawing.Size(214, 120);
            this.routineServicesGroup.TabIndex = 0;
            this.routineServicesGroup.TabStop = false;
            this.routineServicesGroup.Text = "Routine Services";
            // 
            // chk_transmission
            // 
            this.chk_transmission.AutoSize = true;
            this.chk_transmission.Location = new System.Drawing.Point(7, 90);
            this.chk_transmission.Name = "chk_transmission";
            this.chk_transmission.Size = new System.Drawing.Size(115, 17);
            this.chk_transmission.TabIndex = 3;
            this.chk_transmission.Text = "Transmission Flush";
            this.chk_transmission.UseVisualStyleBackColor = true;
            // 
            // chk_muffler
            // 
            this.chk_muffler.AutoSize = true;
            this.chk_muffler.Location = new System.Drawing.Point(106, 21);
            this.chk_muffler.Name = "chk_muffler";
            this.chk_muffler.Size = new System.Drawing.Size(101, 17);
            this.chk_muffler.TabIndex = 4;
            this.chk_muffler.Text = "Replace Muffler";
            this.chk_muffler.UseVisualStyleBackColor = true;
            // 
            // chk_radiator
            // 
            this.chk_radiator.AutoSize = true;
            this.chk_radiator.Location = new System.Drawing.Point(106, 44);
            this.chk_radiator.Name = "chk_radiator";
            this.chk_radiator.Size = new System.Drawing.Size(94, 17);
            this.chk_radiator.TabIndex = 5;
            this.chk_radiator.Text = "Radiator Flush";
            this.chk_radiator.UseVisualStyleBackColor = true;
            // 
            // chk_tire
            // 
            this.chk_tire.AutoSize = true;
            this.chk_tire.Location = new System.Drawing.Point(7, 67);
            this.chk_tire.Name = "chk_tire";
            this.chk_tire.Size = new System.Drawing.Size(87, 17);
            this.chk_tire.TabIndex = 2;
            this.chk_tire.Text = "Tire Rotation";
            this.chk_tire.UseVisualStyleBackColor = true;
            // 
            // chk_inspection
            // 
            this.chk_inspection.AutoSize = true;
            this.chk_inspection.Location = new System.Drawing.Point(106, 67);
            this.chk_inspection.Name = "chk_inspection";
            this.chk_inspection.Size = new System.Drawing.Size(75, 17);
            this.chk_inspection.TabIndex = 6;
            this.chk_inspection.Text = "Inspection";
            this.chk_inspection.UseVisualStyleBackColor = true;
            // 
            // chk_lube
            // 
            this.chk_lube.AutoSize = true;
            this.chk_lube.Location = new System.Drawing.Point(7, 44);
            this.chk_lube.Name = "chk_lube";
            this.chk_lube.Size = new System.Drawing.Size(70, 17);
            this.chk_lube.TabIndex = 1;
            this.chk_lube.Text = "Lube Job";
            this.chk_lube.UseVisualStyleBackColor = true;
            // 
            // chk_oil
            // 
            this.chk_oil.AutoSize = true;
            this.chk_oil.Location = new System.Drawing.Point(7, 21);
            this.chk_oil.Name = "chk_oil";
            this.chk_oil.Size = new System.Drawing.Size(78, 17);
            this.chk_oil.TabIndex = 0;
            this.chk_oil.Text = "Oil Change";
            this.chk_oil.UseVisualStyleBackColor = true;
            // 
            // nonRoutineServicesGroup
            // 
            this.nonRoutineServicesGroup.Controls.Add(this.txt_labor);
            this.nonRoutineServicesGroup.Controls.Add(this.txt_parts);
            this.nonRoutineServicesGroup.Controls.Add(this.label2);
            this.nonRoutineServicesGroup.Controls.Add(this.label1);
            this.nonRoutineServicesGroup.Location = new System.Drawing.Point(232, 28);
            this.nonRoutineServicesGroup.Name = "nonRoutineServicesGroup";
            this.nonRoutineServicesGroup.Size = new System.Drawing.Size(196, 119);
            this.nonRoutineServicesGroup.TabIndex = 1;
            this.nonRoutineServicesGroup.TabStop = false;
            this.nonRoutineServicesGroup.Text = "Non-Routine Services";
            // 
            // txt_labor
            // 
            this.txt_labor.Location = new System.Drawing.Point(83, 41);
            this.txt_labor.Name = "txt_labor";
            this.txt_labor.Size = new System.Drawing.Size(100, 20);
            this.txt_labor.TabIndex = 1;
            // 
            // txt_parts
            // 
            this.txt_parts.Location = new System.Drawing.Point(83, 17);
            this.txt_parts.Name = "txt_parts";
            this.txt_parts.Size = new System.Drawing.Size(100, 20);
            this.txt_parts.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Labor (Hrs)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            // 
            // notesGroup
            // 
            this.notesGroup.Controls.Add(this.txt_year);
            this.notesGroup.Controls.Add(this.txt_model);
            this.notesGroup.Controls.Add(this.txt_make);
            this.notesGroup.Controls.Add(this.txt_phone);
            this.notesGroup.Controls.Add(this.label9);
            this.notesGroup.Controls.Add(this.txt_comments);
            this.notesGroup.Controls.Add(this.txt_name);
            this.notesGroup.Controls.Add(this.lbl_comments);
            this.notesGroup.Controls.Add(this.label7);
            this.notesGroup.Controls.Add(this.cmb_condition);
            this.notesGroup.Controls.Add(this.label6);
            this.notesGroup.Controls.Add(this.label5);
            this.notesGroup.Controls.Add(this.label4);
            this.notesGroup.Controls.Add(this.label3);
            this.notesGroup.Location = new System.Drawing.Point(12, 153);
            this.notesGroup.Name = "notesGroup";
            this.notesGroup.Size = new System.Drawing.Size(416, 137);
            this.notesGroup.TabIndex = 2;
            this.notesGroup.TabStop = false;
            this.notesGroup.Text = "Notes";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(303, 56);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 20);
            this.txt_year.TabIndex = 4;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(303, 34);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 3;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(303, 13);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(100, 20);
            this.txt_make.TabIndex = 2;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(50, 36);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone";
            // 
            // txt_comments
            // 
            this.txt_comments.Location = new System.Drawing.Point(6, 81);
            this.txt_comments.Multiline = true;
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(200, 49);
            this.txt_comments.TabIndex = 6;
            this.txt_comments.TextChanged += new System.EventHandler(this.txt_comments_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(50, 13);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 20);
            this.txt_name.TabIndex = 0;
            // 
            // lbl_comments
            // 
            this.lbl_comments.AutoSize = true;
            this.lbl_comments.Location = new System.Drawing.Point(6, 59);
            this.lbl_comments.Name = "lbl_comments";
            this.lbl_comments.Size = new System.Drawing.Size(83, 13);
            this.lbl_comments.TabIndex = 9;
            this.lbl_comments.Text = "Comments (140)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Condition";
            // 
            // cmb_condition
            // 
            this.cmb_condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_condition.FormattingEnabled = true;
            this.cmb_condition.Items.AddRange(new object[] {
            "Deathtrap",
            "Bad",
            "Fair",
            "Good",
            "Like-New"});
            this.cmb_condition.Location = new System.Drawing.Point(303, 78);
            this.cmb_condition.Name = "cmb_condition";
            this.cmb_condition.Size = new System.Drawing.Size(100, 21);
            this.cmb_condition.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Make";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // summaryGroup
            // 
            this.summaryGroup.Controls.Add(this.lbl_total);
            this.summaryGroup.Controls.Add(this.lbl_tax);
            this.summaryGroup.Controls.Add(this.lbl_sub);
            this.summaryGroup.Location = new System.Drawing.Point(13, 297);
            this.summaryGroup.Name = "summaryGroup";
            this.summaryGroup.Size = new System.Drawing.Size(213, 93);
            this.summaryGroup.TabIndex = 3;
            this.summaryGroup.TabStop = false;
            this.summaryGroup.Text = "Summary";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(4, 67);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(64, 13);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "Total: $0.00";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(3, 43);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(58, 13);
            this.lbl_tax.TabIndex = 1;
            this.lbl_tax.Text = "Tax: $0.00";
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Location = new System.Drawing.Point(3, 20);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(82, 13);
            this.lbl_sub.TabIndex = 0;
            this.lbl_sub.Text = "Sub-total: $0.00";
            // 
            // controlsGroup
            // 
            this.controlsGroup.Controls.Add(this.btn_exit);
            this.controlsGroup.Controls.Add(this.btn_clear);
            this.controlsGroup.Controls.Add(this.btn_save);
            this.controlsGroup.Controls.Add(this.btn_calc);
            this.controlsGroup.Location = new System.Drawing.Point(232, 297);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Size = new System.Drawing.Size(196, 93);
            this.controlsGroup.TabIndex = 3;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Controls";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(109, 57);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(109, 20);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(81, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(9, 57);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(10, 20);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(86, 23);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1,
            this.databaseToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem1_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 403);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.summaryGroup);
            this.Controls.Add(this.notesGroup);
            this.Controls.Add(this.nonRoutineServicesGroup);
            this.Controls.Add(this.routineServicesGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Joe\'s Automotive";
            this.routineServicesGroup.ResumeLayout(false);
            this.routineServicesGroup.PerformLayout();
            this.nonRoutineServicesGroup.ResumeLayout(false);
            this.nonRoutineServicesGroup.PerformLayout();
            this.notesGroup.ResumeLayout(false);
            this.notesGroup.PerformLayout();
            this.summaryGroup.ResumeLayout(false);
            this.summaryGroup.PerformLayout();
            this.controlsGroup.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox routineServicesGroup;
        private System.Windows.Forms.CheckBox chk_transmission;
        private System.Windows.Forms.CheckBox chk_muffler;
        private System.Windows.Forms.CheckBox chk_radiator;
        private System.Windows.Forms.CheckBox chk_tire;
        private System.Windows.Forms.CheckBox chk_inspection;
        private System.Windows.Forms.CheckBox chk_lube;
        private System.Windows.Forms.CheckBox chk_oil;
        private System.Windows.Forms.GroupBox nonRoutineServicesGroup;
        private System.Windows.Forms.TextBox txt_labor;
        private System.Windows.Forms.TextBox txt_parts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox notesGroup;
        private System.Windows.Forms.Label lbl_comments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_condition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_comments;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox summaryGroup;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.GroupBox controlsGroup;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
    }
}

