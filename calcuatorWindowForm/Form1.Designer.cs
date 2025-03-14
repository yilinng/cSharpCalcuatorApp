
using System;
using System.Windows.Forms;

namespace calcuatorWindowForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totallabel = new System.Windows.Forms.Label();
            this.pluslabel = new System.Windows.Forms.Label();
            this.dotlabel = new System.Windows.Forms.Label();
            this.nb0label = new System.Windows.Forms.Label();
            this.minuslabel = new System.Windows.Forms.Label();
            this.nb3label = new System.Windows.Forms.Label();
            this.nb2label = new System.Windows.Forms.Label();
            this.nb1label = new System.Windows.Forms.Label();
            this.multipliedlabel = new System.Windows.Forms.Label();
            this.nb6label = new System.Windows.Forms.Label();
            this.nb5label = new System.Windows.Forms.Label();
            this.nb4abel = new System.Windows.Forms.Label();
            this.divisionlabel = new System.Windows.Forms.Label();
            this.nb9label = new System.Windows.Forms.Label();
            this.nb8label = new System.Windows.Forms.Label();
            this.nb7label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.resultlable = new System.Windows.Forms.Label();
            this.clearlabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.totallabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pluslabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dotlabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nb0label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minuslabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.nb3label, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.nb2label, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nb1label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.multipliedlabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nb6label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nb5label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nb4abel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.divisionlabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.nb9label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nb8label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nb7label, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 173);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // totallabel
            // 
            this.totallabel.BackColor = System.Drawing.Color.LavenderBlush;
            this.totallabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totallabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(377, 299);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(118, 99);
            this.totallabel.TabIndex = 15;
            this.totallabel.Text = "=";
            this.totallabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totallabel.Click += new System.EventHandler(this.totallabel_Click);
            // 
            // pluslabel
            // 
            this.pluslabel.BackColor = System.Drawing.Color.AliceBlue;
            this.pluslabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluslabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluslabel.Location = new System.Drawing.Point(253, 299);
            this.pluslabel.Name = "pluslabel";
            this.pluslabel.Size = new System.Drawing.Size(116, 99);
            this.pluslabel.TabIndex = 14;
            this.pluslabel.Text = "+";
            this.pluslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pluslabel.Click += new System.EventHandler(this.pluslabel_Click);
            // 
            // dotlabel
            // 
            this.dotlabel.BackColor = System.Drawing.Color.SeaShell;
            this.dotlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotlabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotlabel.Location = new System.Drawing.Point(129, 299);
            this.dotlabel.Name = "dotlabel";
            this.dotlabel.Size = new System.Drawing.Size(116, 99);
            this.dotlabel.TabIndex = 13;
            this.dotlabel.Text = "·";
            this.dotlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dotlabel.Click += new System.EventHandler(this.dotlabel_Click);
            // 
            // nb0label
            // 
            this.nb0label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb0label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb0label.Location = new System.Drawing.Point(5, 299);
            this.nb0label.Name = "nb0label";
            this.nb0label.Size = new System.Drawing.Size(116, 99);
            this.nb0label.TabIndex = 12;
            this.nb0label.Text = "0";
            this.nb0label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb0label.Click += new System.EventHandler(this.nb0label_Click);
            // 
            // minuslabel
            // 
            this.minuslabel.BackColor = System.Drawing.Color.AliceBlue;
            this.minuslabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minuslabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuslabel.Location = new System.Drawing.Point(377, 200);
            this.minuslabel.Name = "minuslabel";
            this.minuslabel.Size = new System.Drawing.Size(118, 97);
            this.minuslabel.TabIndex = 11;
            this.minuslabel.Text = "–";
            this.minuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minuslabel.Click += new System.EventHandler(this.minuslabel_Click);
            // 
            // nb3label
            // 
            this.nb3label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb3label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb3label.Location = new System.Drawing.Point(253, 200);
            this.nb3label.Name = "nb3label";
            this.nb3label.Size = new System.Drawing.Size(116, 97);
            this.nb3label.TabIndex = 10;
            this.nb3label.Text = "3";
            this.nb3label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb3label.Click += new System.EventHandler(this.nb3label_Click);
            // 
            // nb2label
            // 
            this.nb2label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb2label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb2label.Location = new System.Drawing.Point(129, 200);
            this.nb2label.Name = "nb2label";
            this.nb2label.Size = new System.Drawing.Size(116, 97);
            this.nb2label.TabIndex = 9;
            this.nb2label.Text = "2";
            this.nb2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb2label.Click += new System.EventHandler(this.nb2label_Click);
            // 
            // nb1label
            // 
            this.nb1label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb1label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb1label.Location = new System.Drawing.Point(5, 200);
            this.nb1label.Name = "nb1label";
            this.nb1label.Size = new System.Drawing.Size(116, 97);
            this.nb1label.TabIndex = 8;
            this.nb1label.Text = "1";
            this.nb1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb1label.Click += new System.EventHandler(this.nb1label_Click);
            // 
            // multipliedlabel
            // 
            this.multipliedlabel.BackColor = System.Drawing.Color.AliceBlue;
            this.multipliedlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multipliedlabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multipliedlabel.Location = new System.Drawing.Point(377, 101);
            this.multipliedlabel.Name = "multipliedlabel";
            this.multipliedlabel.Size = new System.Drawing.Size(118, 97);
            this.multipliedlabel.TabIndex = 7;
            this.multipliedlabel.Text = "×";
            this.multipliedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.multipliedlabel.Click += new System.EventHandler(this.multipliedlabel_Click);
            // 
            // nb6label
            // 
            this.nb6label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb6label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb6label.Location = new System.Drawing.Point(253, 101);
            this.nb6label.Name = "nb6label";
            this.nb6label.Size = new System.Drawing.Size(116, 97);
            this.nb6label.TabIndex = 6;
            this.nb6label.Text = "6";
            this.nb6label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb6label.Click += new System.EventHandler(this.nb6label_Click);
            // 
            // nb5label
            // 
            this.nb5label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb5label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb5label.Location = new System.Drawing.Point(129, 101);
            this.nb5label.Name = "nb5label";
            this.nb5label.Size = new System.Drawing.Size(116, 97);
            this.nb5label.TabIndex = 5;
            this.nb5label.Text = "5";
            this.nb5label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb5label.Click += new System.EventHandler(this.nb5label_Click);
            // 
            // nb4abel
            // 
            this.nb4abel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb4abel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb4abel.Location = new System.Drawing.Point(5, 101);
            this.nb4abel.Name = "nb4abel";
            this.nb4abel.Size = new System.Drawing.Size(116, 97);
            this.nb4abel.TabIndex = 4;
            this.nb4abel.Text = "4";
            this.nb4abel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb4abel.Click += new System.EventHandler(this.nb4abel_Click);
            // 
            // divisionlabel
            // 
            this.divisionlabel.BackColor = System.Drawing.Color.AliceBlue;
            this.divisionlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionlabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionlabel.Location = new System.Drawing.Point(377, 2);
            this.divisionlabel.Name = "divisionlabel";
            this.divisionlabel.Size = new System.Drawing.Size(118, 97);
            this.divisionlabel.TabIndex = 3;
            this.divisionlabel.Text = "÷";
            this.divisionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.divisionlabel.Click += new System.EventHandler(this.divisionlabel_Click);
            // 
            // nb9label
            // 
            this.nb9label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb9label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb9label.Location = new System.Drawing.Point(253, 2);
            this.nb9label.Name = "nb9label";
            this.nb9label.Size = new System.Drawing.Size(116, 97);
            this.nb9label.TabIndex = 2;
            this.nb9label.Text = "9";
            this.nb9label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb9label.Click += new System.EventHandler(this.nb9label_Click);
            // 
            // nb8label
            // 
            this.nb8label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb8label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb8label.Location = new System.Drawing.Point(129, 2);
            this.nb8label.Name = "nb8label";
            this.nb8label.Size = new System.Drawing.Size(116, 97);
            this.nb8label.TabIndex = 1;
            this.nb8label.Text = "8";
            this.nb8label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb8label.Click += new System.EventHandler(this.nb8label_Click);
            // 
            // nb7label
            // 
            this.nb7label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nb7label.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb7label.Location = new System.Drawing.Point(5, 2);
            this.nb7label.Name = "nb7label";
            this.nb7label.Size = new System.Drawing.Size(116, 97);
            this.nb7label.TabIndex = 0;
            this.nb7label.Text = "7";
            this.nb7label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nb7label.Click += new System.EventHandler(this.nb7label_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.resultlable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // resultlable
            // 
            this.resultlable.BackColor = System.Drawing.Color.LavenderBlush;
            this.resultlable.Font = new System.Drawing.Font("AcadEref", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultlable.Location = new System.Drawing.Point(3, 0);
            this.resultlable.Name = "resultlable";
            this.resultlable.Size = new System.Drawing.Size(490, 98);
            this.resultlable.TabIndex = 0;
            this.resultlable.Text = "0";
            this.resultlable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clearlabel
            // 
            this.clearlabel.BackColor = System.Drawing.Color.LemonChiffon;
            this.clearlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clearlabel.Font = new System.Drawing.Font("AcadEref", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearlabel.Location = new System.Drawing.Point(372, 100);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(125, 75);
            this.clearlabel.TabIndex = 2;
            this.clearlabel.Text = "c";
            this.clearlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearlabel.Click += new System.EventHandler(this.clearlabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 608);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Calcuator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label pluslabel;
        private Label dotlabel;
        private Label nb0label;
        private Label nb3label;
        private Label nb2label;
        private Label nb1label;
        private Label nb6label;
        private Label nb5label;
        private Label nb4abel;
        private Label nb9label;
        private Label nb8label;
        private Label nb7label;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label resultlable;
        private Label totallabel;
        private Label minuslabel;
        private Label multipliedlabel;
        private Label divisionlabel;
        private Label clearlabel;
    }
}

