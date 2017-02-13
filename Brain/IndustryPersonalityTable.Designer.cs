namespace Brain
{
   partial class IndustryPersonalityTable
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndustryPersonalityTable));
         this.videoGamesDBDataSet = new Brain.VideoGamesDBDataSet();
         this.industryPersonalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.industryPersonalityTableAdapter = new Brain.VideoGamesDBDataSetTableAdapters.IndustryPersonalityTableAdapter();
         this.tableAdapterManager = new Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager();
         this.industryPersonalityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.industryPersonalityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.industryPersonalityDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.industryPersonalityBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.industryPersonalityBindingNavigator)).BeginInit();
         this.industryPersonalityBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.industryPersonalityDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // videoGamesDBDataSet
         // 
         this.videoGamesDBDataSet.DataSetName = "VideoGamesDBDataSet";
         this.videoGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // industryPersonalityBindingSource
         // 
         this.industryPersonalityBindingSource.DataMember = "IndustryPersonality";
         this.industryPersonalityBindingSource.DataSource = this.videoGamesDBDataSet;
         // 
         // industryPersonalityTableAdapter
         // 
         this.industryPersonalityTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.CompanyTableAdapter = null;
         this.tableAdapterManager.ConsoleTableAdapter = null;
         this.tableAdapterManager.GameTableAdapter = null;
         this.tableAdapterManager.IndustryPersonalityTableAdapter = this.industryPersonalityTableAdapter;
         this.tableAdapterManager.UpdateOrder = Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // industryPersonalityBindingNavigator
         // 
         this.industryPersonalityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.industryPersonalityBindingNavigator.BindingSource = this.industryPersonalityBindingSource;
         this.industryPersonalityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.industryPersonalityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.industryPersonalityBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
         this.industryPersonalityBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.industryPersonalityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.industryPersonalityBindingNavigatorSaveItem});
         this.industryPersonalityBindingNavigator.Location = new System.Drawing.Point(191, 66);
         this.industryPersonalityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.industryPersonalityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.industryPersonalityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.industryPersonalityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.industryPersonalityBindingNavigator.Name = "industryPersonalityBindingNavigator";
         this.industryPersonalityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.industryPersonalityBindingNavigator.Size = new System.Drawing.Size(334, 27);
         this.industryPersonalityBindingNavigator.TabIndex = 0;
         this.industryPersonalityBindingNavigator.Text = "bindingNavigator1";
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
         // industryPersonalityBindingNavigatorSaveItem
         // 
         this.industryPersonalityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.industryPersonalityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("industryPersonalityBindingNavigatorSaveItem.Image")));
         this.industryPersonalityBindingNavigatorSaveItem.Name = "industryPersonalityBindingNavigatorSaveItem";
         this.industryPersonalityBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
         this.industryPersonalityBindingNavigatorSaveItem.Text = "Save Data";
         this.industryPersonalityBindingNavigatorSaveItem.Click += new System.EventHandler(this.industryPersonalityBindingNavigatorSaveItem_Click);
         // 
         // industryPersonalityDataGridView
         // 
         this.industryPersonalityDataGridView.AutoGenerateColumns = false;
         this.industryPersonalityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.industryPersonalityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
         this.industryPersonalityDataGridView.DataSource = this.industryPersonalityBindingSource;
         this.industryPersonalityDataGridView.Location = new System.Drawing.Point(12, 96);
         this.industryPersonalityDataGridView.Name = "industryPersonalityDataGridView";
         this.industryPersonalityDataGridView.RowTemplate.Height = 24;
         this.industryPersonalityDataGridView.Size = new System.Drawing.Size(731, 220);
         this.industryPersonalityDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
         this.dataGridViewTextBoxColumn1.HeaderText = "ID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
         this.dataGridViewTextBoxColumn2.HeaderText = "Name";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
         this.dataGridViewTextBoxColumn3.HeaderText = "Title";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "Known For";
         this.dataGridViewTextBoxColumn4.HeaderText = "Known For";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.DataPropertyName = "CompanyID";
         this.dataGridViewTextBoxColumn5.HeaderText = "CompanyID";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         // 
         // IndustryPersonalityTable
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.OrangeRed;
         this.ClientSize = new System.Drawing.Size(755, 336);
         this.Controls.Add(this.industryPersonalityDataGridView);
         this.Controls.Add(this.industryPersonalityBindingNavigator);
         this.Name = "IndustryPersonalityTable";
         this.Text = "IndustryPersonalityTable";
         this.Load += new System.EventHandler(this.IndustryPersonalityTable_Load);
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.industryPersonalityBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.industryPersonalityBindingNavigator)).EndInit();
         this.industryPersonalityBindingNavigator.ResumeLayout(false);
         this.industryPersonalityBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.industryPersonalityDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private VideoGamesDBDataSet videoGamesDBDataSet;
      private System.Windows.Forms.BindingSource industryPersonalityBindingSource;
      private VideoGamesDBDataSetTableAdapters.IndustryPersonalityTableAdapter industryPersonalityTableAdapter;
      private VideoGamesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator industryPersonalityBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton industryPersonalityBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView industryPersonalityDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
   }
}