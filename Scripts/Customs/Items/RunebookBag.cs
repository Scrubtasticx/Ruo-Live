using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class RunebookBag : Pouch
	{
		[Constructable]
		public RunebookBag() : this( 1000 )
		{
		}
		
		[Constructable]
		public RunebookBag( int amount )
		{
			DropItem( new BlackPearl   ( amount ) );
			DropItem( new Bloodmoss    ( amount ) );
			DropItem( new MandrakeRoot ( amount ) );
			DropItem( new ScribesPen() );
			DropItem( new RecallScroll   ( amount ) );
			DropItem( new GateTravelScroll ( amount ) );
			DropItem( new BlankScroll  ( amount ) );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );
			DropItem( new RecallRune() );			
		}

		public RunebookBag( Serial serial ) : base( serial )
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