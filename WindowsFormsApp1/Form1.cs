using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tabpageCADASTRAR : Form
    {
        public tabpageCADASTRAR()
        {
            InitializeComponent();
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            if (radioButtonmasculino.Checked)
            {
                if (checkBoxCASADO.Checked)
                {
                    MessageBox.Show(comboBoxESTADO.Text + "\ngenero masculino" + "\ncasado");
                }
                if (checkBoxSOLTEIRO.Checked)
                {
                    MessageBox.Show(comboBoxESTADO.Text + "\ngenero masculino" + "\nsolteiro");
                }
                if (checkBoxVIUVO.Checked)
                {
                    MessageBox.Show(comboBoxESTADO.Text + "\ngenero masculino" + "\nviuvo");
                }
            }
            if (radioButtonfeminino.Checked)
            {
                if (checkBoxCASADO.Checked)
                {
                    MessageBox.Show(comboBoxESTADO.Text + "\ngenero feminino" + "\ncasado");
                }
                if (checkBoxSOLTEIRO.Checked)
                {
                    MessageBox.Show(comboBoxESTADO.Text + "\ngenero feminino" + "\nsolteiro");
                }
                if (checkBoxVIUVO.Checked)
                {
                    MessageBox.Show(comboBoxESTADO.Text + "\ngenero feminino" + "\nviuvo");
                }
            }
        }

        private void checkBoxCASADO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCASADO.Checked)
            {
                checkBoxSOLTEIRO.Checked = false;
                checkBoxVIUVO.Checked = false;
            }
            
        }

        private void checkBoxSOLTEIRO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSOLTEIRO.Checked)
            {
                checkBoxCASADO.Checked = false;
                checkBoxVIUVO.Checked = false;
            }
        }

        private void checkBoxVIUVO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVIUVO.Checked)
            {
                checkBoxSOLTEIRO.Checked = false;
                checkBoxCASADO.Checked = false;
            }
        }
    }
}
