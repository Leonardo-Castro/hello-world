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
   public partial class ConsoleTable : Form
   {
      public ConsoleTable()
      {
         InitializeComponent();
      }

      private void consoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.consoleBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.videoGamesDBDataSet);

      }

      private void ConsoleTable_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'videoGamesDBDataSet.Console' table. You can move, or remove it, as needed.
         this.consoleTableAdapter.Fill(this.videoGamesDBDataSet.Console);

      }
   }
}
