/***************************
 **    All Dye Tubs				**
 **     X-SirSly-X					**
 ** www.LandofObsidian.com **
 **       ver 1.0					**
 **      2006.04.12				**
 ***************************/

using Server;
using System;
using Server.Items;
using Server.Multis;
using Server.Targeting;
using Server.Mobiles;


namespace Server.Items
{
    public class AllDyeTubsAll : DyeTub
    {
        private int i_charges;
		
        private static int[] m_Hues = new int[]
		{
			0x483, 0x48C, 0x488, 0x48A,
		    0x495, 0x48B, 0x486, 0x485,
			0x48D, 0x490, 0x48E, 0x491,
			0x48F, 0x494, 0x484, 0x497,
			0x489, 0x47F, 0x482, 0x47E
			
		};
		private int m_DyedHue;
        private bool m_Redyable = false;
        private bool m_Charged = true;
        private bool m_AllowPack = true;

        [CommandProperty(AccessLevel.GameMaster)]
        public bool AllowPack
        {
            get { return m_AllowPack; }
            set { m_AllowPack = value; }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public bool Charged
        {
            get { return m_Charged; }
            set { m_Charged = value; }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int Charges
        {
            get { return i_charges; }
            set { i_charges = value; InvalidateProperties(); }
        }

        [Constructable]
        public AllDyeTubsAll()
        {
            Name = "Dye Tub [*Everything*]";
            Weight = 5.0;
            Hue = Utility.RandomList( m_Hues );
            DyedHue = Utility.RandomList( m_Hues );
            Charges = Utility.RandomMinMax(1, 3);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (Charged)
            {
                list.Add(1060658, "Uses Remaining \t{0}", this.Charges);
            }
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (this.IsChildOf(from.Backpack))
            {
                DoPack(from);
            }
            else
            {
                DoOut(from);
            }
        }

        public void DoPack(Mobile from)
        {
            if (AllowPack)
            {
                DoOut(from);
            }
            else
            {
                from.SendMessage("The dyetub cannot be in your pack.");
            }
        }

        public void DoOut(Mobile from)
        {
            if (from.InRange(this.GetWorldLocation(), 1))
            {
                from.SendMessage("Select the item to dye");
                from.Target = new AllDyeTubsAllTarget(this);
            }
            else
            {
                from.SendLocalizedMessage(500446); // That is too far away.
            }
        }

        public AllDyeTubsAll(Serial serial) : base(serial) { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version

            writer.Write((int)m_DyedHue);
            writer.Write((int)i_charges);

            writer.Write((bool)m_Redyable);
            writer.Write((bool)m_Charged);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            m_DyedHue = reader.ReadInt();
            i_charges = reader.ReadInt();

            m_Redyable = reader.ReadBool();
            m_Charged = reader.ReadBool();
        }

        public class AllDyeTubsAllTarget : Target
        {
            private AllDyeTubsAll m_Tub;

            public AllDyeTubsAllTarget(AllDyeTubsAll dyetub) : base(12, false, TargetFlags.None)
            {
                m_Tub = dyetub;
            }

            protected override void OnTarget(Mobile from, object targeted)
            {
                if (targeted is Item)
                {
                    Item item = (Item)targeted;

                    if ( /*item is CarpetColor || */item is SpecialFishingNet)
                    {
                        from.SendMessage("That item cannot be dyed.");
                    }
                    else if (item is AddonComponent)
                    {
                        AddonComponent component = (AddonComponent)targeted;

                        if (component.Addon is DyeRack)
                        {
                            if (m_Tub.DyedHue < 1059)
                                from.SendMessage("This hue cannot be added to rack");
                            else
                            {
                                if (m_Tub.Charged)
                                {
                                    from.PlaySound(0x23F);
                                    from.FixedParticles(14120, 10, 15, 5011, m_Tub.DyedHue, 5, EffectLayer.Waist);

                                    ((DyeRack)component.Addon).AcquireDye(m_Tub.DyedHue, m_Tub.Charges);
                                    from.SendMessage("Hue has been added to rack with number {0}", m_Tub.DyedHue);

                                    m_Tub.Delete();
                                }
                            }
                        }
                        else
                            from.SendMessage("That item cannot be dyed.");
                    }
                    else if (FurnitureAttribute.Check(item) || item is BaseTalisman || item is BaseArmor || item is BaseWeapon || item is IDyable || item is MonsterStatuette || item is EtherealMount || item is Spellbook || item is Runebook || item is RecallRune)
                    {
                        if (!item.IsChildOf(from.Backpack))
                        {
                            from.SendMessage("The item must be in your pack.");
                        }
                        else
                        {
                            item.Hue = m_Tub.DyedHue;

                            if (m_Tub.Charged)
                            {
                                if (m_Tub.Charges <= 1)
                                {
                                    m_Tub.Delete();
                                }
                                m_Tub.Charges = m_Tub.Charges - 1;
                            }
                            from.PlaySound(0x23F);
                            from.FixedParticles(14120, 10, 15, 5011, item.Hue, 5, EffectLayer.Waist);
                        }
                    }
                    else
                    {
                        from.SendMessage("That item cannot be dyed.");
                    }
                }
                else
                {
                    from.SendMessage("You cannot dye that.");
                }
            }
        }
    }
}
