﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hearthstone_Deck_Tracker.Controls.Overlay
{
	/// <summary>
	/// Interaction logic for BattlegroundsHeroOverlay.xaml
	/// </summary>
	public partial class BattlegroundsHeroesOverlay : UserControl
	{
		public BattlegroundsHeroesOverlay()
		{
			InitializeComponent();
		}

		private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
		{
			(((Rectangle)sender).DataContext as BattlegroundsHeroViewModel)?.HoverCommand.Execute(true);
		}

		private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
		{
			(((Rectangle)sender).DataContext as BattlegroundsHeroViewModel)?.HoverCommand.Execute(false);
		}
	}
}
