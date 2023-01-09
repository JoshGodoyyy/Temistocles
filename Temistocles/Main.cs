using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temistocles {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            versaoTxt.Text = Global.Versao; 
        }

        private void novoClienteBtn_Click(object sender, EventArgs e) {
            Form formOpenned = Application.OpenForms["CadastroCliente"];
            if(formOpenned == null) {
                formOpenned = new CadastroCliente();
                formOpenned.MdiParent = this;
                formOpenned.Show();
            }
        }
    }
}
