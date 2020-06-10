using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SupplyBag : Pouch
	{
		[Constructable]
		public SupplyBag() : this( 50 )
		{
		}
		
		[Constructable]
		public SupplyBag( int amount )
		{
			DropItem( new BlackPearl   ( amount ) );
			DropItem( new Bloodmoss    ( amount ) );
			DropItem( new Garlic       ( amount ) );
			DropItem( new Ginseng      ( amount ) );
			DropItem( new MandrakeRoot ( amount ) );
			DropItem( new Nightshade   ( amount ) );
			DropItem( new SulfurousAsh ( amount ) );
			DropItem( new SpidersSilk  ( amount ) );
		    DropItem( new Arrow( amount ) );
			DropItem( new Bolt( amount ) );
			DropItem( new Bandage( amount ) );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterExplosionPotion() );
			DropItem( new GreaterHealPotion() );
			DropItem( new GreaterHealPotion() );
			DropItem( new GreaterHealPotion() );
			DropItem( new GreaterHealPotion() );
			DropItem( new GreaterHealPotion() );
			DropItem( new GreaterCurePotion() );
			DropItem( new GreaterCurePotion() );
			DropItem( new GreaterCurePotion() );
			DropItem( new GreaterCurePotion() );
			DropItem( new GreaterCurePotion() );
			DropItem( new TotalRefreshPotion() );
			DropItem( new TotalRefreshPotion() );
			DropItem( new TotalRefreshPotion() );
			DropItem( new TotalRefreshPotion() );
			DropItem( new TotalRefreshPotion() );
			DropItem( new GreaterStrengthPotion() );
			DropItem( new GreaterStrengthPotion() );
			DropItem( new GreaterStrengthPotion() );
			DropItem( new GreaterStrengthPotion() );
			DropItem( new GreaterAgilityPotion() );
			DropItem( new GreaterAgilityPotion() );
			DropItem( new GreaterAgilityPotion() );
			DropItem( new GreaterAgilityPotion() );
			DropItem( new GreaterAgilityPotion() );
			DropItem( new RoseOfTrinsicPetal() );
			DropItem( new RoseOfTrinsicPetal() );
			DropItem( new RoseOfTrinsicPetal() );
			DropItem( new RoseOfTrinsicPetal() );
			DropItem( new RoseOfTrinsicPetal() );
					
		}

		public SupplyBag( Serial serial ) : base( serial )
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