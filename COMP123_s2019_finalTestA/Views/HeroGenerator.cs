using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using COMP123_s2019_finalTestA.Objects;
/*
 * Student Name: Joyeeta Nandi
 * Student ID: 300757798
 * Description: This is the Hero Generator Form
 */
namespace COMP123_s2019_finalTestA.Views
{
    public partial class HeroGenerator : COMP123_s2019_finalTestA.Views.MasterForm
    {
        List<string> SkillsList;
        Hero character;
        Random random = new Random();
        public HeroGenerator()
        {
            InitializeComponent();
            character = new Hero();
        }
        private void ReadFromFile(string filename, List<string> list)
        {
            using (TextReader textReader = new StreamReader(File.Open(filename, FileMode.Open)))
            {
                string input;
                while ((input = textReader.ReadLine()) != null)
                {
                    list.Add(input);
                }
                textReader.Close();
            }
        }
        private void loadSkills()
        {
            string fileName = "skills.txt";
            SkillsList = new List<string>();
            ReadFromFile(fileName, SkillsList);
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

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            
            string[] FirstNameList = File.ReadAllLines("..\\..\\Data\\firstNames.txt");
            string[] LastNameList = File.ReadAllLines("..\\..\\Data\\lastNames.txt");
            character.FirstName = FirstNameList[random.Next(FirstNameList.Length)];
            FirstNameDataLabel.Text = character.FirstName;
            character.LastName = LastNameList[random.Next(LastNameList.Length)];
            LastNameDataLabel.Text = character.LastName;
        }

        public void setAbility()
        {
            FightingDataLabel.Text = random.Next(10, 51).ToString();
            AgilityDataLabel.Text = random.Next(10, 51).ToString();
            StrengthDataLabel.Text = random.Next(10, 51).ToString();
            EnduranceDataLabel.Text = random.Next(10, 51).ToString();
            ReasonDataLabel.Text = random.Next(10, 51).ToString();
            ReasonDataLabel.Text = random.Next(10, 51).ToString();
            IntuitionDataLabel.Text = random.Next(10, 51).ToString();
            PsycheDataLabel.Text = random.Next(10, 51).ToString();
            PopularityDataLabel.Text = random.Next(10, 51).ToString();


            Program.character.Fighting = FightingDataLabel.Text;
            Program.character.Agility = AgilityDataLabel.Text;
            Program.character.Strength = StrengthDataLabel.Text;
            Program.character.Endurance = EnduranceDataLabel.Text;
            Program.character.Reason = ReasonDataLabel.Text;
            Program.character.Intuition = IntuitionDataLabel.Text;
            Program.character.Psyche = PsycheDataLabel.Text;
            Program.character.Popularity = PopularityDataLabel.Text;
            
        }
        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            setAbility();
        }
        private void GenerateRandomSkills()
        {
            Random random = new Random();
            SkillDataLabel1.Text = SkillsList[random.Next(0, SkillsList.Count - 1)];
            SkillDataLabel2.Text = SkillsList[random.Next(0, SkillsList.Count - 1)];
            SkillDataLabel3.Text = SkillsList[random.Next(0, SkillsList.Count - 1)];
            SkillDataLabel4.Text = SkillsList[random.Next(0, SkillsList.Count - 1)];
        }

        private void Abilities_Click(object sender, EventArgs e)
        {

        }

        private void ReasonLabel_Click(object sender, EventArgs e)
        {

        }

        
        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {

        }
        

        private void GenerateSkillsButton_Click_1(object sender, EventArgs e)
        {

            loadSkills();
            Debug.WriteLine("No of skills=" + SkillsList.Count.ToString());
        }
    }
}
