using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

using Golf.Code.UI_s;
using Golf.Code.UI_s.WinForms;
using Golf.Properties;

using SomeCardGamesAPI.API;
using SomeCardGamesAPI.Error;
using SomeCardGamesAPI.Utility;
using System.Xml.Serialization;

namespace Golf.Code
{
    /// <summary>
    /// This class is the main source and entrance for the card game "Golf".
    /// </summary>
	[Serializable()]
    public class GolfLogic : ICardGame
    {
        /// <summary>
        /// A list of all of the players currently in the golf game.
        /// </summary>
		[XmlArrayItem(ElementName = "GolfPlayers")]
        public List<GolfPlayer> Players;

        /// <summary>
        /// Used to draw the currently running golf game to the main form.
        /// </summary>
        public GolfDrawer Drawer;

        /// <summary>
        /// This is the deck of cards in the middle of the table.
        /// </summary>
        public Deck TheDeck;

        /// <summary>
        /// The constructor for the GolfLogic class.
        /// </summary>
        public GolfLogic()
        {
        }
		/// <summary>
		/// This constructor is for construction from XML.
		/// </summary>
		public GolfLogic(SerializationInfo info, StreamingContext context)
		{

		}

        /// <summary>
        /// Creates and deals in all of the players for this game.
        /// </summary>
        private void DealInPlayers()
        {
            try
            {
                Players = new List<GolfPlayer>();
                int i = 0;
                int PlayersToDealIn = Golf.Properties.Settings.Default.GolfAIPlayers;

                Players.Add(this.DealInPlayer(false));

                while (i != PlayersToDealIn)
                {
                    Players.Add(this.DealInPlayer(false));
                    i++;
                }
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Creates a GolfPlayer object, and returns it.
        /// </summary>
        /// <param name="IsAI"></param>
        private GolfPlayer DealInPlayer(bool IsAI)
        {
            try
            {
                GolfPlayer Player;
                Card[] Cards = new Card[6];

                int i = 0;

                while (i != 6)
                {
                    Cards[i] = this.TheDeck.GetTop();
                    i++;
                }

                Player = new GolfPlayer(Cards, IsAI);

                return Player;
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
                return null;
            }
        }

        /// <summary>
        /// This method adds as many cards to the "deck" as needed to support as many AIs as are in the game.
        /// </summary>
        private void CreateGolfDeck()
        {
            try
            {
                int Decks;
                int Players = Golf.Properties.Settings.Default.GolfAIPlayers + 1;

                double Dec = Players / 3;

                Decks = Convert.ToInt32(Dec);

                if (Decks < 1)
                {
                    throw new Exception(ErrorStorage.InvalidDeckCreationException);
                }

                this.TheDeck = new Deck(false, Decks);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Called to stop this card game.
        /// </summary>
        public void Stop()
        {
        }

        /// <summary>
        /// Passes a call onto the drawer for this game.
        /// </summary>
        /// <param name="G"></param>
        public void Draw(Graphics G)
        {
            try
            {
                this.Drawer.Draw(G);
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

        /// <summary>
        /// Returns the settings file for the current golf game.
        /// </summary>
        /// <returns></returns>
        public SettingsBase GetSettings()
        {
            return new Settings();
        }

        /// <summary>
        /// Launches a menu that allows the user to specify what to load.
        /// </summary>
        public void Load()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Launches a menu that allows the user to adjust some options.
        /// </summary>
        public void Options()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Launches a menu that allows the user to save the current game.
        /// </summary>
        public void Save()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Launches a menu that allows the user to create a new game.
        /// </summary>
        public void New()
        {
            try
            {
                NewGolfForm a = new NewGolfForm();

                a.ShowDialog(VariableStorage.TheForm);
                
                this.Drawer = new GolfDrawer();
                this.Drawer.StartUp(this);
                this.CreateGolfDeck();
                this.DealInPlayers();
            }
            catch (Exception TheException)
            {
                ErrorReporter.Report(TheException);
            }
        }

		/// <summary>
		/// Serializes this object to XML.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			try
			{
				info.AddValue("GolfPlayers", this.Players);
			}
			catch (Exception TheException)
			{
				ErrorReporter.Report(TheException);
				MessageBox.Show("Error!", "Failed to save golf game data.");
			}
		}
	}
}