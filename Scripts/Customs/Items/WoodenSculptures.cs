using System;
using Server;

namespace Server.Items
{
	//2016
	//Sword
	public class ValorSculpture : BaseLight
	{
		public override int LitItemID { get { return 40430; } }
		public override int UnlitItemID { get { return 40576; } }

		[Constructable]
		public ValorSculpture()
			: base( 40576 )
		{
			Name = "Wooden Valor Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public ValorSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Axe
	public class DespiseSculpture : BaseLight
	{
		public override int LitItemID { get { return 40434; } }
		public override int UnlitItemID { get { return 40577; } }

		[Constructable]
		public DespiseSculpture()
			: base( 40577 )
		{
			Name = "Wooden Despise Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public DespiseSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Ankh
	public class SpiritualitySculpture : BaseLight
	{
		public override int LitItemID { get { return 40438; } }
		public override int UnlitItemID { get { return 40578; } }

		[Constructable]
		public SpiritualitySculpture()
			: base( 40578 )
		{
			Name = "Wooden Spirituality Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public SpiritualitySculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Masks
	public class DeceitSculpture : BaseLight
	{
		public override int LitItemID { get { return 40442; } }
		public override int UnlitItemID { get { return 40579; } }

		[Constructable]
		public DeceitSculpture()
			: base( 40579 )
		{
			Name = "Wooden Deceit Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public DeceitSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	
	
	//2017
	//Crescent Moon
	public class HythlothSculpture : BaseLight
	{
		public override int LitItemID { get { return 41057; } }
		public override int UnlitItemID { get { return 41056; } }

		[Constructable]
		public HythlothSculpture()
			: base( 41056 )
		{
			Name = "Wooden Crescent Moon Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public HythlothSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Chalice
	public class HonorSculpture : BaseLight
	{
		public override int LitItemID { get { return 41062; } }
		public override int UnlitItemID { get { return 41061; } }

		[Constructable]
		public HonorSculpture()
			: base( 41061 )
		{
			Name = "Wooden Chalice Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public HonorSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Skull
	public class DestardSculpture : BaseLight
	{
		public override int LitItemID { get { return 41067; } }
		public override int UnlitItemID { get { return 41066; } }

		[Constructable]
		public DestardSculpture()
			: base( 41066 )
		{
			Name = "Wooden Skull Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public DestardSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Tear Drop
	public class  SacrificeSculpture : BaseLight
	{
		public override int LitItemID { get { return 41072; } }
		public override int UnlitItemID { get { return 41071; } }

		[Constructable]
		public SacrificeSculpture()
			: base( 41071 )
		{
			Name = "Wooden Tear Drop Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public SacrificeSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}

	
	
	//2018
	//Hand
	public class HonestySculpture : BaseLight
	{
		public override int LitItemID { get { return 41555; } }
		public override int UnlitItemID { get { return 41554; } }

		[Constructable]
		public HonestySculpture()
			: base( 41554 )
		{
			Name = "Wooden Honesty Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public HonestySculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Heart
	public class CompassionSculpture : BaseLight
	{
		public override int LitItemID { get { return 41560; } }
		public override int UnlitItemID { get { return 41559; } }

		[Constructable]
		public CompassionSculpture()
			: base( 41559 )
		{
			Name = "Wooden Compassion Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public CompassionSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Broken Scales
	public class WrongSculpture : BaseLight
	{
		public override int LitItemID { get { return 41565; } }
		public override int UnlitItemID { get { return 41564; } }

		[Constructable]
		public WrongSculpture()
			: base( 41564 )
		{
			Name = "Wooden Wrong Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public WrongSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Broken Shield
	public class ShameSculpture : BaseLight
	{
		public override int LitItemID { get { return 41570; } }
		public override int UnlitItemID { get { return 41569; } }

		[Constructable]
		public ShameSculpture()
			: base( 41569 )
		{
			Name = "Wooden Shame Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public ShameSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	
	
	//2019
	//Balanced Scales
	public class JusticeSculpture : BaseLight
	{
		public override int LitItemID { get { return 42138; } }
		public override int UnlitItemID { get { return 42137; } }

		[Constructable]
		public JusticeSculpture()
			: base( 42137 )
		{
			Name = "Wooden Balanced Scales Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public JusticeSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Crooks
	public class HumilitySculpture : BaseLight
	{
		public override int LitItemID { get { return 42143; } }
		public override int UnlitItemID { get { return 42142; } }

		[Constructable]
		public HumilitySculpture()
			: base( 42142 )
		{
			Name = "Wooden Crooks Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public HumilitySculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Coin
	public class CovetousSculpture : BaseLight
	{
		public override int LitItemID { get { return 42148; } }
		public override int UnlitItemID { get { return 42147; } }

		[Constructable]
		public CovetousSculpture()
			: base( 42147 )
		{
			Name = "Wooden Coin Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public CovetousSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
	
	//Sceptre
	public class PrideSculpture : BaseLight
	{
		public override int LitItemID { get { return 42153; } }
		public override int UnlitItemID { get { return 42152; } }

		[Constructable]
		public PrideSculpture()
			: base( 42152 )
		{
			Name = "Wooden Sceptre Sculpture";
			Weight = 10.0;
			LootType = LootType.Blessed;

			Light = LightType.Circle300;
			Duration = TimeSpan.Zero;
		}

		public PrideSculpture( Serial serial )
			: base( serial )
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

			/*int version = */
			reader.ReadInt();
		}
	}
}