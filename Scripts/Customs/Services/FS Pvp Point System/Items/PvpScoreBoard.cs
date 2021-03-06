using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions;

namespace Server.Items
{ 
	[FlipableAttribute( 7774, 7775 )]
	public class PvpScoreBoard : Item 
	{ 
		[Constructable] 
		public PvpScoreBoard() : base( 7774 ) 
		{ 
			Movable = false; 
			Name = "Pvp Score Board"; 
		} 

		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( from.InRange( this.GetWorldLocation(), 2 ) ) 
			{ 
				from.CloseGump( typeof( OverallPvpGump ) );
				from.SendGump( new OverallPvpGump( from, 0, null, null ) );
			} 
		} 

		public PvpScoreBoard( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 

			writer.Write( (int) 0 ); // version 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	} 
} 