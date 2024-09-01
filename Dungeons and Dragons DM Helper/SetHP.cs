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
    public partial class SetHP : Form
    {
        public int hp {  get; set; }
        int maxHp { get; set; }
        public SetHP(int hp, int maxHp)
        {
            InitializeComponent();
            this.hp = hp;
        }

        private void SetHP_Load(object sender, EventArgs e)
        {
            numHP.Value = Convert.ToDecimal(hp); 
        }

        private void btnSetHP_Click(object sender, EventArgs e)
        {
            this.hp = Convert.ToInt32(numHP.Value);

            this.DialogResult = DialogResult.OK;
        }
    }
}
