using System;

namespace Server.Items
{
	//2016
	//Coin
	[FlipableAttribute(40493, 40494)]
	public class CovetousTapestry : Item
	{
		public override string DefaultName{ get { return "A Covetous Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public CovetousTapestry ()
			: base(40493)
		{
		}

		public CovetousTapestry (Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Scepter
	[FlipableAttribute(40495, 40496)]
	public class PrideTapestry : Item
	{
		public override string DefaultName{ get { return "A Pride Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public PrideTapestry ()
			: base(40495)
		{
		}

		public PrideTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Crooks
	[FlipableAttribute(40497, 40498)]
	public class HumilityTapestry : Item
	{
		public override string DefaultName{ get { return "A Humility Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public HumilityTapestry ()
			: base(40497)
		{
		}

		public HumilityTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Balanced Scales
	[FlipableAttribute(40499, 40500)]
	public class JusticeTapestry : Item
	{
		public override string DefaultName{ get { return "A Justice Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public JusticeTapestry ()
			: base(40499)
		{
		}

		public JusticeTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	
	
	//2017
	//Heart
	[FlipableAttribute(41123, 41124)]
	public class CompassionTapestry : Item
	{
		public override string DefaultName{ get { return "A Heart Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public CompassionTapestry ()
			: base(41124)
		{
		}

		public CompassionTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Broken Shield
	[FlipableAttribute(41125, 41126)]
	public class ShameTapestry : Item
	{
		public override string DefaultName{ get { return "A Broken Shield Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public ShameTapestry ()
			: base(41126)
		{
		}

		public ShameTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Hand
	[FlipableAttribute(41127, 41128)]
	public class HonestyTapestry : Item
	{
		public override string DefaultName{ get { return "A Hand Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public HonestyTapestry ()
			: base(41128)
		{
		}

		public HonestyTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Broken Scales
	[FlipableAttribute(41129, 41130)]
	public class WrongTapestry : Item
	{
		public override string DefaultName{ get { return "A Broken Scales Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public WrongTapestry ()
			: base(41130)
		{
		}

		public WrongTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}

	
	
	//2018
	//Crescent Moon
	[FlipableAttribute(41538, 41539)]
	public class HythlothTapestry : Item
	{
		public override string DefaultName{ get { return "A Hythloth Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public HythlothTapestry ()
			: base(41539)
		{
		}

		public HythlothTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Tear Drop
	[FlipableAttribute(41542, 41543)]
	public class SacrificeTapestry : Item
	{
		public override string DefaultName{ get { return "A Sacrifice Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public SacrificeTapestry ()
			: base(41542)
		{
		}

		public SacrificeTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Chalice
	[FlipableAttribute(41544, 41545)]
	public class HonorTapestry : Item
	{
		public override string DefaultName{ get { return "A Honor Drop Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public HonorTapestry ()
			: base(41544)
		{
		}

		public HonorTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Skull
	[FlipableAttribute(41540, 41541)]
	public class DestardTapestry : Item
	{
		public override string DefaultName{ get { return "A Skull Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public DestardTapestry ()
			: base(41540)
		{
		}

		public DestardTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	
	
	//2019
	//Axe
	[FlipableAttribute(42121, 42122)]
	public class DespiseTapestry : Item
	{
		public override string DefaultName{ get { return "An Axe Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public DespiseTapestry ()
			: base(42121)
		{
		}

		public DespiseTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Sword
	[FlipableAttribute(42123, 42124)]
	public class ValorTapestry : Item
	{
		public override string DefaultName{ get { return "A Sword Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public ValorTapestry ()
			: base(42123)
		{
		}

		public ValorTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Ankh
	[FlipableAttribute(42125, 42126)]
	public class SpiritualityTapestry : Item
	{
		public override string DefaultName{ get { return "An Ankh Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public SpiritualityTapestry ()
			: base(42125)
		{
		}

		public SpiritualityTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
	
	//Masks
	[FlipableAttribute(42127, 42128)]
	public class DeceitTapestry : Item
	{
		public override string DefaultName{ get { return "A Pair of Masks Tapestry"; } }
		public override double DefaultWeight{ get { return 5.0; } }
		
		[Constructable]
		public DeceitTapestry ()
			: base(42127)
		{
		}

		public DeceitTapestry(Serial serial)
			: base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int)0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}