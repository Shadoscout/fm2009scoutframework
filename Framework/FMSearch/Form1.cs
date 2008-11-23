using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Young3.FMSearch.Interface;
using Young3.FMSearch.Business.Entities.InGame;
using System.Reflection;
using System.Diagnostics;

namespace FMSearch
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Testing form, demonstrates some of the capabilties of the Framework
        /// </summary>

        public FMDataContext fmDataContext;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            fmDataContext = new FMDataContext();
            {
                this.ClubsComboBox.DataSource = fmDataContext.Clubs.OrderBy(c => c.Name).ToList();
            }
        }

        private void LeetPlayers_Click(object sender, EventArgs e)
        {
            Club currentClub = fmDataContext.Clubs.Single(cl => cl.Name.ToLower() == ClubsComboBox.Text.ToLower());
            var playerCollection =
                from p in fmDataContext.Players
                where p.Team.Club == currentClub
                select p;

            foreach (Player player in playerCollection)
            {
                foreach (PropertyInfo p in typeof(TechnicalSkills).GetProperties())
                        p.SetValue(player.TechnicalSkills, (SByte)127, null);

                foreach (PropertyInfo p in typeof(PhysicalSkills).GetProperties())
                        p.SetValue(player.PhysicalSkills, (SByte)127, null);

                foreach (PropertyInfo p in typeof(MentalSkills).GetProperties())
                        p.SetValue(player.MentalSkills, (SByte)127, null);
            }
        }

        private void MakeCAButton_Click(object sender, EventArgs e)
        {
            Country targetCountry = fmDataContext.Countries.Single(a=>a.Name=="Holland");
            foreach (Player player in fmDataContext.Players.Where(p => p.CurrentPlayingAbility > 170))
                player.Nationality = targetCountry;
        }

        private void ActivePlayerButton_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(((Player)fmDataContext.ActiveObject).ToString());
            }
            catch { }
        }

       

    }
}
