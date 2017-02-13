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
   public partial class CompanyTable : Form
   {
      public CompanyTable()
      {
         InitializeComponent();
      }

      private void companyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
      {
         this.Validate();
         this.companyBindingSource.EndEdit();
         this.tableAdapterManager.UpdateAll(this.videoGamesDBDataSet);

      }

      private void CompanyDbUi_Load(object sender, EventArgs e)
      {
         // TODO: This line of code loads data into the 'videoGamesDBDataSet.Company' table. You can move, or remove it, as needed.
         this.companyTableAdapter.Fill(this.videoGamesDBDataSet.Company);

      }
   }
}
