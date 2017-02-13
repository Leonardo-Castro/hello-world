namespace Brain
{
   partial class CompanyTable
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyTable));
         this.companyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
         this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
         this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.videoGamesDBDataSet = new Brain.VideoGamesDBDataSet();
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
         this.companyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.companyDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.companyTableAdapter = new Brain.VideoGamesDBDataSetTableAdapters.CompanyTableAdapter();
         this.tableAdapterManager = new Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager();
         ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).BeginInit();
         this.companyBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // companyBindingNavigator
         // 
         this.companyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.companyBindingNavigator.BindingSource = this.companyBindingSource;
         this.companyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.companyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.companyBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
         this.companyBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.companyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.companyBindingNavigatorSaveItem});
         this.companyBindingNavigator.Location = new System.Drawing.Point(207, 34);
         this.companyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.companyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.companyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.companyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.companyBindingNavigator.Name = "companyBindingNavigator";
         this.companyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.companyBindingNavigator.Size = new System.Drawing.Size(295, 27);
         this.companyBindingNavigator.TabIndex = 0;
         this.companyBindingNavigator.Text = "bindingNavigator1";
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
         // companyBindingSource
         // 
         this.companyBindingSource.DataMember = "Company";
         this.companyBindingSource.DataSource = this.videoGamesDBDataSet;
         // 
         // videoGamesDBDataSet
         // 
         this.videoGamesDBDataSet.DataSetName = "VideoGamesDBDataSet";
         this.videoGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
         // companyBindingNavigatorSaveItem
         // 
         this.companyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.companyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companyBindingNavigatorSaveItem.Image")));
         this.companyBindingNavigatorSaveItem.Name = "companyBindingNavigatorSaveItem";
         this.companyBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
         this.companyBindingNavigatorSaveItem.Text = "Save Data";
         this.companyBindingNavigatorSaveItem.Click += new System.EventHandler(this.companyBindingNavigatorSaveItem_Click);
         // 
         // companyDataGridView
         // 
         this.companyDataGridView.AutoGenerateColumns = false;
         this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
         this.companyDataGridView.DataSource = this.companyBindingSource;
         this.companyDataGridView.Location = new System.Drawing.Point(36, 83);
         this.companyDataGridView.Name = "companyDataGridView";
         this.companyDataGridView.RowTemplate.Height = 24;
         this.companyDataGridView.Size = new System.Drawing.Size(673, 220);
         this.companyDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyID";
         this.dataGridViewTextBoxColumn1.HeaderText = "CompanyID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Company name";
         this.dataGridViewTextBoxColumn2.HeaderText = "Company name";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "President";
         this.dataGridViewTextBoxColumn3.HeaderText = "President";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "FoundingYear";
         this.dataGridViewTextBoxColumn4.HeaderText = "FoundingYear";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.DataPropertyName = "Publisher";
         this.dataGridViewTextBoxColumn5.HeaderText = "Publisher";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         // 
         // companyTableAdapter
         // 
         this.companyTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.CompanyTableAdapter = this.companyTableAdapter;
         this.tableAdapterManager.ConsoleTableAdapter = null;
         this.tableAdapterManager.GameTableAdapter = null;
         this.tableAdapterManager.IndustryPersonalityTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // CompanyTable
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.ClientSize = new System.Drawing.Size(743, 317);
         this.Controls.Add(this.companyDataGridView);
         this.Controls.Add(this.companyBindingNavigator);
         this.Name = "CompanyTable";
         this.Text = "Company Table";
         this.Load += new System.EventHandler(this.CompanyDbUi_Load);
         ((System.ComponentModel.ISupportInitialize)(this.companyBindingNavigator)).EndInit();
         this.companyBindingNavigator.ResumeLayout(false);
         this.companyBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private VideoGamesDBDataSet videoGamesDBDataSet;
      private System.Windows.Forms.BindingSource companyBindingSource;
      private VideoGamesDBDataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
      private VideoGamesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator companyBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton companyBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView companyDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
   }
}