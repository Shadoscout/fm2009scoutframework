using System;
using System.Collections.Generic;
using System.Text;
using Young3.FMSearch.Business.Entities.InGame;
using Young3.FMSearch.Business.Managers;

namespace Young3.FMSearch.Interface
{

    /// <summary>
    /// Class containing all information about the
    /// FM game
    /// </summary>
    public class FMDataContext : IDisposable
    {
        /// <summary>
        /// Initializes the game world!
        /// </summary>
        public FMDataContext()
        {
            Countries = ObjectManager.Countries;
            Players = ObjectManager.Players;
            Clubs = ObjectManager.Clubs;
            Teams = ObjectManager.Teams;
            Continents = ObjectManager.Continents;
            Cities = ObjectManager.Cities;
            Stadiums = ObjectManager.Stadiums;
            NonPlayingStaff = ObjectManager.NonPlayingStaff;
        }

        public List<Country> Countries { get; set; }
        public List<Player> Players { get; set; }
        public List<Club> Clubs { get; set; }
        public List<Team> Teams { get; set; }
        public List<Continent> Continents { get; set; }
        public List<City> Cities { get; set; }
        public List<Stadium> Stadiums { get; set; }
        public List<Staff> NonPlayingStaff { get; set; }

        public DateTime IngameDate
        {
            get
            {
                return Global.IngameDate;
            }
        }

        public BaseObject ActiveObject { get { return Global.ActiveObject; } }

        #region IDisposable Members

        public void Dispose()
        {
            Countries = null;
        }

        #endregion
    }
}
