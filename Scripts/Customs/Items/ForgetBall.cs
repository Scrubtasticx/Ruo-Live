using System;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Misc;

namespace Server.Items
{ 
	public class ForgetBall : Item 
	{ 
		[Constructable] 
		public ForgetBall() : base( 0xE73 ) 
		{ 
			Movable = true;
           	Weight = 1.0;
            Hue = 2;
            Name = "a ball of forgetfulness";
			LootType = LootType.Blessed;
		} 

		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( !IsChildOf( from.Backpack ) ) 
			{
	  			from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
				return;
			}           else if ( from.Kills >0 && from.ShortTermMurders >0 )
			       {	
                                   from.ShortTermMurders = 0;
								   from.Kills = 0;
                                   from.Criminal = false;
                                   from.SendMessage( "You are a no longer a murderer." );
                                   from.FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.LeftFoot );
                                   from.PlaySound( 0x208 );
								   this.Delete();
					}
	    }
		
		 public ForgetBall( Serial serial ) : base( serial ) 
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
				