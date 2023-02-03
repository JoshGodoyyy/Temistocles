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
    public partial class Mensagem : Form {
        public Mensagem() {
            InitializeComponent();
        }

        public DialogResult Resultado { get; set; }

        public static DialogResult Mostrar(string mensagem, string btnOk, string btnMais) {
            var msgBox = new Mensagem();
            msgBox.label1.Text = mensagem;
            msgBox.button1.Text = btnOk;
            msgBox.button2.Text = btnMais;
            msgBox.ShowDialog();
            return msgBox.Resultado;
        }
    }
}
