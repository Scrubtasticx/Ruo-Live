using System;
using Server.Network;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Gumps;
using Server.Targeting;
using Server.Multis;
using Server.ContextMenus;

namespace Server.Items
{
    [FlipableAttribute(10875, 10877)]
    public class DyeTester : Item, ISecurable
    {
        private SecureLevel m_Level;

        [CommandProperty(AccessLevel.GameMaster)]
        public SecureLevel Level
        {
            get { return m_Level; }
            set { m_Level = value; }
        }

        [Constructable]
        public DyeTester() : base(10875)
        {
            Weight = 1.0;
            Name = "dye testing mirror";
            Movable = true;
            Hue = 0;
        }

        public DyeTester(Serial serial) : base(serial)
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

            writer.WriteEncodedInt((int)m_Level);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    {
                        m_Level = (SecureLevel)reader.ReadEncodedInt();
                        goto case 0;
                    }
                case 0:
                    {
                        break;
                    }
            }
        }

        public override void OnDoubleClick(Mobile from)
        {
            from.SendMessage("Target dye tub with hue you want to display.");
            from.Target = new DyeTesterTarget();
        }

        public static void TestHue(Mobile from, int hue)
        {
            if (hue < 1)
            {
                from.SendMessage("You must target hued dye tub.");
                return;
            }
            else if (from.SolidHueOverride > 0)
            {
                from.SendMessage("You are already hued.");
                return;
            }
            else
            {
                from.SolidHueOverride = hue;
                from.FixedParticles(14120, 1, 10, 0x1F78, hue, 5, EffectLayer.Waist);
                from.PlaySound(32);
                from.PlaySound(574);
                from.SendMessage("Your skin and equipment has been hued for 10 seconds");
                Timer.DelayCall(TimeSpan.FromSeconds(10.0), new TimerStateCallback(RemoveTestingHue), from);
            }
        }

        public static void RemoveTestingHue(object state)
        {
            ((Mobile)state).SolidHueOverride = -1;
        }

        private class DyeTesterTarget : Target
        {
            public DyeTesterTarget() : base(30, false, TargetFlags.None)
            {
            }

            protected override void OnTarget(Mobile from, object target)
            {
                if (target is DyeTub/* || target is PayDyeTub*/ )
                {
                    int hue = ((DyeTub)target).DyedHue;// ( target is DyeTub ) ? ((DyeTub)target).DyedHue : ((PayDyeTub)target).DyedHue;

                    TestHue(from, hue);
                }
                else
                    from.SendMessage("You must target dye tub");
            }
        }
    }
}


