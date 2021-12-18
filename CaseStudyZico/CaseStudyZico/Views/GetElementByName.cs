using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaseStudyZico.DAL;

namespace CaseStudyZico.Views
{
    public partial class GetElementByName : Form
    {
        private AtomApiRepository atomApiRepository;
        private string ElementName;
        public GetElementByName()
        {
            InitializeComponent();
            atomApiRepository = new AtomApiRepository();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ElementName = nametxt.Text;
            atomApiRepository.GetAtomByName(ElementName);
            //label1.Text = atomJsonField.name;
            dataGridView1.DataSource = atomApiRepository.GetAtomByName(ElementName);
        }





        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
        }

        private void GetElementByName_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
