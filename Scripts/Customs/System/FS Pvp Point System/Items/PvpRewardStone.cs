using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions;

namespace Server.Items
{ 
	public class PvpRewardStone : Item 
	{ 
		[Constructable] 
		public PvpRewardStone() : base( 3804 ) 
		{ 
			Movable = false; 
			Hue = 1154; 
			Name = "Token Reward Terminal"; 
		} 

		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( from.InRange( this.GetWorldLocation(), 2 ) ) 
			{ 
				from.CloseGump( typeof( PvpRewardGump ) );
				from.SendGump( new PvpRewardGump() );
			} 
		} 

		public PvpRewardStone( Serial serial ) : base( serial ) 
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