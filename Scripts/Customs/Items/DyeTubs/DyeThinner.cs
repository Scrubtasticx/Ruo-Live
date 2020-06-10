using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
    public class DyeThinner : Item
    {
        [Constructable]
        public DyeThinner() : this(1)
        {
        }

        [Constructable]
        public DyeThinner(int amount) : base(3854)
        {
            Weight = 1.0;
            Hue = 93;
            Stackable = true;
            Name = "dye thinner";
            //LootType = LootType.Blessed;
            Amount = amount;
        }

        public DyeThinner(Serial serial) : base(serial)
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

        public override bool DisplayLootType { get { return false; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack
            {
                from.SendLocalizedMessage(1060640);
            }
            else
            {
                from.SendMessage("What hue you want to thin?");
                from.Target = new DyeThinnerTarget(this);
            }
        }

        private class DyeThinnerTarget : Target
        {
            private DyeThinner m_Thinner;

            public DyeThinnerTarget(DyeThinner thinner) : base(1, false, TargetFlags.None)
            {
                m_Thinner = thinner;
            }

            protected override void OnTarget(Mobile from, object target)
            {
                if (!(target is AllDyeTubsAll))
                {
                    from.SendMessage("Can be used only for Dye Tub [*Everything*]!");
                    return;
                }

                AllDyeTubsAll tub = (AllDyeTubsAll)target;

                if (tub == null || !tub.Charged)
                    from.SendMessage("You cannot use it on uncharged dye tub!");
                else if (!tub.IsChildOf(from.Backpack) || !m_Thinner.IsChildOf(from.Backpack))
                    from.SendMessage("You must have thinner and dye tub in you backpack");
                else
                {
                    m_Thinner.Consume();
                    tub.Charges++;
                    from.FixedParticles(14120, 1, 10, 0x1F78, tub.DyedHue, 5, EffectLayer.Waist);
                    from.PlaySound(32);
                    from.PlaySound(574);
                    from.SendMessage("Hue has been thinned");
                }
            }
        }
    }
}


