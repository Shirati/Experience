namespace Gui
{
    partial class Form1
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
            this.order = new System.Windows.Forms.Button();
            this.lstCities = new System.Windows.Forms.ListBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.btorderdesc = new System.Windows.Forms.Button();
            this.btTop5 = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btRev = new System.Windows.Forms.Button();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtafter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(623, 42);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(120, 41);
            this.order.TabIndex = 1;
            this.order.Text = "מיין בסדר עולה";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // lstCities
            // 
            this.lstCities.FormattingEnabled = true;
            this.lstCities.ItemHeight = 20;
            this.lstCities.Location = new System.Drawing.Point(49, 42);
            this.lstCities.Name = "lstCities";
            this.lstCities.Size = new System.Drawing.Size(291, 264);
            this.lstCities.TabIndex = 2;
            this.lstCities.SelectedIndexChanged += new System.EventHandler(this.lstCities_SelectedIndexChanged);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(635, 337);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(125, 27);
            this.txtAdd.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(640, 275);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(120, 42);
            this.add.TabIndex = 4;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // btorderdesc
            // 
            this.btorderdesc.Location = new System.Drawing.Point(618, 100);
            this.btorderdesc.Name = "btorderdesc";
            this.btorderdesc.Size = new System.Drawing.Size(125, 39);
            this.btorderdesc.TabIndex = 5;
            this.btorderdesc.Text = "מיון בסדר יורד";
            this.btorderdesc.UseVisualStyleBackColor = true;
            this.btorderdesc.Click += new System.EventHandler(this.btorderdesc_Click);
            // 
            // btTop5
            // 
            this.btTop5.Location = new System.Drawing.Point(476, 42);
            this.btTop5.Name = "btTop5";
            this.btTop5.Size = new System.Drawing.Size(119, 41);
            this.btTop5.TabIndex = 6;
            this.btTop5.Text = "הצג 5 ראשונים";
            this.btTop5.UseVisualStyleBackColor = true;
            this.btTop5.Click += new System.EventHandler(this.btTop5_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(316, 337);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(120, 42);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "עדכן";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(495, 322);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 42);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "חיפוש לפי חלק מהעיר";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(640, 383);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 42);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "מחק";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "קדימה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRev
            // 
            this.btRev.Location = new System.Drawing.Point(476, 189);
            this.btRev.Name = "btRev";
            this.btRev.Size = new System.Drawing.Size(120, 42);
            this.btRev.TabIndex = 11;
            this.btRev.Text = "אחורה";
            this.btRev.UseVisualStyleBackColor = true;
            this.btRev.Click += new System.EventHandler(this.btRev_Click);
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(185, 345);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(125, 27);
            this.txtpre.TabIndex = 12;
            // 
            // txtafter
            // 
            this.txtafter.Location = new System.Drawing.Point(49, 345);
            this.txtafter.Name = "txtafter";
            this.txtafter.Size = new System.Drawing.Size(125, 27);
            this.txtafter.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtafter);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.btRev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btTop5);
            this.Controls.Add(this.btorderdesc);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lstCities);
            this.Controls.Add(this.order);
            this.Name = "Form1";
            this.Text = "הוסף";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button order;
        private ListBox lstCities;
        private TextBox txtAdd;
        private Button add;
        private Button btorderdesc;
        private Button btTop5;
        private Button btUpdate;
        private Button btnSearch;
        private Button btnDel;
        private Button button1;
        private Button btRev;
        private TextBox txtpre;
        private TextBox txtafter;
    }
}