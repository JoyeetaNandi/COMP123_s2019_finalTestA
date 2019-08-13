using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*
 * Student Name: Joyeeta Nandi
 * Student ID: 300757798
 * Description: This is the Hero Generator Form
 */
namespace COMP123_s2019_finalTestA.Views
{
    public partial class HeroGenerator : COMP123_s2019_finalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex!= 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count -1 )
            {
                MainTabControl.SelectedIndex++;
            }
        }
    }
}
