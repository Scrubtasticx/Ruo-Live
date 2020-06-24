using System;
using Server;
using Server.Gumps;
using Server.Guilds;
using Server.Mobiles;
using Server.Network;
using System.Collections;

namespace Server.Gumps
{
	public class OverallPvpGump : Gump
	{
      		private ArrayList m_List;
      		private int m_ListPage;
     		private ArrayList m_CountList;

		public OverallPvpGump( Mobile from, int listPage, ArrayList list, ArrayList count ) : base( 50, 50 )
		{
         		m_List = list;
         		m_ListPage = listPage;   
         		m_CountList = count;

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

         		if ( m_List == null )
			{
				ArrayList total = new ArrayList( World.Mobiles.Values );
				ArrayList a = new ArrayList();

				foreach ( Mobile person in total )
				{
					if ( person is PlayerMobile )
					{
						PlayerMobile gather = (PlayerMobile)person;
						a.Add( gather );
					}
				}

				m_List = a;
			}

         		if ( listPage > 0 )
			{
				AddButton(26, 285, 4014, 4015, 9, GumpButtonType.Reply, 0);
				AddLabel(60, 286, 1149, @"Last Page");
			}

         		if ( (listPage + 1) * 6 < m_List.Count )
			{
				AddButton(146, 285, 4005, 4006, 10, GumpButtonType.Reply, 0);
				AddLabel(179, 286, 1149, @"Next Page");
			}

			string time = "Viewing " + m_List.Count + " player pvp records.";
			AddLabel(30, 25, 1149, time.ToString() );

         		int k = 0;

         		for ( int i = 0, j = 0, index=((listPage*6)+k) ; i < 6 && index >= 0 && index < m_List.Count && j >= 0; ++i, ++j, ++index )
         		{
            			Mobile mob = m_List[index] as Mobile;
				
				if ( mob is PlayerMobile )
				{
					PlayerMobile m = (PlayerMobile)mob;

            				/*if ( m != null )
               					continue;*/

					int offset = 148 + (i * 20);

               				if ( m.AccessLevel != AccessLevel.Player )
               				{
                  				--i;
               				}
               				else
               				{
						int pure = m.TotalWins - m.TotalLoses - m.TotalResKills;

						AddLabel( 30, offset, 1149, m.Name.ToString() );
						AddLabel( 236, offset, 1149, m.TotalWins.ToString() );
						AddLabel( 285, offset, 1149, m.TotalLoses.ToString() );
						AddLabel( 334, offset, 1149, m.TotalResKills.ToString() );
						AddLabel( 383, offset, 1149, m.TotalResKilled.ToString() );
						AddLabel( 433, offset, 1149, pure.ToString() );

                  				Guild g = m.Guild as Guild;

                  				if ( g != null )
                 			 	{
                    					string abb;

							abb = "[" + g.Abbreviation + "]";

							AddLabel( 482, offset, 1149, abb );
						}
						else
						{
							AddLabel( 482, offset, 1149, @"No Guild" );
						}
					}
				}
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

        		if ( info.ButtonID == 9 ) // Previous page
         		{
         			if ( m_ListPage > 0 )
					from.SendGump( new OverallPvpGump( from, m_ListPage - 1, m_List, m_CountList ) );
			}

        		if ( info.ButtonID == 10 ) // Next page
         		{ 
         			if ( (m_ListPage + 1) * 6 < m_List.Count )
					from.SendGump( new OverallPvpGump( from, m_ListPage + 1, m_List, m_CountList ) );
			}
		}
	}
}