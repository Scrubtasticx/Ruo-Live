using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.ContextMenus;
using Server.Gumps;
using Server.Network;
using Server.Spells;
using Server.Spells.Seventh;

namespace Server.Mobiles
{
    [CorpseName( "Travel Guide's Corpse" )]
    public class TravelGuide : BaseCreature
    {
		private Moongate m_Gate;
		
		[Constructable]
        public TravelGuide() : base( AIType.AI_Animal, FightMode.None, 10, 1, 0.2, 0.4 )
        {
            Name = "TravelGuide";
            Body = 0x190;
			CantWalk = true;
			Direction = Direction.South;
			Utility.AssignRandomHair( this );
            HairHue = 800;
			SpeechHue = 34; // choose a speech hue
			AddItem( new Robe( Utility.RandomRedHue() ) );
			AddItem( new HalfApron( Utility.RandomRedHue() ) );
			AddItem( new WizardsHat( Utility.RandomRedHue() ) );
			
			// Give it stats so it doesn't die in 1 hit AND can cast gate
			SetStr( 100 );
			SetDex( 25 );
			SetInt( 40 );
			
			Timer.DelayCall( TimeSpan.FromSeconds( 5 ), new TimerCallback( CastGate ) );
        }
		
		private void CastGate()
		{
			string destination = "";
			
            switch( Utility.RandomList( 0, 1 ) ) // for every case you add, add the number here too.
			{
				case 0: 
				{
					m_Gate = new Moongate( new Point3D( 1838, 2535, 0 ), Map ); 
					destination = "Rune Library";
					break;
				}	
				case 1: 
				{
					m_Gate = new Moongate( new Point3D( 1838, 2535, 0 ), Map ); 
					destination = "Rune Library";
					break;
				}	
				default:	Console.WriteLine( "If this text appears, the TravelGuide script is bugged." ); break;
			}

			if( destination!="" )
			{
				new GateTravelSpell( (this as Mobile), null ).Cast();
				Say( "Opening gate to {0}! One way only!", destination );
				Timer.DelayCall( TimeSpan.FromSeconds( 3 ), new TimerCallback( OpenGate ) );
			}
			else
				Console.WriteLine("Error in the TravelGuide script, no destination name assigned (error in switch)");
		}

        private void OpenGate()
        {
			if( m_Gate!=null )
			{
				Effects.PlaySound( Location, Map, 0x20E );
				m_Gate.Dispellable = false;
				m_Gate.MoveToWorld( Location, Map );
				Timer.DelayCall( TimeSpan.FromSeconds( 30 ), new TimerCallback( RemoveGate ) );
			}
			else
				Console.WriteLine("Error in the TravelGuide script, m_Gate is null when it should have been assigned.");
		}
		
		private void RemoveGate()
        {
			m_Gate.Delete();

			m_Gate = null;
			
			Timer.DelayCall( TimeSpan.FromSeconds( 30 ), new TimerCallback( CastGate ) );
		}
			
       
        public TravelGuide( Serial serial ) : base( serial )
        {
        }
		
        public override void Serialize( GenericWriter writer )
        {
			base.Serialize( writer );
       
			writer.Write( (int) 1 );
			writer.Write( m_Gate );
        }
		
        public override void Deserialize( GenericReader reader )
        {
			base.Deserialize( reader );

			int version = reader.ReadInt();
			
			if ( version == 1 )
			{
				m_Gate = reader.ReadItem() as Moongate;
				if( m_Gate != null )
					m_Gate.Delete();
			}
       
			Timer.DelayCall( TimeSpan.FromSeconds( 5 ), new TimerCallback( CastGate ) );
        }
	}
}