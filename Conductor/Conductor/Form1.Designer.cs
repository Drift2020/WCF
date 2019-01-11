namespace Conductor
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
            this.treeViewPath1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEnd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRenewal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonTabl = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewFolder1 = new System.Windows.Forms.ListView();
            this.IPf = new System.Windows.Forms.TextBox();
            this.PORTf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewPath1
            // 
            this.treeViewPath1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeViewPath1.Location = new System.Drawing.Point(0, 75);
            this.treeViewPath1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeViewPath1.Name = "treeViewPath1";
            this.treeViewPath1.Size = new System.Drawing.Size(325, 729);
            this.treeViewPath1.TabIndex = 0;
            this.treeViewPath1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPath1_AfterCollapse);
            this.treeViewPath1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewPath1_BeforeExpand);
            this.treeViewPath1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPath1_AfterSelect);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEnd,
            this.toolStripButtonMove,
            this.toolStripSeparator1,
            this.toolStripButtonUp,
            this.toolStripSeparator2,
            this.toolStripButtonRenewal,
            this.toolStripSeparator3,
            this.toolStripSplitButtonTabl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1311, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonEnd
            // 
            this.toolStripButtonEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEnd.Image = global::Conductor.Properties.Resources.back;
            this.toolStripButtonEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnd.Name = "toolStripButtonEnd";
            this.toolStripButtonEnd.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonEnd.Text = "toolStripButton1";
            this.toolStripButtonEnd.Click += new System.EventHandler(this.toolStripButtonEnd_Click);
            // 
            // toolStripButtonMove
            // 
            this.toolStripButtonMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMove.Image = global::Conductor.Properties.Resources.forward;
            this.toolStripButtonMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMove.Name = "toolStripButtonMove";
            this.toolStripButtonMove.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonMove.Text = "toolStripButton2";
            this.toolStripButtonMove.Click += new System.EventHandler(this.toolStripButtonMove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonUp
            // 
            this.toolStripButtonUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUp.Image = global::Conductor.Properties.Resources.up;
            this.toolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUp.Name = "toolStripButtonUp";
            this.toolStripButtonUp.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonUp.Text = "toolStripButton3";
            this.toolStripButtonUp.Click += new System.EventHandler(this.toolStripButtonUp_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonRenewal
            // 
            this.toolStripButtonRenewal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRenewal.Image = global::Conductor.Properties.Resources.refresh;
            this.toolStripButtonRenewal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRenewal.Name = "toolStripButtonRenewal";
            this.toolStripButtonRenewal.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRenewal.Text = "toolStripButton4";
            this.toolStripButtonRenewal.Click += new System.EventHandler(this.toolStripButtonRenewal_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSplitButtonTabl
            // 
            this.toolStripSplitButtonTabl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonTabl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3,
            this.ToolStripMenuItem4});
            this.toolStripSplitButtonTabl.Image = global::Conductor.Properties.Resources.view;
            this.toolStripSplitButtonTabl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonTabl.Name = "toolStripSplitButtonTabl";
            this.toolStripSplitButtonTabl.Size = new System.Drawing.Size(45, 28);
            this.toolStripSplitButtonTabl.Text = "toolStripSplitButton1";
            this.toolStripSplitButtonTabl.ButtonClick += new System.EventHandler(this.toolStripSplitButtonTabl_ButtonClick);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(229, 30);
            this.ToolStripMenuItem1.Text = "Список";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(229, 30);
            this.ToolStripMenuItem2.Text = "Таблица";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(229, 30);
            this.ToolStripMenuItem3.Text = "Плитка";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem4
            // 
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            this.ToolStripMenuItem4.Size = new System.Drawing.Size(229, 30);
            this.ToolStripMenuItem4.Text = "Большие значки";
            this.ToolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // listViewFolder1
            // 
            this.listViewFolder1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFolder1.Location = new System.Drawing.Point(327, 75);
            this.listViewFolder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewFolder1.Name = "listViewFolder1";
            this.listViewFolder1.Size = new System.Drawing.Size(982, 729);
            this.listViewFolder1.TabIndex = 5;
            this.listViewFolder1.UseCompatibleStateImageBehavior = false;
            this.listViewFolder1.ItemActivate += new System.EventHandler(this.listViewFolder1_ItemActivate);
            // 
            // IPf
            // 
            this.IPf.Location = new System.Drawing.Point(69, 41);
            this.IPf.Name = "IPf";
            this.IPf.Size = new System.Drawing.Size(127, 26);
            this.IPf.TabIndex = 6;
            // 
            // PORTf
            // 
            this.PORTf.Location = new System.Drawing.Point(264, 41);
            this.PORTf.Name = "PORTf";
            this.PORTf.Size = new System.Drawing.Size(71, 26);
            this.PORTf.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "PORT:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Connect\\";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 806);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PORTf);
            this.Controls.Add(this.IPf);
            this.Controls.Add(this.listViewFolder1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeViewPath1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Проводник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPath1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnd;
        private System.Windows.Forms.ToolStripButton toolStripButtonMove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonRenewal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonTabl;
        private System.Windows.Forms.ListView listViewFolder1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem4;
        private System.Windows.Forms.TextBox IPf;
        private System.Windows.Forms.TextBox PORTf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

