using System;
using Server;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;
using Server.Targeting;
using Server.Commands;

namespace Server.Commands
{
	public class PvpStatsCommand
	{
		public static void Initialize()
		{
			CommandSystem.Register( "PvpStats", AccessLevel.Player, new CommandEventHandler( PvpStats_OnCommand ) );
		}

		[Usage( "PvpStats" )]
		[Description( "Show Pvp Stats Of Targeted Player" )]
		private static void PvpStats_OnCommand( CommandEventArgs e )
		{
			if ( e.Mobile is PlayerMobile )
			{
				e.Mobile.Target = new PvpStatsTarget();
				e.Mobile.SendMessage("Whos stats would you like to view?");
			}
		}
		public class PvpStatsTarget : Target
		{

			public PvpStatsTarget() : base( -1, true, TargetFlags.None )
			{
			}

			protected override void OnTarget( Mobile from, object o )
			{

				if ( from is PlayerMobile && o is PlayerMobile )
				{
					PlayerMobile m = (PlayerMobile)o;

					from.SendGump( new PvpStatGump( from, o ) );
					if ( m == from )
					{
						from.SendMessage( "You view your pvp stats." );
					}
					else
					{
						m.SendMessage( "{0} is viewing your pvp stats.", from.Name );
					}
				}
			}
		}
	}
	public class PvpStatGump : Gump
	{
		private Mobile m_From;
		private object m_Object;

		public PvpStatGump( Mobile from, object o ) : base( 25, 25 )
		{

			m_From = from;
			m_Object = o;

			Closable=true;
			Disposable=true;
			Dragable=true;
			Resizable=false;
			AddPage(0);
			AddBackground(23, 23, 417, 312, 5120);
			AddLabel(35, 25, 1160,  @"Player Vs. Player Statistics");
			AddImageTiled(28, 51, 409, 9, 5121);
			AddHtml(35, 65, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Player Name:", false, false);
			AddHtml(35, 85, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Short Term Murder Counts:", false, false);
			AddHtml(35, 105, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Long Term Murder Counts:", false, false);
			AddHtml(35, 137, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Points:", false, false);
			AddImageTiled(28, 129, 409, 9, 5121);
			AddHtml(35, 155, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Battles Won:", false, false);
			AddHtml(35, 175, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Battles Lost:", false, false);
			AddHtml(35, 195, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Res Kills:", false, false);
			AddHtml(35, 215, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Times Res Killed:", false, false);
			AddImageTiled(27, 238, 409, 9, 5121);
			AddHtml(35, 245, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Last Person Defeated:", false, false);
			AddHtml(35, 265, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Last Defeated By:", false, false);
			AddImageTiled(27, 288, 409, 9, 5121);
			AddButton(37, 298, 4017, 4018, 1, GumpButtonType.Reply, 0);
			AddLabel(75, 299, 1160, @"Close");
			AddButton(146, 298, 4026, 4027, 1, GumpButtonType.Page, 2);
			AddLabel(185, 299, 1160, @"Help");
			AddPage(1);

			if ( o is PlayerMobile )
			{
				PlayerMobile pm = (PlayerMobile)o;
				if ( from.Criminal == true )
				{
					AddLabel(120, 65, 89, pm.Name.ToString() );
				}
				else if ( from.Kills >= 5 )
				{
					AddLabel(120, 65, 34, pm.Name.ToString() );
				}
				else
				{
					AddLabel(120, 65, 946, pm.Name.ToString() );
				}

				AddLabel(211, 85, 1160, pm.ShortTermMurders.ToString() );
				AddLabel(203, 105, 1160, pm.Kills.ToString() );
				AddLabel(120, 135, 1160, pm.TotalPoints.ToString() );
				AddLabel(157, 155, 1160, pm.TotalWins.ToString() );
				AddLabel(159, 175, 1160, pm.TotalLoses.ToString() );
				AddLabel(133, 195, 1160, pm.TotalResKills.ToString() );
				AddLabel(179, 215, 1160, pm.TotalResKilled.ToString() );
				if ( pm.LastPwned == null )
				{
					AddLabel(180, 245, 1160, @"Nobody" );
				}
				else
				{
					AddLabel(180, 245, 1160, pm.LastPwned.Name.ToString() );
				}
				if ( pm.LastPwner == null )
				{
					AddLabel(152, 265, 1160, @"Nobody" );
				}
				else
				{
					AddLabel(152, 265, 1160, pm.LastPwner.Name.ToString() );
				}
			}

			AddButton(318, 298, 4005, 4006, 4, GumpButtonType.Page, 3);
			AddLabel(358, 299, 1160, @"Next Page");
			AddPage(2);
			AddBackground(23, 23, 417, 312, 5120);
			AddImageTiled(28, 51, 409, 9, 5121);
			AddLabel(35, 25, 1160, @"Player Vs. Player Statistics Help Menu");
			AddHtml( 37, 61, 392, 220, @"<U>Player Name</U><BR>This indicates the person whoso statistics in which you are viewing. The color of name gives the players current status weather it be, Red ( Murder ), Gray ( Criminal ), or Blue ( Innocent )<BR><BR><U>Short Term Murder Counts</U><BR>This tells you how many short term murder counts the player has.<BR><BR><U>Long Term Murder Counts</U><BR>This tells you how many long term murder counts the player has.<BR><BR><U>Total Points</U><BR>This tells you how many pvp points the player has. Pvp points are given out when a player kills another player. However points are removed when you are killed by another player. No player can go below 0 points. Points can be used to redeem gifts from the pvp point reward stone.<BR><BR><U>Total Battles Won</U><BR>This tells you how many battles the player has won over time. These numbers never reset or delete for any reason. Res kills are also added to this pool and a total number of wins is displayed<BR><BR><U>Total Battles Lost
			</U><BR>This tells you how many battles the lost over time. These numbers never reset or delete for any reason. How many times a player has been res killed is added to this pool and a total number of loses is displayed.<BR><BR><U>Total Res Kills</U><BR>This tells you how many time the player has res killed another player. Res kills are given if a player kills the same player again within a 10 mins time frame.<BR><BR><U>Total Times Res Killed</U><BR>This tells you how many times the player has been res killed by another Player. Res kills are given if a player kills the same player again within a 10 mins time frame.<BR><BR><U>Last Person Defeated</U><BR>This tells you the last person this player has killed.<BR><BR><U>Last Defeated By</U><BR>This tells you the last person to kill this player.<BR><BR><U>Player Rank</U><BR>This show the players current pvp rank.<BR><BR><U>Pure Wins</U><BR>Pure wins are your TotalWins - TotalLoses - TotalResKills. This number is what determinds your rank.<BR><BR><U>Total Pure
			Wins Till Next Rank</U> This how many more pure wins you need till your next rank.<BR><BR><U>Total Battles Fought</U><BR>Totals all battles won and lost.<BR><BR><U>Total Points Lost</U><BR>Shows how many points have been lost due to death.<BR><BR><U>Total Points Spent</U><BR>Shows how many points have been spent.", (bool)true, (bool)true);
			AddImageTiled(27, 288, 409, 9, 5121);
			AddButton(37, 298, 4017, 4018, 2, GumpButtonType.Reply, 0);
			AddLabel(75, 299, 1160, @"Close");
			AddButton(146, 298, 4014, 4015, 2, GumpButtonType.Page, 1);
			AddLabel(185, 299, 1160, @"Return");
			AddPage(3);
			AddBackground(23, 23, 417, 312, 5120);
			AddLabel(35, 25, 1160, @"Player Vs. Player Statistics");
			AddImageTiled(28, 51, 409, 9, 5121);
			AddHtml(35, 65, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Player Rank:", false, false);
			AddHtml(35, 85, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Pure Wins:", false, false);
			AddHtml(35, 105, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Pure Wins Till Next Rank:", false, false);
			AddImageTiled(27, 288, 409, 9, 5121);
			AddButton(37, 298, 4017, 4018, 3, GumpButtonType.Reply, 0);
			AddLabel(75, 299, 1160, @"Close");
			AddButton(146, 298, 4026, 4027, 3, GumpButtonType.Page, 2);
			AddLabel(185, 299, 1160, @"Help");
			AddButton(318, 298, 4014, 4015, 4, GumpButtonType.Page, 1);
			AddLabel(358, 299, 1160, @"Last Page");

			AddHtml(35, 137, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Battles Fought:", false, false);
			AddImageTiled(28, 129, 409, 9, 5121);
			AddHtml(35, 155, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Points Lost:", false, false);
			AddHtml(35, 175, 1149, 18,  "<BASEFONT COLOR=#FFFFFF>Total Points Spent:", false, false);
			if ( o is PlayerMobile )
			{
				PlayerMobile pm2 = (PlayerMobile)o;
				int i = pm2.TotalWins - pm2.TotalLoses - pm2.TotalResKills;

				if ( pm2.PvpRank != null )
					AddLabel(116, 65, 1160, pm2.PvpRank.ToString() );
				else
					AddLabel(116, 65, 1160, @"Newbie");

				AddLabel(106, 85, 1160, i.ToString() );

				if ( i <= 2 )
				{
					int r = 2 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 10 )
				{
					int r = 10 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 20 )
				{
					int r = 20 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 30 )
				{
					int r = 30 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 50 )
				{
					int r = 50 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 100 )
				{
					int r = 100 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 300 )
				{
					int r = 300 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 600 )
				{
					int r = 600 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 1200 )
				{
					int r = 1200 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 3000 )
				{
					int r = 3000 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 5000 )
				{
					int r = 5000 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 7000 )
				{
					int r = 7000 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i <= 9999 )
				{
					int r = 9999 - i;
					AddLabel(196, 105, 1160, r.ToString() );
				}
				else if ( i >= 10001 )
				{
					AddLabel(196, 105, 1160, @"0");
				}

				int tbf = pm2.TotalWins + pm2.TotalLoses;
				AddLabel(166, 135, 1160, tbf.ToString() );
				AddLabel(151, 155, 1160, pm2.TotalPointsLost.ToString() );
				AddLabel(153, 175, 1160, pm2.TotalPointsSpent.ToString() );
			}

		}

	}
}