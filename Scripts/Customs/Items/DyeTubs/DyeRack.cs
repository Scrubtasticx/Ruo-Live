using System;
using Server.Network;
using System.Collections;
using System.Collections.Generic;
using Server.Gumps;
using Server.Targeting;
using Server.Multis;
using Server.ContextMenus;

namespace Server.Items
{
    public class DyeRack : BaseAddon
    {
        public override BaseAddonDeed Deed
        {
            get
            {
                DyeRackDeed deed = new DyeRackDeed();
                deed.AcquiredDyes = m_AcquiredDyes;

                return deed;
            }
        }

        private SortedDictionary<int, int> m_AcquiredDyes;

        public bool HasDye(int dyeID)
        {
            if (m_AcquiredDyes != null && m_AcquiredDyes.ContainsKey(dyeID))
                return true;

            return false;
        }

        public void AcquireDye(int dyeID, int uses)
        {
            if (m_AcquiredDyes == null)
                m_AcquiredDyes = new SortedDictionary<int, int>();

            if (HasDye(dyeID))
                m_AcquiredDyes[dyeID] += uses;
            else
                m_AcquiredDyes[dyeID] = uses;
        }

        // 		public void ResetDyes()
        // 		{
        // 			m_AcquiredDyes = null;
        // 		}

        [CommandProperty(AccessLevel.GameMaster)]
        public int KnownDyes
        {
            get
            {
                if (m_AcquiredDyes == null)
                    return 0;

                return m_AcquiredDyes.Count;
            }
        }

        public SortedDictionary<int, int> AcquiredDyes
        {
            get
            {
                if (m_AcquiredDyes == null)
                    return null;

                return m_AcquiredDyes;
            }
            set { m_AcquiredDyes = value; }
        }

        [Constructable]
        public DyeRack() : base()
        {
            AddonComponent ac;
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, 0, 0);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, -1, 0);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, 0, 5);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, -1, 5);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, 0, 10);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, -1, 10);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, 1, 0);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, 1, 5);
            ac = new AddonComponent(2860);
            AddComponent(ac, 0, 1, 10);
            ac = new AddonComponent(4011);
            ac.Hue = 1152;
            AddComponent(ac, 0, 1, 12);
            ac = new AddonComponent(4011);
            ac.Hue = 1153;
            AddComponent(ac, 0, 1, 7);
            ac = new AddonComponent(4011);
            ac.Hue = 1159;
            AddComponent(ac, 0, 1, 2);
            ac = new AddonComponent(4011);
            ac.Hue = 1161;
            AddComponent(ac, 0, 0, 12);
            ac = new AddonComponent(4011);
            ac.Hue = 1167;
            AddComponent(ac, 0, 0, 7);
            ac = new AddonComponent(4011);
            ac.Hue = 1169;
            AddComponent(ac, 0, 0, 2);
            ac = new AddonComponent(4011);
            ac.Hue = 1176;
            AddComponent(ac, 0, -1, 12);
            ac = new AddonComponent(4011);
            ac.Hue = 1;
            AddComponent(ac, 0, -1, 7);
            ac = new AddonComponent(4011);
            ac.Hue = 1283;
            AddComponent(ac, 0, -1, 2);
        }

        public DyeRack(Serial serial) : base(serial)
        {
        }

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);

            SetSecureLevelEntry.AddTo(from, this, list);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version

            if (m_AcquiredDyes == null)
            {
                writer.Write((int)0);
            }
            else
            {
                writer.Write(m_AcquiredDyes.Count);

                foreach (KeyValuePair<int, int> kvp in m_AcquiredDyes)
                {
                    writer.Write(kvp.Key);
                    writer.Write(kvp.Value);
                }
            }
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    {
                        int dyesCount = reader.ReadInt();

                        if (dyesCount > 0)
                        {
                            m_AcquiredDyes = new SortedDictionary<int, int>();

                            for (int i = 0; i < dyesCount; i++)
                            {
                                int r = reader.ReadInt();
                                int ri = reader.ReadInt();
                                m_AcquiredDyes.Add(r, ri);
                            }
                        }

                        goto case 0;
                    }
                case 0:
                    {
                        break;
                    }
            }
        }

        public override void OnComponentUsed(AddonComponent c, Mobile from)
        {
            BaseHouse house = BaseHouse.FindHouseAt(this);

            if (!from.InRange(GetWorldLocation(), 2) || !from.InLOS(this) || !((from.Z - Z) > -3 && (from.Z - Z) < 3))
            {
                from.LocalOverheadMessage(Network.MessageType.Regular, 0x3B2, 1019045); // I can't reach that.
            }
            else if (house != null && (house.HasSecureAccess(from, SecureLevel.Friends) || house.HasSecureAccess(from, SecureLevel.Guild) || from.AccessLevel > AccessLevel.Player))
            {
                if (KnownDyes > 0)
                {
                    if (from.HasGump(typeof(DyeRackGump)))
                        from.CloseGump(typeof(DyeRackGump));

                    from.SendGump(new DyeRackGump(this));
                }
                else
                    from.SendMessage("Dye rack is empty");
            }
            else
                from.SendLocalizedMessage(1061637); // You are not allowed to access this.
        }

        private class DyeRackGump : Gump
        {
            private static readonly int m_Fields = 20;
            private static readonly int m_HueTit = 0;
            private static readonly int m_HueEnt = 0;
            private static readonly int m_DeltaBut = 2;
            private static readonly int m_FieldsDist = 36;

            private DyeRack m_Box;
            private List<int> m_Dyes;
            private int m_Page;

            public DyeRackGump(DyeRack box) : this(box, null, 1)
            {
            }

            public DyeRackGump(DyeRack box, List<int> dyes, int page) : base(50, 50)
            {
                Closable = false;
                Disposable = true;
                Dragable = true;
                Resizable = false;

                m_Box = box;
                m_Dyes = dyes;
                m_Page = page;

                if (m_Dyes == null)
                    m_Dyes = new List<int>(m_Box.AcquiredDyes.Keys);

                Initialize();
            }

            public void Initialize()
            {
                if (m_Box.KnownDyes < 1)
                    return;

                AddPage(0);

                AddBackground(0, 0, 375, 455, 9200);

                AddImageTiled(10, 10, 355, 25, 9354);
                AddImageTiled(10, 45, 355, 370, 9354);
                AddImageTiled(40, 425, 325, 20, 9354);

                AddButton(10, 425, 4017, 4018, 0, GumpButtonType.Reply, 0);
                AddHtmlLocalized(45, 425, 75, 20, 1011012, m_HueTit, false, false); // CANCEL

                // 				AddAlphaRegion(10, 10, 355, 415);
                // 				AddAlphaRegion(40, 425, 325, 20);
                AddLabelCropped(14, 12, 355, 25, m_HueTit, String.Format("Dyes rack (Hues count: {0})", m_Box.KnownDyes));
                // 	            AddHtmlLocalized( 14, 12, 355, 25, 1049753, m_HueTit, false, false ); // Dye Tubs

                if (m_Page > 1)
                    AddButton(325, 427, 5603, 5607, 2, GumpButtonType.Reply, 0); // Previous page

                if (m_Page < Math.Ceiling(m_Dyes.Count / (double)m_Fields))
                    AddButton(345, 427, 5601, 5605, 3, GumpButtonType.Reply, 0); // Next Page

                int IndMax = (m_Page * m_Fields) - 1;
                int IndMin = (m_Page * m_Fields) - m_Fields;
                int IndTemp = 0;
                int RightTemp = 0;

                for (int i = 0; i < m_Dyes.Count; i++)
                {
                    if (i >= IndMin && i <= IndMax)
                    {
                        AddLabelCropped(35 + RightTemp, 52 + (IndTemp * m_FieldsDist), 225, 20, m_HueTit, String.Format("{0} ({1})", m_Dyes[i], m_Box.AcquiredDyes[m_Dyes[i]]));
                        AddButton(15 + RightTemp, 52 + m_DeltaBut + (IndTemp * m_FieldsDist), 1209, 1210, i + 10, GumpButtonType.Reply, 0);
                        AddItem(100 + RightTemp, 50 + (IndTemp * m_FieldsDist), 4011, m_Dyes[i]);
                        IndTemp++;

                        if ((m_Fields / 2) == IndTemp)
                        {
                            IndTemp = 0;
                            RightTemp = 200;
                        }
                    }
                }
            }


            public override void OnResponse(NetState sender, RelayInfo info)
            {
                Mobile from = sender.Mobile;

                if (info.ButtonID == 0)
                    return;
                else if (info.ButtonID == 2) // Previous page
                {
                    m_Page--;
                    from.SendGump(new DyeRackGump(m_Box, m_Dyes, m_Page));
                }
                else if (info.ButtonID == 3)  // Next Page
                {
                    m_Page++;
                    from.SendGump(new DyeRackGump(m_Box, m_Dyes, m_Page));
                }
                else
                {
                    from.SendMessage("Target dye testing mirror, dye thinner or item you want to hue");
                    from.Target = new DyeRackTarget(m_Box, m_Dyes[info.ButtonID - 10]);
                    //                from.SendGump( new DyeRackGump( m_Box, m_Dyes, m_Page ) );
                }
            }
        }

        private class DyeRackTarget : Target
        {
            private DyeRack m_Box;
            private int m_Hue;

            public DyeRackTarget(DyeRack box, int hue) : base(30, false, TargetFlags.None)
            {
                m_Box = box;
                m_Hue = hue;
            }

            protected override void OnTarget(Mobile from, object target)
            {
                if (from == null || m_Box == null || m_Box.Deleted)
                    return;

                if (!m_Box.HasDye(m_Hue)) //Sanity
                {
                    from.SendMessage("That hue is not in rack");
                    return;
                }

                if (target is DyeTester)
                {
                    DyeTester.TestHue(from, m_Hue);
                    return;
                }

                Item item;

                if (target is Item)
                {
                    item = (Item)target;

                    if (!from.InRange(m_Box.GetWorldLocation(), 5) || !item.IsChildOf(from.Backpack))
                    {
                        from.SendMessage("You must stay close to rack and have item in your backpack");
                        return;
                    }
                }
                else
                {
                    from.SendMessage("That is not item");
                    return;
                }

                if ( /*item is CarpetColor || */item is SpecialFishingNet)
                {
                    from.SendMessage("That item cannot be hued");
                    return;
                }

                if (FurnitureAttribute.Check(item) || item is BaseTalisman || item is BaseArmor || item is BaseWeapon || item is IDyable || item is MonsterStatuette || item is Server.Mobiles.EtherealMount || item is Spellbook || item is Runebook || item is RecallRune)
                {
                    if (m_Box.AcquiredDyes[m_Hue] < 1)
                    {
                        from.SendMessage("That hue is dryed. You can only test it on mirror or thin it.");
                        return;
                    }

                    item.Hue = m_Hue;
                    m_Box.AcquiredDyes[m_Hue]--;
                    from.FixedParticles(14120, 1, 10, 0x1F78, m_Hue, 5, EffectLayer.Waist);
                    from.PlaySound(0x23F);
                    from.SendMessage("Hue number {0} Has been used. {1} charges left.", m_Hue, m_Box.AcquiredDyes[m_Hue]);
                }
                else if (item is DyeThinner)
                {
                    item.Consume();
                    m_Box.AcquiredDyes[m_Hue]++;
                    from.FixedParticles(14120, 1, 10, 0x1F78, m_Hue, 5, EffectLayer.Waist);
                    from.PlaySound(32);
                    from.PlaySound(574);
                    from.SendMessage("Hue number {0} has been thinned for {1} charges", m_Hue, m_Box.AcquiredDyes[m_Hue]);
                }
                else
                    from.SendMessage("That item cannot be hued");

                if (m_Box.KnownDyes > 0)
                {
                    if (from.HasGump(typeof(DyeRackGump)))
                        from.CloseGump(typeof(DyeRackGump));

                    from.SendGump(new DyeRackGump(m_Box));
                }
            }
        }
    }

    #region deed

    public class DyeRackDeed : BaseAddonDeed
    {
        public override BaseAddon Addon
        {
            get
            {
                DyeRack addon = new DyeRack();
                addon.AcquiredDyes = m_AcquiredDyes;

                return addon;
            }
        }

        private SortedDictionary<int, int> m_AcquiredDyes;

        [CommandProperty(AccessLevel.GameMaster)]
        public int KnownDyes
        {
            get
            {
                if (m_AcquiredDyes == null)
                    return 0;

                return m_AcquiredDyes.Count;
            }
        }

        public SortedDictionary<int, int> AcquiredDyes
        {
            get
            {
                if (m_AcquiredDyes == null)
                    return null;

                return m_AcquiredDyes;
            }
            set { m_AcquiredDyes = value; }
        }

        [Constructable]
        public DyeRackDeed()
        {
            Name = "dyes rack";
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
            list.Add(1060658, "Number of hues\t{0}", KnownDyes);
        }

        public DyeRackDeed(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version

            if (m_AcquiredDyes == null)
            {
                writer.Write((int)0);
            }
            else
            {
                writer.Write(m_AcquiredDyes.Count);

                foreach (KeyValuePair<int, int> kvp in m_AcquiredDyes)
                {
                    writer.Write(kvp.Key);
                    writer.Write(kvp.Value);
                }
            }
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    {
                        int dyesCount = reader.ReadInt();

                        if (dyesCount > 0)
                        {
                            m_AcquiredDyes = new SortedDictionary<int, int>();

                            for (int i = 0; i < dyesCount; i++)
                            {
                                int r = reader.ReadInt();
                                int ri = reader.ReadInt();
                                m_AcquiredDyes.Add(r, ri);
                            }
                        }

                        goto case 0;
                    }
                case 0:
                    {
                        break;
                    }
            }
        }
    }

    #endregion
}


