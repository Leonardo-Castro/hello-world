namespace Brain
{
   partial class GameTable
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameTable));
         this.videoGamesDBDataSet = new Brain.VideoGamesDBDataSet();
         this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.gameTableAdapter = new Brain.VideoGamesDBDataSetTableAdapters.GameTableAdapter();
         this.tableAdapterManager = new Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager();
         this.gameBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
         this.gameBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
         this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.gameDataGridView = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gameBindingNavigator)).BeginInit();
         this.gameBindingNavigator.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // videoGamesDBDataSet
         // 
         this.videoGamesDBDataSet.DataSetName = "VideoGamesDBDataSet";
         this.videoGamesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // gameBindingSource
         // 
         this.gameBindingSource.DataMember = "Game";
         this.gameBindingSource.DataSource = this.videoGamesDBDataSet;
         // 
         // gameTableAdapter
         // 
         this.gameTableAdapter.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.CompanyTableAdapter = null;
         this.tableAdapterManager.ConsoleTableAdapter = null;
         this.tableAdapterManager.GameTableAdapter = this.gameTableAdapter;
         this.tableAdapterManager.IndustryPersonalityTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = Brain.VideoGamesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         // 
         // gameBindingNavigator
         // 
         this.gameBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
         this.gameBindingNavigator.BindingSource = this.gameBindingSource;
         this.gameBindingNavigator.CountItem = this.bindingNavigatorCountItem;
         this.gameBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
         this.gameBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
         this.gameBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.gameBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gameBindingNavigatorSaveItem});
         this.gameBindingNavigator.Location = new System.Drawing.Point(272, 97);
         this.gameBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
         this.gameBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
         this.gameBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
         this.gameBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
         this.gameBindingNavigator.Name = "gameBindingNavigator";
         this.gameBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
         this.gameBindingNavigator.Size = new System.Drawing.Size(295, 27);
         this.gameBindingNavigator.TabIndex = 0;
         this.gameBindingNavigator.Text = "bindingNavigator1";
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
         // gameBindingNavigatorSaveItem
         // 
         this.gameBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
         this.gameBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gameBindingNavigatorSaveItem.Image")));
         this.gameBindingNavigatorSaveItem.Name = "gameBindingNavigatorSaveItem";
         this.gameBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
         this.gameBindingNavigatorSaveItem.Text = "Save Data";
         this.gameBindingNavigatorSaveItem.Click += new System.EventHandler(this.gameBindingNavigatorSaveItem_Click);
         // 
         // ID
         // 
         this.ID.DataPropertyName = "ID";
         this.ID.HeaderText = "ID";
         this.ID.Name = "ID";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "Game Name";
         this.dataGridViewTextBoxColumn4.HeaderText = "Game Name";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.DataPropertyName = "Console";
         this.dataGridViewTextBoxColumn5.HeaderText = "Console";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "Genre";
         this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn6
         // 
         this.dataGridViewTextBoxColumn6.DataPropertyName = "ESRB Rating";
         this.dataGridViewTextBoxColumn6.HeaderText = "ESRB Rating";
         this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "ConsoleID";
         this.dataGridViewTextBoxColumn2.HeaderText = "ConsoleID";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         // 
         // gameDataGridView
         // 
         this.gameDataGridView.AutoGenerateColumns = false;
         this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7});
         this.gameDataGridView.DataSource = this.gameBindingSource;
         this.gameDataGridView.Location = new System.Drawing.Point(22, 142);
         this.gameDataGridView.Name = "gameDataGridView";
         this.gameDataGridView.RowTemplate.Height = 24;
         this.gameDataGridView.Size = new System.Drawing.Size(855, 220);
         this.gameDataGridView.TabIndex = 1;
         // 
         // dataGridViewTextBoxColumn12
         // 
         this.dataGridViewTextBoxColumn12.DataPropertyName = "ID";
         this.dataGridViewTextBoxColumn12.HeaderText = "ID";
         this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
         // 
         // dataGridViewTextBoxColumn9
         // 
         this.dataGridViewTextBoxColumn9.DataPropertyName = "Game Name";
         this.dataGridViewTextBoxColumn9.HeaderText = "Game Name";
         this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
         // 
         // dataGridViewTextBoxColumn10
         // 
         this.dataGridViewTextBoxColumn10.DataPropertyName = "Console";
         this.dataGridViewTextBoxColumn10.HeaderText = "Console";
         this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
         // 
         // dataGridViewTextBoxColumn8
         // 
         this.dataGridViewTextBoxColumn8.DataPropertyName = "Genre";
         this.dataGridViewTextBoxColumn8.HeaderText = "Genre";
         this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
         // 
         // dataGridViewTextBoxColumn11
         // 
         this.dataGridViewTextBoxColumn11.DataPropertyName = "ESRB Rating";
         this.dataGridViewTextBoxColumn11.HeaderText = "ESRB Rating";
         this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
         // 
         // dataGridViewCheckBoxColumn1
         // 
         this.dataGridViewCheckBoxColumn1.DataPropertyName = "Played it?";
         this.dataGridViewCheckBoxColumn1.HeaderText = "Played it?";
         this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
         // 
         // dataGridViewTextBoxColumn7
         // 
         this.dataGridViewTextBoxColumn7.DataPropertyName = "ConsoleID";
         this.dataGridViewTextBoxColumn7.HeaderText = "ConsoleID";
         this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
         // 
         // GameTable
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Pink;
         this.ClientSize = new System.Drawing.Size(895, 374);
         this.Controls.Add(this.gameDataGridView);
         this.Controls.Add(this.gameBindingNavigator);
         this.Name = "GameTable";
         this.Text = "GameTable";
         this.Load += new System.EventHandler(this.GameTable_Load);
         ((System.ComponentModel.ISupportInitialize)(this.videoGamesDBDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gameBindingNavigator)).EndInit();
         this.gameBindingNavigator.ResumeLayout(false);
         this.gameBindingNavigator.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private VideoGamesDBDataSet videoGamesDBDataSet;
      private System.Windows.Forms.BindingSource gameBindingSource;
      private VideoGamesDBDataSetTableAdapters.GameTableAdapter gameTableAdapter;
      private VideoGamesDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private System.Windows.Forms.BindingNavigator gameBindingNavigator;
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
      private System.Windows.Forms.ToolStripButton gameBindingNavigatorSaveItem;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn ID;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridView gameDataGridView;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
      private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
   }
}