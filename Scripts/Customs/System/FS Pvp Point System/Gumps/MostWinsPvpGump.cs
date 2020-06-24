using System;
using Server;
using Server.Gumps;
using Server.Guilds;
using Server.Mobiles;
using Server.Network;
using System.Collections;

namespace Server.Gumps
{
	public class MostWinsPvpGump : Gump
	{
		public MostWinsPvpGump() : base( 50, 50 )
		{
			Closable=false;
			Disposable=false;
			Dragable=false;
			Resizable=false;
			AddPage(0);
			AddBackground(16, 12, 549, 303, 5120);
			AddImageTiled(26, 21, 531, 26, 5154);
			AddAlphaRegion(26, 21, 531, 26);
			AddButton(28, 50, 4005, 4006, 1, GumpButtonType.Reply, 0);
			AddButton(202, 50, 4005, 4006, 2, GumpButtonType.Reply, 0);
			AddButton(364, 50, 4005, 4006, 3, GumpButtonType.Reply, 0);
			AddButton(28, 75, 4005, 4006, 4, GumpButtonType.Reply, 0);
			AddButton(202, 75, 4005, 4006, 5, GumpButtonType.Reply, 0);
			AddButton(364, 75, 4005, 4006, 6, GumpButtonType.Reply, 0);
			AddImageTiled(20, 101, 543, 10, 5121);
			AddLabel(61, 50, 1149, @"Overall Listing");
			AddLabel(236, 49, 1149, @"Most Wins");
			AddLabel(398, 49, 1149, @"Most Loses");
			AddLabel(61, 75, 1149, @"Most Times Res Killed");
			AddLabel(237, 75, 1149, @"Most Res Kills");
			AddLabel(397, 75, 1149, @"Most Pure Wins");
			AddImageTiled(20, 280, 543, 10, 5121);
			AddButton(482, 285, 4017, 4018, 7, GumpButtonType.Reply, 0);
			AddLabel(517, 286, 1149, @"Close");
			AddImageTiled(26, 110, 199, 23, 5174);
			AddImageTiled(232, 110, 42, 23, 5174);
			AddImageTiled(281, 110, 42, 23, 5174);
			AddImageTiled(330, 110, 42, 23, 5174);
			AddImageTiled(379, 110, 42, 23, 5174);
			AddImageTiled(428, 110, 42, 23, 5174);
			AddImageTiled(477, 110, 81, 23, 5174);
			AddImageTiled(26, 140, 199, 134, 5174);
			AddImageTiled(232, 140, 42, 134, 5174);
			AddImageTiled(281, 140, 42, 134, 5174);
			AddImageTiled(330, 140, 42, 134, 5174);
			AddImageTiled(379, 140, 42, 134, 5174);
			AddImageTiled(428, 140, 42, 134, 5174);
			AddImageTiled(477, 140, 81, 134, 5174);
			AddAlphaRegion(26, 110, 199, 23);
			AddAlphaRegion(232, 110, 42, 23);
			AddAlphaRegion(281, 110, 42, 23);
			AddAlphaRegion(330, 110, 42, 23);
			AddAlphaRegion(379, 110, 42, 23);
			AddAlphaRegion(428, 110, 42, 23);
			AddAlphaRegion(477, 110, 81, 23);
			AddLabel(30, 111, 1149, @"Name");
			AddLabel(236, 111, 1149, @"Wins");
			AddLabel(285, 111, 1149, @"Loses");
			AddLabel(334, 111, 1149, @"TRK");
			AddLabel(383, 111, 1149, @"TTRK");
			AddLabel(433, 111, 1149, @"Pure");
			AddLabel(482, 111, 1149, @"Guild Abbr");
			AddAlphaRegion(26, 140, 199, 134);
			AddAlphaRegion(232, 140, 42, 134);
			AddAlphaRegion(281, 140, 42, 134);
			AddAlphaRegion(330, 140, 42, 134);
			AddAlphaRegion(379, 140, 42, 134);
			AddAlphaRegion(428, 140, 42, 134);
			AddAlphaRegion(477, 140, 81, 134);
			AddButton(264, 285, 4026, 248, 8, GumpButtonType.Reply, 0);
			AddLabel(299, 286, 1149, @"Help Menu");

			string time = "View top 3 players with most overall wins.";
			AddLabel(30, 25, 1149, time.ToString() );

			ArrayList mobs = new ArrayList( World.Mobiles.Values );

			PlayerMobile Top = null;
			PlayerMobile Mid = null;
			PlayerMobile Low = null;

			foreach ( Mobile check1 in mobs )
			{
				if ( check1 is PlayerMobile )
				{
					PlayerMobile pvper = (PlayerMobile)check1;

					if ( Top == null ) 
						Top = pvper; 

					if ( pvper.TotalWins > Top.TotalWins && pvper.AccessLevel == AccessLevel.Player ) 
						Top = pvper;
				}
			}

			foreach ( Mobile check2 in mobs )
			{
				if ( check2 is PlayerMobile )
				{
					PlayerMobile pvper2 = (PlayerMobile)check2;

					if ( Mid == null ) 
						Mid = pvper2; 

					if ( pvper2.TotalWins > Mid.TotalWins && pvper2 != Top && pvper2.AccessLevel == AccessLevel.Player ) 
						Mid = pvper2;
				}
			}

			foreach ( Mobile check3 in mobs )
			{
				if ( check3 is PlayerMobile )
				{
					PlayerMobile pvper3 = (PlayerMobile)check3;

					if ( Low == null ) 
						Low = pvper3; 

					if ( pvper3.TotalWins > Low.TotalWins && pvper3 != Top && pvper3 != Mid && pvper3.AccessLevel == AccessLevel.Player ) 
						Low = pvper3;
				}
			}

			int pure1 = Top.TotalWins - Top.TotalLoses - Top.TotalResKills;

			AddLabel( 30, 148, 1149, Top.Name.ToString() );
			AddLabel( 236, 148, 1149, Top.TotalWins.ToString() );
			AddLabel( 285, 148, 1149, Top.TotalLoses.ToString() );
			AddLabel( 334, 148, 1149, Top.TotalResKills.ToString() );
			AddLabel( 383, 148, 1149, Top.TotalResKilled.ToString() );
			AddLabel( 433, 148, 1149, pure1.ToString() );

			int pure2 = Mid.TotalWins - Mid.TotalLoses - Mid.TotalResKills;

			AddLabel( 30, 168, 1149, Mid.Name.ToString() );
			AddLabel( 236, 168, 1149, Mid.TotalWins.ToString() );
			AddLabel( 285, 168, 1149, Mid.TotalLoses.ToString() );
			AddLabel( 334, 168, 1149, Mid.TotalResKills.ToString() );
			AddLabel( 383, 168, 1149, Mid.TotalResKilled.ToString() );
			AddLabel( 433, 168, 1149, pure2.ToString() );

			int pure3 = Low.TotalWins - Low.TotalLoses - Low.TotalResKills;

			AddLabel( 30, 188, 1149, Low.Name.ToString() );
			AddLabel( 236, 188, 1149, Low.TotalWins.ToString() );
			AddLabel( 285, 188, 1149, Low.TotalLoses.ToString() );
			AddLabel( 334, 188, 1149, Low.TotalResKills.ToString() );
			AddLabel( 383, 188, 1149, Low.TotalResKilled.ToString() );
			AddLabel( 433, 188, 1149, pure3.ToString() );

                  	Guild g1 = Top.Guild as Guild;
                  	Guild g2 = Mid.Guild as Guild;
                  	Guild g3 = Low.Guild as Guild;

                  	if ( g1 != null )
                 	{
                    		string abb;

				abb = "[" + g1.Abbreviation + "]";

				AddLabel( 482, 148, 1149, abb );
			}
			else
			{
				AddLabel( 482, 148, 1149, @"No Guild" );
			}

                  	if ( g2 != null )
                 	{
                    		string abb;

				abb = "[" + g2.Abbreviation + "]";

				AddLabel( 482, 168, 1149, abb );
			}
			else
			{
				AddLabel( 482, 168, 1149, @"No Guild" );
			}

                  	if ( g3 != null )
                 	{
                    		string abb;

				abb = "[" + g3.Abbreviation + "]";

				AddLabel( 482, 188, 1149, abb );
			}
			else
			{
				AddLabel( 482, 188, 1149, @"No Guild" );
			}
		}

      		public override void OnResponse( NetState state, RelayInfo info ) 
      		{ 
			Mobile from = state.Mobile; 

			if ( from == null )
				return;

        		if ( info.ButtonID == 1 ) // Overall
         		{
				from.SendGump( new OverallPvpGump( from, 0, null, null ) );
			}

        		if ( info.ButtonID == 2 ) // Mostwins
         		{
				from.SendGump( new MostWinsPvpGump() );
			}

        		if ( info.ButtonID == 3 ) // Most loses
         		{
				from.SendGump( new MostLosesPvpGump() );
			}

        		if ( info.ButtonID == 4 ) // Most times res killed
         		{
				from.SendGump( new MostTimesResKilledPvpGump() );
			}

        		if ( info.ButtonID == 5 ) // Most reskills
         		{
				from.SendGump( new MostResKillsPvpGump() );
			}

        		if ( info.ButtonID == 6 ) // Most pure wins
         		{
				from.SendGump( new MostPureWinsPvpGump() );
			}

        		if ( info.ButtonID == 7 ) // Close
         		{
			}

        		if ( info.ButtonID == 8 ) // Help menu
         		{
				from.SendGump( new PvpScoreBoardHelpGump() );
			}
		}
	}
}