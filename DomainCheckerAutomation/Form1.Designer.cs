namespace DomainCheckerAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainGrbox = new System.Windows.Forms.GroupBox();
            this.consoleTb = new System.Windows.Forms.RichTextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.showGrbox = new System.Windows.Forms.GroupBox();
            this.controlGrbox = new System.Windows.Forms.GroupBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.proxyBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.totalLb = new System.Windows.Forms.Label();
            this.liveLb = new System.Windows.Forms.Label();
            this.dieLb = new System.Windows.Forms.Label();
            this.errorLb = new System.Windows.Forms.Label();
            this.cpmLb = new System.Windows.Forms.Label();
            this.userProxyCbox = new System.Windows.Forms.CheckBox();
            this.programProxyCBox = new System.Windows.Forms.CheckBox();
            this.mainGrbox.SuspendLayout();
            this.showGrbox.SuspendLayout();
            this.controlGrbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGrbox
            // 
            this.mainGrbox.Controls.Add(this.consoleTb);
            this.mainGrbox.Location = new System.Drawing.Point(1, 0);
            this.mainGrbox.Name = "mainGrbox";
            this.mainGrbox.Size = new System.Drawing.Size(626, 447);
            this.mainGrbox.TabIndex = 0;
            this.mainGrbox.TabStop = false;
            // 
            // consoleTb
            // 
            this.consoleTb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consoleTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTb.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTb.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleTb.Location = new System.Drawing.Point(3, 18);
            this.consoleTb.Name = "consoleTb";
            this.consoleTb.ReadOnly = true;
            this.consoleTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.consoleTb.ShortcutsEnabled = false;
            this.consoleTb.Size = new System.Drawing.Size(620, 426);
            this.consoleTb.TabIndex = 0;
            this.consoleTb.Text = "Wating...";
            this.consoleTb.WordWrap = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtn.Location = new System.Drawing.Point(6, 65);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(193, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add List";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // showGrbox
            // 
            this.showGrbox.Controls.Add(this.cpmLb);
            this.showGrbox.Controls.Add(this.errorLb);
            this.showGrbox.Controls.Add(this.dieLb);
            this.showGrbox.Controls.Add(this.liveLb);
            this.showGrbox.Controls.Add(this.totalLb);
            this.showGrbox.Location = new System.Drawing.Point(633, 0);
            this.showGrbox.Name = "showGrbox";
            this.showGrbox.Size = new System.Drawing.Size(206, 172);
            this.showGrbox.TabIndex = 2;
            this.showGrbox.TabStop = false;
            // 
            // controlGrbox
            // 
            this.controlGrbox.Controls.Add(this.programProxyCBox);
            this.controlGrbox.Controls.Add(this.userProxyCbox);
            this.controlGrbox.Controls.Add(this.fileBtn);
            this.controlGrbox.Controls.Add(this.proxyBtn);
            this.controlGrbox.Controls.Add(this.stopBtn);
            this.controlGrbox.Controls.Add(this.runBtn);
            this.controlGrbox.Controls.Add(this.delBtn);
            this.controlGrbox.Controls.Add(this.addBtn);
            this.controlGrbox.Location = new System.Drawing.Point(633, 171);
            this.controlGrbox.Name = "controlGrbox";
            this.controlGrbox.Size = new System.Drawing.Size(206, 276);
            this.controlGrbox.TabIndex = 3;
            this.controlGrbox.TabStop = false;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delBtn.Location = new System.Drawing.Point(7, 106);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(193, 35);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "Delete all";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runBtn.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.runBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.runBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runBtn.Location = new System.Drawing.Point(6, 147);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(193, 35);
            this.runBtn.TabIndex = 3;
            this.runBtn.Text = "Run process";
            this.runBtn.UseVisualStyleBackColor = false;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Location = new System.Drawing.Point(7, 188);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(193, 35);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Force stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // proxyBtn
            // 
            this.proxyBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proxyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proxyBtn.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.proxyBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.proxyBtn.Location = new System.Drawing.Point(7, 229);
            this.proxyBtn.Name = "proxyBtn";
            this.proxyBtn.Size = new System.Drawing.Size(126, 35);
            this.proxyBtn.TabIndex = 5;
            this.proxyBtn.Text = "Proxy";
            this.proxyBtn.UseVisualStyleBackColor = false;
            // 
            // fileBtn
            // 
            this.fileBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileBtn.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.fileBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileBtn.Image = ((System.Drawing.Image)(resources.GetObject("fileBtn.Image")));
            this.fileBtn.Location = new System.Drawing.Point(139, 229);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(61, 35);
            this.fileBtn.TabIndex = 6;
            this.fileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fileBtn.UseVisualStyleBackColor = false;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // totalLb
            // 
            this.totalLb.AutoSize = true;
            this.totalLb.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.totalLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLb.Location = new System.Drawing.Point(15, 18);
            this.totalLb.Name = "totalLb";
            this.totalLb.Size = new System.Drawing.Size(61, 18);
            this.totalLb.TabIndex = 0;
            this.totalLb.Text = "Total : 0";
            // 
            // liveLb
            // 
            this.liveLb.AutoSize = true;
            this.liveLb.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.liveLb.ForeColor = System.Drawing.Color.Lime;
            this.liveLb.Location = new System.Drawing.Point(15, 48);
            this.liveLb.Name = "liveLb";
            this.liveLb.Size = new System.Drawing.Size(74, 18);
            this.liveLb.TabIndex = 1;
            this.liveLb.Text = "Live : 0 / 0";
            // 
            // dieLb
            // 
            this.dieLb.AutoSize = true;
            this.dieLb.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.dieLb.ForeColor = System.Drawing.Color.Red;
            this.dieLb.Location = new System.Drawing.Point(15, 78);
            this.dieLb.Name = "dieLb";
            this.dieLb.Size = new System.Drawing.Size(69, 18);
            this.dieLb.TabIndex = 2;
            this.dieLb.Text = "Die : 0 / 0";
            // 
            // errorLb
            // 
            this.errorLb.AutoSize = true;
            this.errorLb.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.errorLb.ForeColor = System.Drawing.Color.Yellow;
            this.errorLb.Location = new System.Drawing.Point(15, 109);
            this.errorLb.Name = "errorLb";
            this.errorLb.Size = new System.Drawing.Size(65, 18);
            this.errorLb.TabIndex = 3;
            this.errorLb.Text = "Error : 0";
            // 
            // cpmLb
            // 
            this.cpmLb.AutoSize = true;
            this.cpmLb.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.cpmLb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpmLb.Location = new System.Drawing.Point(15, 139);
            this.cpmLb.Name = "cpmLb";
            this.cpmLb.Size = new System.Drawing.Size(59, 18);
            this.cpmLb.TabIndex = 4;
            this.cpmLb.Text = "CPM : 0";
            // 
            // userProxyCbox
            // 
            this.userProxyCbox.AutoSize = true;
            this.userProxyCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userProxyCbox.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.userProxyCbox.ForeColor = System.Drawing.SystemColors.Window;
            this.userProxyCbox.Location = new System.Drawing.Point(10, 13);
            this.userProxyCbox.Name = "userProxyCbox";
            this.userProxyCbox.Size = new System.Drawing.Size(111, 22);
            this.userProxyCbox.TabIndex = 7;
            this.userProxyCbox.Text = "User Proxy ?";
            this.userProxyCbox.UseVisualStyleBackColor = true;
            this.userProxyCbox.CheckedChanged += new System.EventHandler(this.userProxyCbox_CheckedChanged);
            // 
            // programProxyCBox
            // 
            this.programProxyCBox.AutoSize = true;
            this.programProxyCBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programProxyCBox.Font = new System.Drawing.Font("Zilla Slab SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.programProxyCBox.ForeColor = System.Drawing.SystemColors.Window;
            this.programProxyCBox.Location = new System.Drawing.Point(10, 40);
            this.programProxyCBox.Name = "programProxyCBox";
            this.programProxyCBox.Size = new System.Drawing.Size(138, 22);
            this.programProxyCBox.TabIndex = 8;
            this.programProxyCBox.Text = "Program Proxy ?";
            this.programProxyCBox.UseVisualStyleBackColor = true;
            this.programProxyCBox.CheckedChanged += new System.EventHandler(this.programProxyCBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.controlGrbox);
            this.Controls.Add(this.showGrbox);
            this.Controls.Add(this.mainGrbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domain Checker | MSquad ( t.me/dckzyr )";
            this.mainGrbox.ResumeLayout(false);
            this.showGrbox.ResumeLayout(false);
            this.showGrbox.PerformLayout();
            this.controlGrbox.ResumeLayout(false);
            this.controlGrbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGrbox;
        private System.Windows.Forms.RichTextBox consoleTb;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.GroupBox showGrbox;
        private System.Windows.Forms.GroupBox controlGrbox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.Button proxyBtn;
        private System.Windows.Forms.Label totalLb;
        private System.Windows.Forms.Label cpmLb;
        private System.Windows.Forms.Label errorLb;
        private System.Windows.Forms.Label dieLb;
        private System.Windows.Forms.Label liveLb;
        private System.Windows.Forms.CheckBox userProxyCbox;
        private System.Windows.Forms.CheckBox programProxyCBox;
    }
}

