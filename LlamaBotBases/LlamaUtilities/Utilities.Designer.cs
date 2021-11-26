﻿
namespace LlamaBotBases.LlamaUtilities
{
    partial class Utilities
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnHuntStart = new System.Windows.Forms.Button();
            this.pgHunts = new System.Windows.Forms.PropertyGrid();
            this.tabMateria = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveMateria = new System.Windows.Forms.Button();
            this.materiaListBox = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.itemCb = new System.Windows.Forms.ComboBox();
            this.bindingSourceInventory = new System.Windows.Forms.BindingSource(this.components);
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnCoffers = new System.Windows.Forms.Button();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.tabGC = new System.Windows.Forms.TabPage();
            this.tabHousing = new System.Windows.Forms.TabPage();
            this.pgCustomDeliveries = new System.Windows.Forms.PropertyGrid();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnCustomDeliveries = new System.Windows.Forms.Button();
            this.btnGcTurin = new System.Windows.Forms.Button();
            this.btnHousing = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabMateria.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInventory)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.tabCustom.SuspendLayout();
            this.tabGC.SuspendLayout();
            this.tabHousing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabMateria);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabCustom);
            this.tabControl1.Controls.Add(this.tabGC);
            this.tabControl1.Controls.Add(this.tabHousing);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnHuntStart);
            this.tabPage1.Controls.Add(this.pgHunts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daily Hunts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnHuntStart
            // 
            this.btnHuntStart.Location = new System.Drawing.Point(265, 321);
            this.btnHuntStart.Name = "btnHuntStart";
            this.btnHuntStart.Size = new System.Drawing.Size(95, 25);
            this.btnHuntStart.TabIndex = 1;
            this.btnHuntStart.Text = "Start";
            this.btnHuntStart.UseVisualStyleBackColor = true;
            this.btnHuntStart.Click += new System.EventHandler(this.btnHuntStart_Click);
            // 
            // pgHunts
            // 
            this.pgHunts.Location = new System.Drawing.Point(9, 12);
            this.pgHunts.Name = "pgHunts";
            this.pgHunts.Size = new System.Drawing.Size(352, 238);
            this.pgHunts.TabIndex = 0;
            // 
            // tabMateria
            // 
            this.tabMateria.Controls.Add(this.groupBox1);
            this.tabMateria.Location = new System.Drawing.Point(4, 22);
            this.tabMateria.Name = "tabMateria";
            this.tabMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateria.Size = new System.Drawing.Size(379, 359);
            this.tabMateria.TabIndex = 1;
            this.tabMateria.Text = "Materia";
            this.tabMateria.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveMateria);
            this.groupBox1.Controls.Add(this.materiaListBox);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.itemCb);
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Materia";
            // 
            // btnRemoveMateria
            // 
            this.btnRemoveMateria.Location = new System.Drawing.Point(9, 185);
            this.btnRemoveMateria.Name = "btnRemoveMateria";
            this.btnRemoveMateria.Size = new System.Drawing.Size(142, 25);
            this.btnRemoveMateria.TabIndex = 3;
            this.btnRemoveMateria.Text = "Remove All Materia";
            this.btnRemoveMateria.UseVisualStyleBackColor = true;
            this.btnRemoveMateria.Click += new System.EventHandler(this.btnRemoveMateria_Click);
            // 
            // materiaListBox
            // 
            this.materiaListBox.FormattingEnabled = true;
            this.materiaListBox.Location = new System.Drawing.Point(9, 45);
            this.materiaListBox.Name = "materiaListBox";
            this.materiaListBox.Size = new System.Drawing.Size(297, 134);
            this.materiaListBox.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(229, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 21);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // itemCb
            // 
            this.itemCb.FormattingEnabled = true;
            this.itemCb.Location = new System.Drawing.Point(9, 17);
            this.itemCb.Name = "itemCb";
            this.itemCb.Size = new System.Drawing.Size(209, 21);
            this.itemCb.TabIndex = 0;
            // 
            // bindingSourceInventory
            // 
            this.bindingSourceInventory.CurrentChanged += new System.EventHandler(this.bindingSourceInventory_CurrentChanged);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.btnCoffers);
            this.tabInventory.Controls.Add(this.btnExtract);
            this.tabInventory.Controls.Add(this.btnReduce);
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(379, 359);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(3, 14);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(122, 24);
            this.btnReduce.TabIndex = 0;
            this.btnReduce.Text = "Reduce All";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(3, 44);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(122, 24);
            this.btnExtract.TabIndex = 1;
            this.btnExtract.Text = "Extract Materia";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnCoffers
            // 
            this.btnCoffers.Location = new System.Drawing.Point(3, 74);
            this.btnCoffers.Name = "btnCoffers";
            this.btnCoffers.Size = new System.Drawing.Size(122, 24);
            this.btnCoffers.TabIndex = 2;
            this.btnCoffers.Text = "Open All Coffers";
            this.btnCoffers.UseVisualStyleBackColor = true;
            this.btnCoffers.Click += new System.EventHandler(this.btnCoffers_Click);
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.btnCustomDeliveries);
            this.tabCustom.Controls.Add(this.pgCustomDeliveries);
            this.tabCustom.Location = new System.Drawing.Point(4, 22);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Size = new System.Drawing.Size(379, 359);
            this.tabCustom.TabIndex = 3;
            this.tabCustom.Text = "Custom Deliveries";
            this.tabCustom.UseVisualStyleBackColor = true;
            // 
            // tabGC
            // 
            this.tabGC.Controls.Add(this.btnGcTurin);
            this.tabGC.Controls.Add(this.propertyGrid1);
            this.tabGC.Location = new System.Drawing.Point(4, 22);
            this.tabGC.Name = "tabGC";
            this.tabGC.Size = new System.Drawing.Size(379, 359);
            this.tabGC.TabIndex = 4;
            this.tabGC.Text = "Gc Turnin";
            this.tabGC.UseVisualStyleBackColor = true;
            // 
            // tabHousing
            // 
            this.tabHousing.Controls.Add(this.btnHousing);
            this.tabHousing.Location = new System.Drawing.Point(4, 22);
            this.tabHousing.Name = "tabHousing";
            this.tabHousing.Padding = new System.Windows.Forms.Padding(3);
            this.tabHousing.Size = new System.Drawing.Size(379, 359);
            this.tabHousing.TabIndex = 5;
            this.tabHousing.Text = "Housing";
            this.tabHousing.UseVisualStyleBackColor = true;
            // 
            // pgCustomDeliveries
            // 
            this.pgCustomDeliveries.Location = new System.Drawing.Point(3, 3);
            this.pgCustomDeliveries.Name = "pgCustomDeliveries";
            this.pgCustomDeliveries.Size = new System.Drawing.Size(373, 220);
            this.pgCustomDeliveries.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(373, 219);
            this.propertyGrid1.TabIndex = 0;
            // 
            // btnCustomDeliveries
            // 
            this.btnCustomDeliveries.Location = new System.Drawing.Point(296, 328);
            this.btnCustomDeliveries.Name = "btnCustomDeliveries";
            this.btnCustomDeliveries.Size = new System.Drawing.Size(75, 23);
            this.btnCustomDeliveries.TabIndex = 1;
            this.btnCustomDeliveries.Text = "Start";
            this.btnCustomDeliveries.UseVisualStyleBackColor = true;
            this.btnCustomDeliveries.Click += new System.EventHandler(this.btnCustomDeliveries_Click);
            // 
            // btnGcTurin
            // 
            this.btnGcTurin.Location = new System.Drawing.Point(288, 328);
            this.btnGcTurin.Name = "btnGcTurin";
            this.btnGcTurin.Size = new System.Drawing.Size(88, 23);
            this.btnGcTurin.TabIndex = 1;
            this.btnGcTurin.Text = "Start";
            this.btnGcTurin.UseVisualStyleBackColor = true;
            this.btnGcTurin.Click += new System.EventHandler(this.btnGcTurin_Click);
            // 
            // btnHousing
            // 
            this.btnHousing.Location = new System.Drawing.Point(276, 307);
            this.btnHousing.Name = "btnHousing";
            this.btnHousing.Size = new System.Drawing.Size(95, 23);
            this.btnHousing.TabIndex = 0;
            this.btnHousing.Text = "Start";
            this.btnHousing.UseVisualStyleBackColor = true;
            this.btnHousing.Click += new System.EventHandler(this.btnHousing_Click);
            // 
            // Utilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "Utilities";
            this.Text = "Utilities";
            this.Load += new System.EventHandler(this.Utilities_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabMateria.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInventory)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabCustom.ResumeLayout(false);
            this.tabGC.ResumeLayout(false);
            this.tabHousing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PropertyGrid pgHunts;
        private System.Windows.Forms.Button btnHuntStart;

        private System.Windows.Forms.BindingSource bindingSourceInventory;

        private System.Windows.Forms.BindingSource bindingSource1;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox itemCb;
        private System.Windows.Forms.ListBox materiaListBox;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemoveMateria;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnCoffers;
        private System.Windows.Forms.TabPage tabCustom;
        private System.Windows.Forms.TabPage tabGC;
        private System.Windows.Forms.TabPage tabHousing;
        private System.Windows.Forms.PropertyGrid pgCustomDeliveries;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnCustomDeliveries;
        private System.Windows.Forms.Button btnGcTurin;
        private System.Windows.Forms.Button btnHousing;
    }
}