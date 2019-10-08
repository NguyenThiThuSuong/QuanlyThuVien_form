namespace QL_TV
{
    partial class QL_nhomnguoidung
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataset_QLTV = new QL_TV.dataset_QLTV();
            this.qLNDNHOMNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNDNHOMNDTableAdapter = new QL_TV.dataset_QLTVTableAdapters.QLNDNHOMNDTableAdapter();
            this.tableAdapterManager = new QL_TV.dataset_QLTVTableAdapters.TableAdapterManager();
            this.qLNDNHOMNDDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLNDNHOMNDDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataset_QLTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.qLNDNHOMNDDataGridView1);
            this.panelEx1.Controls.Add(this.qLNDNHOMNDDataGridView);
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1053, 682);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(445, 131);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(131, 96);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.Black;
            this.buttonX2.SymbolSize = 50F;
            this.buttonX2.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(445, 233);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(131, 88);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Black;
            this.buttonX1.SymbolSize = 50F;
            this.buttonX1.TabIndex = 2;
            // 
            // dataset_QLTV
            // 
            this.dataset_QLTV.DataSetName = "dataset_QLTV";
            this.dataset_QLTV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNDNHOMNDBindingSource
            // 
            this.qLNDNHOMNDBindingSource.DataMember = "QLNDNHOMND";
            this.qLNDNHOMNDBindingSource.DataSource = this.dataset_QLTV;
            // 
            // qLNDNHOMNDTableAdapter
            // 
            this.qLNDNHOMNDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BIENBAN_DGTableAdapter = null;
            this.tableAdapterManager.BIENBANSACHLOITableAdapter = null;
            this.tableAdapterManager.BIENLAITHUTIENTableAdapter = null;
            this.tableAdapterManager.BLTRATIENCOCTableAdapter = null;
            this.tableAdapterManager.CHITIETHOADONNHAPTableAdapter = null;
            this.tableAdapterManager.CHITIETMUONTRATableAdapter = null;
            this.tableAdapterManager.CHUCVUTableAdapter = null;
            this.tableAdapterManager.CTBIENBANTableAdapter = null;
            this.tableAdapterManager.CTBIENLAITHUTIENTableAdapter = null;
            this.tableAdapterManager.CTBLTRATIENCOCTableAdapter = null;
            this.tableAdapterManager.CTDATSACHTableAdapter = null;
            this.tableAdapterManager.CTLUONGTableAdapter = null;
            this.tableAdapterManager.CTSACHLOITableAdapter = null;
            this.tableAdapterManager.CTSACHTableAdapter = null;
            this.tableAdapterManager.CTTHONGKETableAdapter = null;
            this.tableAdapterManager.DANGNHAPTableAdapter = null;
            this.tableAdapterManager.DMMANHINHTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.DONDATSACHTableAdapter = null;
            this.tableAdapterManager.HOADONNHAPTableAdapter = null;
            this.tableAdapterManager.LICHSUDANGNHAPTableAdapter = null;
            this.tableAdapterManager.LOAISACHTableAdapter = null;
            this.tableAdapterManager.MUONTRASACHTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAXUATBANTableAdapter = null;
            this.tableAdapterManager.PHANTRAM_MUONSACHTableAdapter = null;
            this.tableAdapterManager.QLNDNHOMNDTableAdapter = this.qLNDNHOMNDTableAdapter;
            this.tableAdapterManager.QLNHOMNDTableAdapter = null;
            this.tableAdapterManager.QLPHANQUYENTableAdapter = null;
            this.tableAdapterManager.QUANLYNDTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.THETHUVIENTableAdapter = null;
            this.tableAdapterManager.THIETHAITableAdapter = null;
            this.tableAdapterManager.THONGKETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_TV.dataset_QLTVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qLNDNHOMNDDataGridView
            // 
            this.qLNDNHOMNDDataGridView.AutoGenerateColumns = false;
            this.qLNDNHOMNDDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qLNDNHOMNDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qLNDNHOMNDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qLNDNHOMNDDataGridView.DataSource = this.qLNDNHOMNDBindingSource;
            this.qLNDNHOMNDDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.qLNDNHOMNDDataGridView.Location = new System.Drawing.Point(0, 0);
            this.qLNDNHOMNDDataGridView.Name = "qLNDNHOMNDDataGridView";
            this.qLNDNHOMNDDataGridView.RowTemplate.Height = 24;
            this.qLNDNHOMNDDataGridView.Size = new System.Drawing.Size(439, 682);
            this.qLNDNHOMNDDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn1.HeaderText = "TENDN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "MANHOM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn3.HeaderText = "GHICHU";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // qLNDNHOMNDDataGridView1
            // 
            this.qLNDNHOMNDDataGridView1.AutoGenerateColumns = false;
            this.qLNDNHOMNDDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qLNDNHOMNDDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qLNDNHOMNDDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.qLNDNHOMNDDataGridView1.DataSource = this.qLNDNHOMNDBindingSource;
            this.qLNDNHOMNDDataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.qLNDNHOMNDDataGridView1.Location = new System.Drawing.Point(582, 0);
            this.qLNDNHOMNDDataGridView1.Name = "qLNDNHOMNDDataGridView1";
            this.qLNDNHOMNDDataGridView1.RowTemplate.Height = 24;
            this.qLNDNHOMNDDataGridView1.Size = new System.Drawing.Size(471, 682);
            this.qLNDNHOMNDDataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENDN";
            this.dataGridViewTextBoxColumn4.HeaderText = "TENDN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn5.HeaderText = "MANHOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn6.HeaderText = "GHICHU";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // QL_nhomnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 682);
            this.Controls.Add(this.panelEx1);
            this.Name = "QL_nhomnguoidung";
            this.Text = "QL_nhomnguoidung";
            this.Load += new System.EventHandler(this.QL_nhomnguoidung_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataset_QLTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNDNHOMNDDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private dataset_QLTV dataset_QLTV;
        private System.Windows.Forms.BindingSource qLNDNHOMNDBindingSource;
        private dataset_QLTVTableAdapters.QLNDNHOMNDTableAdapter qLNDNHOMNDTableAdapter;
        private dataset_QLTVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qLNDNHOMNDDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView qLNDNHOMNDDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}