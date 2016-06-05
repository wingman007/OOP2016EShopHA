namespace MiniAdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aspNetUsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aspNetUsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aspNetUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aspNetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._aspnet_EShopHA_20160524043511DataSet = new MiniAdminPanel._aspnet_EShopHA_20160524043511DataSet();
            this.aspNetUsersTableAdapter = new MiniAdminPanel._aspnet_EShopHA_20160524043511DataSetTableAdapters.AspNetUsersTableAdapter();
            this.tableAdapterManager = new MiniAdminPanel._aspnet_EShopHA_20160524043511DataSetTableAdapters.TableAdapterManager();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingNavigator)).BeginInit();
            this.aspNetUsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._aspnet_EShopHA_20160524043511DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // aspNetUsersBindingNavigator
            // 
            this.aspNetUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aspNetUsersBindingNavigator.BindingSource = this.aspNetUsersBindingSource;
            this.aspNetUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aspNetUsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aspNetUsersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aspNetUsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aspNetUsersBindingNavigatorSaveItem});
            this.aspNetUsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aspNetUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aspNetUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aspNetUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aspNetUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aspNetUsersBindingNavigator.Name = "aspNetUsersBindingNavigator";
            this.aspNetUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aspNetUsersBindingNavigator.Size = new System.Drawing.Size(946, 27);
            this.aspNetUsersBindingNavigator.TabIndex = 0;
            this.aspNetUsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // aspNetUsersBindingNavigatorSaveItem
            // 
            this.aspNetUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aspNetUsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aspNetUsersBindingNavigatorSaveItem.Image")));
            this.aspNetUsersBindingNavigatorSaveItem.Name = "aspNetUsersBindingNavigatorSaveItem";
            this.aspNetUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.aspNetUsersBindingNavigatorSaveItem.Text = "Save Data";
            this.aspNetUsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.aspNetUsersBindingNavigatorSaveItem_Click);
            // 
            // aspNetUsersDataGridView
            // 
            this.aspNetUsersDataGridView.AutoGenerateColumns = false;
            this.aspNetUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aspNetUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aspNetUsersDataGridView.DataSource = this.aspNetUsersBindingSource;
            this.aspNetUsersDataGridView.Location = new System.Drawing.Point(53, 60);
            this.aspNetUsersDataGridView.Name = "aspNetUsersDataGridView";
            this.aspNetUsersDataGridView.RowTemplate.Height = 24;
            this.aspNetUsersDataGridView.Size = new System.Drawing.Size(575, 220);
            this.aspNetUsersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PasswordHash";
            this.dataGridViewTextBoxColumn3.HeaderText = "PasswordHash";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SecurityStamp";
            this.dataGridViewTextBoxColumn4.HeaderText = "SecurityStamp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discriminator";
            this.dataGridViewTextBoxColumn5.HeaderText = "Discriminator";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // aspNetUsersBindingSource
            // 
            this.aspNetUsersBindingSource.DataMember = "AspNetUsers";
            this.aspNetUsersBindingSource.DataSource = this._aspnet_EShopHA_20160524043511DataSet;
            // 
            // _aspnet_EShopHA_20160524043511DataSet
            // 
            this._aspnet_EShopHA_20160524043511DataSet.DataSetName = "_aspnet_EShopHA_20160524043511DataSet";
            this._aspnet_EShopHA_20160524043511DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aspNetUsersTableAdapter
            // 
            this.aspNetUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AspNetRolesTableAdapter = null;
            this.tableAdapterManager.AspNetUserClaimsTableAdapter = null;
            this.tableAdapterManager.AspNetUserLoginsTableAdapter = null;
            this.tableAdapterManager.AspNetUserRolesTableAdapter = null;
            this.tableAdapterManager.AspNetUsersTableAdapter = this.aspNetUsersTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MiniAdminPanel._aspnet_EShopHA_20160524043511DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(691, 72);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(196, 61);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Products";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 470);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.aspNetUsersDataGridView);
            this.Controls.Add(this.aspNetUsersBindingNavigator);
            this.Name = "Form1";
            this.Text = "MiniAdminPanel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingNavigator)).EndInit();
            this.aspNetUsersBindingNavigator.ResumeLayout(false);
            this.aspNetUsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspNetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._aspnet_EShopHA_20160524043511DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _aspnet_EShopHA_20160524043511DataSet _aspnet_EShopHA_20160524043511DataSet;
        private System.Windows.Forms.BindingSource aspNetUsersBindingSource;
        private _aspnet_EShopHA_20160524043511DataSetTableAdapters.AspNetUsersTableAdapter aspNetUsersTableAdapter;
        private _aspnet_EShopHA_20160524043511DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aspNetUsersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aspNetUsersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView aspNetUsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnEdit;
    }
}

