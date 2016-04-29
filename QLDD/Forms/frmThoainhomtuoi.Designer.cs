namespace KPBT.Forms
{
    partial class frmThoainhomtuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThoainhomtuoi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCapnhat = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.grcMain = new DevExpress.XtraGrid.GridControl();
            this.grvCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapnhat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapnhat.Location = new System.Drawing.Point(135, 357);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat.TabIndex = 4;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(243, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grcMain
            // 
            this.grcMain.Location = new System.Drawing.Point(12, 12);
            this.grcMain.MainView = this.grvCT;
            this.grcMain.Name = "grcMain";
            this.grcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnXoa});
            this.grcMain.Size = new System.Drawing.Size(428, 327);
            this.grcMain.TabIndex = 7;
            this.grcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCT});
            // 
            // grvCT
            // 
            this.grvCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNT,
            this.colTenNT,
            this.colTT,
            this.colSTT,
            this.colIDNT,
            this.colXoa});
            this.grvCT.GridControl = this.grcMain;
            this.grvCT.Name = "grvCT";
            this.grvCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvCT.OptionsView.ShowGroupPanel = false;
            this.grvCT.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvCT_InitNewRow);
            // 
            // colMaNT
            // 
            this.colMaNT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaNT.AppearanceCell.Options.UseFont = true;
            this.colMaNT.AppearanceCell.Options.UseTextOptions = true;
            this.colMaNT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colMaNT.AppearanceHeader.Options.UseFont = true;
            this.colMaNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaNT.Caption = "Mã nhóm tuổi";
            this.colMaNT.FieldName = "MaNT";
            this.colMaNT.MaxWidth = 100;
            this.colMaNT.Name = "colMaNT";
            this.colMaNT.Width = 100;
            // 
            // colTenNT
            // 
            this.colTenNT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenNT.AppearanceCell.Options.UseFont = true;
            this.colTenNT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenNT.AppearanceHeader.Options.UseFont = true;
            this.colTenNT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenNT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenNT.Caption = "Tên nhóm tuổi";
            this.colTenNT.FieldName = "TenNT";
            this.colTenNT.Name = "colTenNT";
            this.colTenNT.Visible = true;
            this.colTenNT.VisibleIndex = 2;
            this.colTenNT.Width = 242;
            // 
            // colTT
            // 
            this.colTT.Caption = "gridColumn1";
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.MaxWidth = 40;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 1;
            this.colSTT.Width = 40;
            // 
            // colIDNT
            // 
            this.colIDNT.Caption = "gridColumn1";
            this.colIDNT.FieldName = "IDNT";
            this.colIDNT.Name = "colIDNT";
            // 
            // colXoa
            // 
            this.colXoa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colXoa.AppearanceHeader.Options.UseFont = true;
            this.colXoa.Caption = "Xóa";
            this.colXoa.ColumnEdit = this.btnXoa;
            this.colXoa.MaxWidth = 30;
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 0;
            this.colXoa.Width = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoa_ButtonClick);
            // 
            // frmThoainhomtuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 392);
            this.Controls.Add(this.grcMain);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapnhat);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmThoainhomtuoi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm tuổi";
            this.Load += new System.EventHandler(this.frmThoainhomtuoi_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThoainhomtuoi_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnCapnhat;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevExpress.XtraGrid.GridControl grcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNT;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNT;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
    }
}