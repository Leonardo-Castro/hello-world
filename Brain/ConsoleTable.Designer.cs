namespace Brain
{
   partial class ConsoleTable
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleTable));
         this.videoGamesDBDataSet = new Brain.VideoGamesDBDataSet();
         this.consoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.consoleTableAdapter = new Brain.VideoGamesDBDataSetTableAdapters.ConsoleTableAdapter();
         this.tableAdapterManager = new Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager();
         this.consoleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.consoleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.consoleDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.consoleBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.consoleBindingNavigator)).BeginInit();
         this.consoleBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.consoleDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // videoGamesDBDataSet
         // 
         this.videoGamesDBDataSet.DataSetName = "VideoGamesDBDataSet";
         this.videoGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // consoleBindingSource
         // 
         this.consoleBindingSource.DataMember = "Console";
         this.consoleBindingSource.DataSource = this.videoGamesDBDataSet;
         // 
         // consoleTableAdapter
         // 
         this.consoleTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.CompanyTableAdapter = null;
         this.tableAdapterManager.ConsoleTableAdapter = this.consoleTableAdapter;
         this.tableAdapterManager.GameTableAdapter = null;
         this.tableAdapterManager.IndustryPersonalityTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // consoleBindingNavigator
         // 
         this.consoleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.consoleBindingNavigator.BindingSource = this.consoleBindingSource;
         this.consoleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.consoleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.consoleBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
         this.consoleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.consoleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consoleBindingNavigatorSaveItem});
         this.consoleBindingNavigator.Location = new System.Drawing.Point(216, 53);
         this.consoleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.consoleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.consoleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.consoleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.consoleBindingNavigator.Name = "consoleBindingNavigator";
         this.consoleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.consoleBindingNavigator.Size = new System.Drawing.Size(334, 27);
         this.consoleBindingNavigator.TabIndex = 0;
         this.consoleBindingNavigator.Text = "bindingNavigator1";
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
         // consoleBindingNavigatorSaveItem
         // 
         this.consoleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.consoleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleBindingNavigatorSaveItem.Image")));
         this.consoleBindingNavigatorSaveItem.Name = "consoleBindingNavigatorSaveItem";
         this.consoleBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
         this.consoleBindingNavigatorSaveItem.Text = "Save Data";
         this.consoleBindingNavigatorSaveItem.Click += new System.EventHandler(this.consoleBindingNavigatorSaveItem_Click);
         // 
         // consoleDataGridView
         // 
         this.consoleDataGridView.AutoGenerateColumns = false;
         this.consoleDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
         this.consoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.consoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.consoleDataGridView.DataSource = this.consoleBindingSource;
         this.consoleDataGridView.Location = new System.Drawing.Point(12, 93);
         this.consoleDataGridView.Name = "consoleDataGridView";
         this.consoleDataGridView.RowTemplate.Height = 24;
         this.consoleDataGridView.Size = new System.Drawing.Size(754, 220);
         this.consoleDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "ConsoleID";
         this.dataGridViewTextBoxColumn1.HeaderText = "ConsoleID";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.DataPropertyName = "Console Name";
         this.dataGridViewTextBoxColumn5.HeaderText = "Console Name";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "Developer";
         this.dataGridViewTextBoxColumn2.HeaderText = "Developer";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Release Year";
         this.dataGridViewTextBoxColumn3.HeaderText = "Release Year";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "CompanyID";
         this.dataGridViewTextBoxColumn4.HeaderText = "CompanyID";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // ConsoleTable
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Yellow;
         this.ClientSize = new System.Drawing.Size(778, 333);
         this.Controls.Add(this.consoleDataGridView);
         this.Controls.Add(this.consoleBindingNavigator);
         this.Name = "ConsoleTable";
         this.Text = "ConsoleTable";
         this.Load += new System.EventHandler(this.ConsoleTable_Load);
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.consoleBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.consoleBindingNavigator)).EndInit();
         this.consoleBindingNavigator.ResumeLayout(false);
         this.consoleBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.consoleDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private VideoGamesDBDataSet videoGamesDBDataSet;
      private System.Windows.Forms.BindingSource consoleBindingSource;
      private VideoGamesDBDataSetTableAdapters.ConsoleTableAdapter consoleTableAdapter;
      private VideoGamesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator consoleBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton consoleBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridView consoleDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
   }
}