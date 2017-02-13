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
   public partial class IndustryPersonalityTable : Form
   {
      public IndustryPersonalityTable()
      {
         InitializeComponent();
      }

      private void industryPersonalityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.industryPersonalityBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.videoGamesDBDataSet);

      }

      private void IndustryPersonalityTable_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'videoGamesDBDataSet.IndustryPersonality' table. You can move, or remove it, as needed.
         this.industryPersonalityTableAdapter.Fill(this.videoGamesDBDataSet.IndustryPersonality);

      }
   }
}
