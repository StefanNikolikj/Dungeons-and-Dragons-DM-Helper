using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons_and_Dragons_DM_Helper
{
    public partial class SetInitiative : Form
    {
        public int initiative {  get; set; }
        public SetInitiative()
        {
            InitializeComponent();
        }

        private void btnSetInitiative_Click(object sender, EventArgs e)
        {
            this.initiative = (int)numInitiative.Value;

            this.DialogResult = DialogResult.OK;
        }
    }
}
