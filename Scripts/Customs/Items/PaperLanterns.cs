using System;
using Server;

namespace Server.Items
{
	//2016
	//Tear Drop
	[Flipable]
	public class SacrificeLantern : BaseLight
	{
		[Constructable]
		public SacrificeLantern() : base( 40423 )//1
		{
			Name = "Paper Tear Drop Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public SacrificeLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 40423 )//1
					return 40449;//2
				else
					return 40465;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 40449 )//2
					return 40423;//1
				else
					return 40460;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 40423: 
					this.ItemID = 40460; 
					break;//unlit
				case 40449: 
					this.ItemID = 40465; 
					break;//lit

				case 40460: 
					this.ItemID = 40423; 
					break;//unlit
				case 40465: 
					this.ItemID = 40449; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Skull
	[Flipable]
	public class DestardLantern : BaseLight
	{
		[Constructable]
		public DestardLantern() : base( 40424 )//1
		{
			Name = "Paper Skull Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public DestardLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 40424 )//1
					return 40455;//2
				else
					return 40471;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 40455 )//2
					return 40424;//1
				else
					return 40461;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 40424: 
					this.ItemID = 40461; 
					break;//unlit
				case 40455: 
					this.ItemID = 40471; 
					break;//lit

				case 40461: 
					this.ItemID = 40424; 
					break;//unlit
				case 40471: 
					this.ItemID = 40455; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Crescent Moon
	[Flipable]
	public class HythlothLantern : BaseLight
	{
		[Constructable]
		public HythlothLantern() : base( 40422 )//1
		{
			Name = "Paper Crescent Moon Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public HythlothLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 40422 )//1
					return 40452;//2
				else
					return 40468;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 40452 )//2
					return 40422;//1
				else
					return 40459;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 40422: 
					this.ItemID = 40459; 
					break;//unlit
				case 40452: 
					this.ItemID = 40468; 
					break;//lit

				case 40459: 
					this.ItemID = 40422; 
					break;//unlit
				case 40468: 
					this.ItemID = 40452; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Chalice
	[Flipable]
	public class HonorLantern : BaseLight
	{
		[Constructable]
		public HonorLantern() : base( 40421 )//1
		{
			Name = "Paper Chalice Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public HonorLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 40421 )//1
					return 40446;//2
				else
					return 40462;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 40446 )//2
					return 40421;//1
				else
					return 40458;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 40421: 
					this.ItemID = 40458; 
					break;//unlit
				case 40446: 
					this.ItemID = 40462; 
					break;//lit

				case 40458: 
					this.ItemID = 40421; 
					break;//unlit
				case 40462: 
					this.ItemID = 40446; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	
	
	//2017
	//Coin
	[Flipable]
	public class CovetousLantern : BaseLight
	{
		[Constructable]
		public CovetousLantern() : base( 41076 )//1
		{
			Name = "Paper Coin Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public CovetousLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41076 )//1
					return 41077;//2
				else
					return 41081;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41077 )//2
					return 41076;//1
				else
					return 41080;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41076: 
					this.ItemID = 41080; 
					break;//unlit
				case 41077: 
					this.ItemID = 41081; 
					break;//lit

				case 41080: 
					this.ItemID = 41076; 
					break;//unlit
				case 41081: 
					this.ItemID = 41077; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Sceptre
	[Flipable]
	public class PrideLantern : BaseLight
	{
		[Constructable]
		public PrideLantern() : base( 41084 )//1
		{
			Name = "Paper Sceptre Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public PrideLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41084 )//1
					return 41085;//2
				else
					return 41089;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41085 )//2
					return 41084;//1
				else
					return 41088;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41084: 
					this.ItemID = 41088; 
					break;//unlit
				case 41085: 
					this.ItemID = 41089; 
					break;//lit

				case 41088: 
					this.ItemID = 41084; 
					break;//unlit
				case 41089: 
					this.ItemID = 41085; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Balanced Scales
	[Flipable]
	public class JusticeLantern : BaseLight
	{
		[Constructable]
		public JusticeLantern() : base( 41092 )//1
		{
			Name = "Paper Balanced Scales Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public JusticeLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41092 )//1
					return 41093;//2
				else
					return 41097;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41093 )//2
					return 41092;//1
				else
					return 41096;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41092: 
					this.ItemID = 41096; 
					break;//unlit
				case 41093: 
					this.ItemID = 41097; 
					break;//lit

				case 41096: 
					this.ItemID = 41092; 
					break;//unlit
				case 41097: 
					this.ItemID = 41093; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Crooks
	[Flipable]
	public class HumilityLantern : BaseLight
	{
		[Constructable]
		public HumilityLantern() : base( 41100 )//1
		{
			Name = "Paper Crooks Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public HumilityLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41100 )//1
					return 41101;//2
				else
					return 41105;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41101 )//2
					return 41100;//1
				else
					return 41104;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41100: 
					this.ItemID = 41104; 
					break;//unlit
				case 41101: 
					this.ItemID = 41105; 
					break;//lit

				case 41104: 
					this.ItemID = 41100; 
					break;//unlit
				case 41105: 
					this.ItemID = 41101; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }

	
	
	//2018
	//Ankh
	[Flipable]
	public class SpiritualityLantern : BaseLight
	{
		[Constructable]
		public SpiritualityLantern() : base( 41506 )//1
		{
			Name = "Paper Ankh Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public SpiritualityLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41506 )//1
					return 41507;//2
				else
					return 41511;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41507 )//2
					return 41506;//1
				else
					return 41510;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41506: 
					this.ItemID = 41510; 
					break;//unlit
				case 41507: 
					this.ItemID = 41511; 
					break;//lit

				case 41510: 
					this.ItemID = 41506; 
					break;//unlit
				case 41511: 
					this.ItemID = 41507; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Axe
	[Flipable]
	public class DespiseLantern : BaseLight
	{
		[Constructable]
		public DespiseLantern() : base( 41514 )//1
		{
			Name = "Paper Axe Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public DespiseLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41514 )//1
					return 41515;//2
				else
					return 41519;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41515 )//2
					return 41514;//1
				else
					return 41518;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41514: 
					this.ItemID = 41518; 
					break;//unlit
				case 41515: 
					this.ItemID = 41519; 
					break;//lit

				case 41518: 
					this.ItemID = 41514; 
					break;//unlit
				case 41519: 
					this.ItemID = 41515; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Sword
	[Flipable]
	public class ValorLantern : BaseLight
	{
		[Constructable]
		public ValorLantern() : base( 41522 )//1
		{
			Name = "Paper Sword Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public ValorLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41522 )//1
					return 41523;//2
				else
					return 41527;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41523 )//2
					return 41522;//1
				else
					return 41526;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41522: 
					this.ItemID = 41526; 
					break;//unlit
				case 41523: 
					this.ItemID = 41527; 
					break;//lit

				case 41526: 
					this.ItemID = 41522; 
					break;//unlit
				case 41527: 
					this.ItemID = 41523; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Masks
	[Flipable]
	public class DeceitLantern : BaseLight
	{
		[Constructable]
		public DeceitLantern() : base( 41530 )//1
		{
			Name = "Paper Masks Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public DeceitLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 41530 )//1
					return 41531;//2
				else
					return 41535;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 41531 )//2
					return 41530;//1
				else
					return 41534;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 41530: 
					this.ItemID = 41534; 
					break;//unlit
				case 41531: 
					this.ItemID = 41535; 
					break;//lit

				case 41534: 
					this.ItemID = 41530; 
					break;//unlit
				case 41535: 
					this.ItemID = 41531; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	
	
	//2019
	//Broken Shield
	[Flipable]
	public class ShameLantern : BaseLight
	{
		[Constructable]
		public ShameLantern() : base( 42089 )//1
		{
			Name = "Paper Broken Shield Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public ShameLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 42089 )//1
					return 42090;//2
				else
					return 42094;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 42090 )//2
					return 42089;//1
				else
					return 42093;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 42089: 
					this.ItemID = 42093; 
					break;//unlit
				case 42090: 
					this.ItemID = 42094; 
					break;//lit

				case 42093: 
					this.ItemID = 42089; 
					break;//unlit
				case 42094: 
					this.ItemID = 42090; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Hand
	[Flipable]
	public class HonestyLantern : BaseLight
	{
		[Constructable]
		public HonestyLantern() : base( 42097 )//1
		{
			Name = "Paper Hand Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public HonestyLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 42097 )//1
					return 42098;//2
				else
					return 42102;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 42098 )//2
					return 42097;//1
				else
					return 42101;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 42097: 
					this.ItemID = 42101; 
					break;//unlit
				case 42098: 
					this.ItemID = 42102; 
					break;//lit

				case 42101: 
					this.ItemID = 42097; 
					break;//unlit
				case 42102: 
					this.ItemID = 42098; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Broken Scales
	[Flipable]
	public class WrongLantern : BaseLight
	{
		[Constructable]
		public WrongLantern() : base( 42105 )//1
		{
			Name = "Paper Broken Scales Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public WrongLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 42105 )//1
					return 42106;//2
				else
					return 42110;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 42106 )//2
					return 42105;//1
				else
					return 42109;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 42105: 
					this.ItemID = 42109; 
					break;//unlit
				case 42106: 
					this.ItemID = 42110; 
					break;//lit

				case 42109: 
					this.ItemID = 42105; 
					break;//unlit
				case 42110: 
					this.ItemID = 42106; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
	
	//Heart
	[Flipable]
	public class CompassionLantern : BaseLight
	{
		[Constructable]
		public CompassionLantern() : base( 42113 )//1
		{
			Name = "Paper Heart Lantern";
			Duration = TimeSpan.Zero; // Never burnt out
			Burning = false;
			Light = LightType.Circle300;
			Weight = 1.0;
		}

		public CompassionLantern( Serial serial ) : base( serial )
		{
		}
		
		public override int LitItemID
		{
			get
			{
				if ( this.ItemID == 42113 )//1
					return 42114;//2
				else
					return 42118;//4
			}
		}
		
		public override int UnlitItemID
		{
			get
			{
				if ( this.ItemID == 42114 )//2
					return 42113;//1
				else
					return 42117;//3
			}
		}

		public void Flip()
		{
			this.Light = LightType.Circle300;

			switch ( this.ItemID )
			{
				case 42113: 
					this.ItemID = 42117; 
					break;//unlit
				case 42114: 
					this.ItemID = 42118; 
					break;//lit

				case 42117: 
					this.ItemID = 42113; 
					break;//unlit
				case 42118: 
					this.ItemID = 42114; 
					break;//lit
			}
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}