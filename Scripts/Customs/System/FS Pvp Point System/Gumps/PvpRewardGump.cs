using System;
using Server;
using Server.Gumps;
using Server.Network;

namespace Server.Gumps
{
	public class PvpRewardGump : Gump
	{
		public PvpRewardGump() : base( 25, 25 )
		{
			Closable=true;
			Disposable=true;
			Dragable=true;
			Resizable=false;
			AddPage(0);
			AddBackground(14, 13, 191, 288, 9270);
			AddImageTiled(25, 24, 169, 25, 5104);
			AddImageTiled(25, 56, 169, 234, 5104);
			AddAlphaRegion(25, 24, 169, 25);
			AddAlphaRegion(25, 56, 169, 234);
			AddLabel(30, 26, 1149, @"PvP Point Reward System");
			AddLabel(77, 57, 1149, @"Buy Items");
			AddButton(30, 80, 4005, 4006, 1, GumpButtonType.Reply, 0);
			AddButton(30, 110, 4005, 4006, 2, GumpButtonType.Reply, 0);
			AddButton(30, 140, 4005, 4006, 3, GumpButtonType.Reply, 0);
			AddButton(30, 170, 4005, 4006, 4, GumpButtonType.Reply, 0);
			AddButton(30, 200, 4005, 4006, 5, GumpButtonType.Reply, 0);
			AddButton(30, 230, 4005, 4006, 6, GumpButtonType.Reply, 0);
			AddButton(30, 260, 4005, 4006, 7, GumpButtonType.Reply, 0);
			AddLabel(65, 80, 1160, @"Buy Clothing");
			AddLabel(65, 110, 1160, @"Buy Weapons");
			AddLabel(65, 140, 1160, @"Buy Shields");
			AddLabel(65, 170, 1160, @"Buy Armor");
			AddLabel(65, 200, 1160, @"Buy Jewellery");
			AddLabel(65, 230, 1160, @"Buy Runic Tools");
			AddLabel(65, 260, 1160, @"Buy Misc. Items");

		}

      		public override void OnResponse( NetState state, RelayInfo info ) 
      		{ 
			Mobile from = state.Mobile; 

			if ( from == null )
				return;

        		if ( info.ButtonID == 1 )
         		{
				from.CloseGump( typeof( PvpClothingGump ) );
				from.SendGump( new PvpClothingGump() );
			}

        		if ( info.ButtonID == 2 )
         		{
				from.CloseGump( typeof( PvpWeaponsGump ) );
				from.SendGump( new PvpWeaponsGump() );
			}

        		if ( info.ButtonID == 3 )
         		{
				from.CloseGump( typeof( PvpShieldsGump ) );
				from.SendGump( new PvpShieldsGump() );
			}

        		if ( info.ButtonID == 4 )
         		{
				from.CloseGump( typeof( PvpArmorGump ) );
				from.SendGump( new PvpArmorGump() );
			}

        		if ( info.ButtonID == 5 )
         		{
				from.CloseGump( typeof( PvpJewelleryGump ) );
				from.SendGump( new PvpJewelleryGump() );
			}

        		if ( info.ButtonID == 6 )
         		{
				from.CloseGump( typeof( PvpRunicGump ) );
				from.SendGump( new PvpRunicGump() );
			}

        		if ( info.ButtonID == 7 )
         		{
				from.CloseGump( typeof( PvpMiscGump ) );
				from.SendGump( new PvpMiscGump() );
			}
		}
	}
}