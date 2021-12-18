using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaseStudyZico.DAL;
using CaseStudyZico.Models;
using System.Windows.Forms;
using System.Net.Http;

namespace CaseStudyZico.Views
{
    public partial class GetElementByNumber : Form
    {
        private AtomApiRepository atomApiRepository;
        private int ElementNumber;
        public GetElementByNumber()
        {
            InitializeComponent();

            atomApiRepository = new AtomApiRepository();



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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ElementNumber = Int32.Parse(numbertxt.Text);
            atomApiRepository.GetAtomByNumber(ElementNumber);
            //label1.Text = atomJsonField.name;
            dataGridView1.DataSource = atomApiRepository.GetAtomByNumber(ElementNumber);
            

        }

        private void GetElementByNumber_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
