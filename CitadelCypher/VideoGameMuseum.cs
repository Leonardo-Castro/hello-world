using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Brain;

namespace VideoGameMuseum
{
   public partial class VideoGameMuseum : Form
   {
      private Player _player;

      public VideoGameMuseum()
      {
         InitializeComponent();

         _player = new Player(10, 10, 20, 0, 1);
         MoveTo(World.LocationByID(World.LOCATION_ID_LOBBY));
      }

      //Navigation Buttons

      //this button moves the player forward
      private void btnNorth_Click(object sender, EventArgs e)
      {
         MoveTo(_player.CurrentLocation.LocationToNorth);
      }

      //this button moves the player to the right
      private void btnRight_Click(object sender, EventArgs e)
      {
         MoveTo(_player.CurrentLocation.LocationToRight);
      }

      //this button moves the player backward
      private void btnSouth_Click(object sender, EventArgs e)
      {
         MoveTo(_player.CurrentLocation.LocationToSouth);
      }

      //this button moves the player to the left
      private void btnLeft_Click(object sender, EventArgs e)
      {
         MoveTo(_player.CurrentLocation.LocationToLeft);
      }

      //this code tells the buttons to be visible only if the button can be used to mo]ve to location
      private void MoveTo(Location newLocation)
      {
         _player.CurrentLocation = newLocation;

         btnNorth.Visible = (newLocation.LocationToNorth != null);
         btnRight.Visible = (newLocation.LocationToRight != null);
         btnSouth.Visible = (newLocation.LocationToSouth != null);
         btnLeft.Visible = (newLocation.LocationToLeft != null);

         rtbLocation.Text = newLocation.Name + Environment.NewLine;
         rtbLocation.Text += newLocation.Description + Environment.NewLine;

      }

      //this button opens the Company table in a seperate form
      private void btnCompanyTable_Click(object sender, EventArgs e)
      {
         CompanyTable com = new CompanyTable();
         com.Show();
      }

      //this button opens the Industry Personality table in a seperate form
      private void btnIndustryPersonality_Click(object sender, EventArgs e)
      {
         IndustryPersonalityTable ind = new IndustryPersonalityTable();
         ind.Show();
      }

      //this button opens the Console table in a seperate form
      private void btnConsoleTable_Click(object sender, EventArgs e)
      {
         ConsoleTable con = new ConsoleTable();
         con.Show();
      }

      //this button opens the Games table in a seperate form
      private void btnGameTable_Click(object sender, EventArgs e)
      {
         GameTable gam = new GameTable();
         gam.Show();
      }
   }
}