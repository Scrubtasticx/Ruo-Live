using System;
using Server;
using Server.Items;

namespace Server.Items
{

    public class TrammyBarStool : BaseHat
    {
	
		private static int[] m_Hues = new int[]
		{
			0x483, 0x48C, 0x488, 0x48A,
		    0x495, 0x48B, 0x486, 0x485,
			0x48D, 0x490, 0x48E, 0x491,
			0x48F, 0x494, 0x484, 0x497,
			0x489, 0x47F, 0x482, 0x47E
			
		};
		
        [Constructable]
        public TrammyBarStool() : base( 0x1547 )
        {
            Weight = 5.0;
            Name = "Trammy Barstool";
			Hue = Utility.RandomList( m_Hues );
            LootType = LootType.Blessed;
        }

        public override bool Dye(Mobile from, DyeTub sender)
        {
            from.SendLocalizedMessage(sender.FailMessage);
            return false;
        }

        public TrammyBarStool(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}