/*Scripted by  _____         
*	  		   \_   \___ ___ 
*			    / /\/ __/ _ \
*		     /\/ /_| (_|  __/
*			 \____/ \___\___|
*
*  I USE A SPECIAL HUES.MUL ON MY SERVER SO IF YOU 
*  DO NOT HAVE MY HUES.MUL FILE MOST ALL DYES WILL BE 
*  SOLID BLACK YOU CAN FIND MY HUES.MUL AT THE LINK BELOW.	
*  http://thegreengriffin.yolasite.com/downloads.php
* 
*/

using System;
using Server;
using Server.Targeting;
using Server.Items;
using System.Text;
using Server.Network;
using System.Collections;

namespace Server.Items
{
	public class iSDTarget : Target
	{
		bool Reusable = true;   // Sets the dyes to reusable Players can dye more than one tub
		
		
		
		private Item m_Item;
		public iSDTarget( Item item ) : base( 12, false, TargetFlags.None )
		{
			m_Item = item;
		}
		protected override void OnTarget( Mobile from, object targeted )
		{
			if ( targeted is Item )
			{
				Item targ = (Item)targeted;
				if (!targ.IsChildOf (from.Backpack))
				{
					from.SendMessage(38, "The item is not in your backpack!" );
					return;
				}
				else if ( targeted is DyeTub )
				{
					DyeTub tub = (DyeTub)targeted;
					if ( tub.Redyable == true )
					{
						tub.DyedHue =  m_Item.Hue;
						targ.Name = "Dying Tub: "+ Convert.ToString(m_Item.Hue);
						from.PlaySound( 0x23F );
						if ( Reusable == false )
						{
							tub.Redyable = false;
							m_Item.Delete();
							return;
						}
						return;
					}else
						from.SendMessage(38, "This dyetub has already been dyed!" );
				}
				else if ( targeted is UniversalDyeTub )
				{
					UniversalDyeTub utub = (UniversalDyeTub)targeted;
					if ( Reusable == false )
					{
						if ( utub.Hue == 0 )
						{
							utub.Hue = m_Item.Hue;
							targ.Name = "Universal Dying Tub: "+ Convert.ToString(m_Item.Hue);
							from.PlaySound( 0x23F );
							m_Item.Delete();
							return;
						}else from.SendMessage(38, "This Universal dyetub has already been dyed!" );
					}else if ( Reusable == true )
					{
						utub.Hue = m_Item.Hue;
						targ.Name = "Universal Dying Tub: "+ Convert.ToString(m_Item.Hue);
						from.PlaySound( 0x23F );
						return;		
					}	
				}else
					from.SendMessage(38, "This is not a dyetub!!" );				
			}else
				from.SendMessage(38, "You cannot Dye Mobiles!!" );
		}	
	}
	public class iSpecialDyes : Item
	{ 
		[Constructable]
		public iSpecialDyes() : base( 0xFA9 )
		{
			Weight = 1.0;
			Hue = Utility.RandomMinMax( 2151, 2998 );
			Name = "Extremly Rare Dyes";
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Hue = {0}", this.Hue.ToString() );
		}
		public iSpecialDyes( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			
			if ( !IsChildOf (from.Backpack))
			{
					from.SendMessage( "You must have this item in your pack to use it.!!" );
					return;
			}
			else
			{
				from.Target = new iSDTarget( this );
				from.SendLocalizedMessage( 1045104 );
				
			}
			
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
	public class iSpecialDyes1 : Item
	{ 
		[Constructable]
		public iSpecialDyes1() : base( 0xFA9 )
		{
			Weight = 1.0;
			Hue = Utility.RandomMinMax( 1751, 2150 );
			Name = "Rare Dyes";
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Hue = {0}", this.Hue.ToString() );
		}
		public iSpecialDyes1( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			
			if ( !IsChildOf (from.Backpack))
			{
					from.SendMessage( "You must have this item in your pack to use it.!!" );
					return;
			}
			else
			{
				from.Target = new iSDTarget( this );
				from.SendLocalizedMessage( 1045104 );
				
			}
			
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
	public class iSpecialDyes2 : Item
	{ 
		[Constructable]
		public iSpecialDyes2() : base( 0xFA9 )
		{
			Weight = 1.0;
			Hue = Utility.RandomMinMax( 1201, 1750 );
			Name = "Uncommon Dyes";
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Hue = {0}", this.Hue.ToString() );
		}
		public iSpecialDyes2( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			
			if ( !IsChildOf (from.Backpack))
			{
					from.SendMessage( "You must have this item in your pack to use it.!!" );
					return;
			}
			else
			{
				from.Target = new iSDTarget( this );
				from.SendLocalizedMessage( 1045104 );
				
			}
			
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
	public class iSpecialDyes3 : Item
	{ 
		[Constructable]
		public iSpecialDyes3() : base( 0xFA9 )
		{
			Weight = 1.0;
			Hue = Utility.RandomMinMax( 1150, 1200 );
			Name = "Common Dyes";
		}
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );

			list.Add( "Hue = {0}", this.Hue.ToString() );
		}
		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf (from.Backpack))
			{
					from.SendMessage( "You must have this item in your pack to use it.!!" );
					return;
			}
			else
			{
				from.Target = new iSDTarget( this );
				from.SendLocalizedMessage( 1045104 );	
			}
		}
		public iSpecialDyes3( Serial serial ) : base( serial )
		{
		}
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 );
		}
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}