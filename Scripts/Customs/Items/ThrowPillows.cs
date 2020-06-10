using System;

namespace Server.Items
{
	//2016
	//Heart
	[FlipableAttribute(40477, 40478)]
	public class CompassionPillow : Item
	{
		public override string DefaultName{ get { return "A Compassion Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public CompassionPillow ()
			: base(40477)
		{
		}

		public CompassionPillow (Serial serial)
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
	[FlipableAttribute(40479, 40480)]
	public class HonestyPillow : Item
	{
		public override string DefaultName{ get { return "A Honesty Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public HonestyPillow ()
			: base(40479)
		{
		}

		public HonestyPillow (Serial serial)
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
	[FlipableAttribute(40481, 40482)]
	public class ShamePillow : Item
	{
		public override string DefaultName{ get { return "A Shame Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public ShamePillow ()
			: base(40481)
		{
		}

		public ShamePillow (Serial serial)
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
	[FlipableAttribute(40483, 40484)]
	public class WrongPillow : Item
	{
		public override string DefaultName{ get { return "A Wrong Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public WrongPillow ()
			: base(40483)
		{
		}

		public WrongPillow (Serial serial)
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
	//Masks
	[FlipableAttribute(41113, 41114)]
	public class DeceitPillow : Item
	{
		public override string DefaultName{ get { return "A Pair of Masks Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public DeceitPillow ()
			: base(41113)
		{
		}

		public DeceitPillow (Serial serial)
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
	
	//Axe
	[FlipableAttribute(41115, 41116)]
	public class DespisePillow : Item
	{
		public override string DefaultName{ get { return "An Axe Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public DespisePillow ()
			: base(41115)
		{
		}

		public DespisePillow (Serial serial)
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
	[FlipableAttribute(41117, 41118)]
	public class ValorPillow : Item
	{
		public override string DefaultName{ get { return "A Sword Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public ValorPillow ()
			: base(41117)
		{
		}

		public ValorPillow (Serial serial)
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
	[FlipableAttribute(41119, 41120)]
	public class SpiritualityPillow : Item
	{
		public override string DefaultName{ get { return "A Ankh Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public SpiritualityPillow ()
			: base(41119)
		{
		}

		public SpiritualityPillow (Serial serial)
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
	//Crooks
	[FlipableAttribute(41546, 41547)]
	public class HumilityPillow : Item
	{
		public override string DefaultName{ get { return "A Pair of Crooks Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public HumilityPillow ()
			: base(41546)
		{
		}

		public HumilityPillow (Serial serial)
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
	[FlipableAttribute(41548, 41549)]
	public class JusticePillow : Item
	{
		public override string DefaultName{ get { return "A Balanced Scales Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public JusticePillow ()
			: base(41548)
		{
		}

		public JusticePillow (Serial serial)
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
	
	//Sceptre
	[FlipableAttribute(41550, 41551)]
	public class PridePillow : Item
	{
		public override string DefaultName{ get { return "A Sceptre Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public PridePillow ()
			: base(41550)
		{
		}

		public PridePillow (Serial serial)
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
	
	//Coin
	[FlipableAttribute(41552, 41553)]
	public class CovetousPillow : Item
	{
		public override string DefaultName{ get { return "A Coin Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public CovetousPillow ()
			: base(41552)
		{
		}

		public CovetousPillow (Serial serial)
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
	//Chalice
	[FlipableAttribute(42129, 42130)]
	public class HonorPillow : Item
	{
		public override string DefaultName{ get { return "An Honor Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public HonorPillow ()
			: base(42129)
		{
		}

		public HonorPillow (Serial serial)
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
	[FlipableAttribute(42131, 42132)]
	public class SacrificePillow : Item
	{
		public override string DefaultName{ get { return "A Sacrifice Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public SacrificePillow ()
			: base(42131)
		{
		}

		public SacrificePillow (Serial serial)
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
	
	//Crescent Moon
	[FlipableAttribute(42133, 42134)]
	public class HythlothPillow : Item
	{
		public override string DefaultName{ get { return "A Hythloth Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public HythlothPillow ()
			: base(42133)
		{
		}

		public HythlothPillow (Serial serial)
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
	[FlipableAttribute(42135, 42136)]
	public class DestardPillow : Item
	{
		public override string DefaultName{ get { return "A Destard Throw Pillow"; } }
		public override double DefaultWeight{ get { return 1.0; } }
		
		[Constructable]
		public DestardPillow ()
			: base(42135)
		{
		}

		public DestardPillow (Serial serial)
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