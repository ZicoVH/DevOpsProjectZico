using System;
using CaseStudyZico.DAL;
using CaseStudyZico.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudyZico
{
    public partial class PractiseElement : Form
    {

        private AtomRepository atomRepository;
        private AtomApiRepository _atomApiRepository;
        private SortedSet<AddElement> addElements;

        public PractiseElement()
        {
            InitializeComponent();

            atomRepository = new AtomRepository();
            addElements = new SortedSet<AddElement>(atomRepository.GetSearchHistory());

            //_atomApiRepository = new AtomApiRepository();
            foreach (AddElement addElement in addElements)
            {
                string name = addElement.ElementName;
                listBox1.Items.Add(name);
            }
        }
       


        private void btnAddElement_Click(object sender, EventArgs e)
        {
            string ElementName = InsertDatatxt.Text;
            AddElement addElement = new AddElement { ElementName = ElementName };
            addElements.Add(addElement);
            atomRepository.InsertName(addElement);
            listBox1.Items.Add(ElementName);
        }

        private void btnDelElement_Click(object sender, EventArgs e)
        {
            string ElementName = InsertDatatxt.Text;
            addElements.RemoveWhere(x => x.ElementName == ElementName);
            atomRepository.DeleteElement(ElementName);
            listBox1.Items.Remove(ElementName);
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

        private void PractiseElement_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            atomRepository.ClearAll();
            listBox1.Items.Clear();
        }
    }
}
