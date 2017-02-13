using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brain
{
   public partial class GameTable : Form
   {
      public GameTable()
      {
         InitializeComponent();
      }

      private void gameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.gameBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.videoGamesDBDataSet);

      }

      private void GameTable_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'videoGamesDBDataSet.Game' table. You can move, or remove it, as needed.
         this.gameTableAdapter.Fill(this.videoGamesDBDataSet.Game);

      }
   }
}
