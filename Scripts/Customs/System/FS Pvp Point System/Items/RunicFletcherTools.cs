using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
	[FlipableAttribute( 0x13E4, 0x13E3 )]
	public class RunicFletcherTools : BaseRunicTool
	{
		public override CraftSystem CraftSystem{ get{ return DefBowFletching.CraftSystem; } }

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );

			int index = CraftResources.GetIndex( Resource );

			if ( index >= 1 && index <= 8 )
				return;

			if ( !CraftResources.IsStandard( Resource ) )
			{
				int num = CraftResources.GetLocalizationNumber( Resource );

				if ( num > 0 )
					list.Add( num );
				else
					list.Add( CraftResources.GetName( Resource ) );
			}
		}

		[Constructable]
		public RunicFletcherTools( CraftResource resource ) : base( resource, 4130 )
		{
			Weight = 8.0;
			Name = "runic fletching tools";
			Hue = CraftResources.GetHue( resource );
		}

		[Constructable]
		public RunicFletcherTools( CraftResource resource, int uses ) : base( resource, uses, 4130 )
		{
			Weight = 8.0;
			Name = "runic fletching tools";
			Hue = CraftResources.GetHue( resource );
		}

		public RunicFletcherTools( Serial serial ) : base( serial )
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