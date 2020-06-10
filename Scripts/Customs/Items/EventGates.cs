// Murzin @ RunUO Event Gate System.  Version 1.0
// on install of this system, uncomment out line # 23, load server, save, close server and then comment out that line
// this will make sure you dont have problems with the moongate locations duplicating every restart.
// to customize the hue of the entrance moongates, uncomment and add hue# to line# 470

using System;
using Server;
using Server.Items; 
using Server.Mobiles;
using System.Collections; 
using Server.Misc;
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions;
using Server.Prompts;

namespace Server.Commands 
{
	public class egate  //  initializes the command
	{

		//public static EGCPersi Info = new EGCPersi();  // initialize the persisitent item for saving/retreiving values

		public static void Initialize() 
		{ 
			CommandSystem.Register( "egate", AccessLevel.GameMaster, new CommandEventHandler( egate_OnCommand ) );
			CommandSystem.Register( "egatefill", AccessLevel.Owner, new CommandEventHandler( egatefill_OnCommand ) );
			CommandSystem.Register( "egateclear", AccessLevel.Owner, new CommandEventHandler( egateclear_OnCommand ) );
		} 

		[Usage( "egate" )]
		[Description( "Allows you to call Event System Gump." )]
		public static void egate_OnCommand(CommandEventArgs e)
		{
				CommandLogging.WriteLine( e.Mobile, " accessed the egate gump." );
                e.Mobile.CloseGump(typeof(egategump));
				e.Mobile.SendGump( new egategump() );
		}

		[Usage( "egateclear" )]
		[Description( "Clears the Event Gate List." )]
		public static void egateclear_OnCommand(CommandEventArgs e)
		{
			CommandLogging.WriteLine( e.Mobile, " Clearing the Event Gate System gates list." );
			Server.Items.EGCPersi.EGCPers.Clear();
            e.Mobile.CloseGump(typeof(egategump));
			e.Mobile.SendGump( new egategump() );
		}

		[Usage( "egatefill" )]
		[Description( "Fills the Event Gate List with city entrances." )]
		public static void egatefill_OnCommand(CommandEventArgs e)
		{

			CommandLogging.WriteLine( e.Mobile, " Entering generic gates to the Event Gate System gates list." );
			Point3D loc;
			Map map;
			string name;

			map = Map.Felucca; loc = new Point3D(1431,1701,7); name = "Britian Bank in Felucca";
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			loc = new Point3D(2238,1195,0); name = "Cove Bank in Felucca";
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			loc = new Point3D(5268,3994,37); name = "Delucia Bank in Felucca";
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Haven Bank in Felucca"; loc = new Point3D(3628,2605,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Jhelom Bank in Felucca"; loc = new Point3D(1324,3783,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Magincia Bank in Felucca"; loc = new Point3D(3731,2165,20);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Minoc Bank in Felucca"; loc = new Point3D(2510,563,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Moonglow bank in Felucca"; loc = new Point3D(4459,1172,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Nujel'm Bank in Felucca"; loc = new Point3D(3772,1307,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Papua Bank in Felucca"; loc = new Point3D(5675,3143,12);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Serpent's Hold Bank in Felucca"; loc = new Point3D(2893,3476,15);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Skara Brae Bank in Felucca"; loc = new Point3D(596,2156,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Trinsic Bank in Felucca"; loc = new Point3D(1826,2821,0);
			Server.Items.EGCPersi.EGCPers.Add( new EGEntry(loc, map, name) );
			name = "Vesper Bank in Felucca"; loc = new Point3D(2900,675,0);
            e.Mobile.CloseGump(typeof(egategump));
			e.Mobile.SendGump( new egategump() );
		}
	}
}

namespace Server.Gumps
{
	public class egategump : Gump
	{
		public egategump() : base( 0, 0 )
		{

			Closable=true;
			Disposable=true;
			Dragable=true;
			Resizable=false;

			AddPage(1);
			AddBackground(30, 30, 300, 300, 9200);
			AddLabel(100, 44, 0, "Event Moongate System");
			AddLabel(40, 80, 0, "Moongate Entrances");
			AddLabel(40, 110, 0, "Moongate Exit");
			AddLabel(40, 140, 0, "Moongate Duration");
			AddButton(250, 80, 1154, 1153, 1, GumpButtonType.Page, 5);
			AddButton(250, 110, 1154, 1153, 2, GumpButtonType.Page, 2);
			AddButton(250, 140, 1154, 1153, 3, GumpButtonType.Page, 3);
			AddButton(58, 270, 1149, 1147, 4, GumpButtonType.Reply, 0);
			AddButton(148, 270, 1146, 1145, 5, GumpButtonType.Reply, 0);
			AddButton(246, 278, 5508, 5507, 6, GumpButtonType.Page, 4);

			AddPage(2);
			AddBackground(30, 30, 300, 300, 9200);
			AddLabel(130, 45, 0, "Moongate Exit");
			AddLabel(110, 85, 0, "Go to current location");
			AddLabel(110, 150, 0, "Set as current location");
			AddButton(150, 115, 247, 248, 21, GumpButtonType.Reply, 0);
			AddButton(150, 185, 247, 248, 22, GumpButtonType.Reply, 0);
			AddButton(40, 296, 4016, 4015, 7, GumpButtonType.Page, 1 );

			AddPage(3);
			AddBackground(30, 30, 300, 300, 9200);
			AddLabel(120, 40, 0, "Moongate Duration");
			AddLabel(40, 69, 0, "1 Minute");
			AddLabel(40, 98, 0, "3 Minutes");
			AddLabel(40, 127, 0, "5 Minutes");
			AddLabel(40, 156, 0, "10 Minutes");
			AddLabel(40, 185, 0, "15 Minutes");
			AddLabel(40, 214, 0, "30 Minutes");
			AddLabel(40, 243, 0, "45 Minutes");
			AddLabel(40, 272, 0, "60 Minutes");
			AddButton(160, 69, 4025, 4024, 30, GumpButtonType.Reply, 0);
			AddButton(160, 98, 4025, 4024, 31, GumpButtonType.Reply, 0);
			AddButton(160, 127, 4025, 4024, 32, GumpButtonType.Reply, 0);
			AddButton(160, 156, 4025, 4024, 33, GumpButtonType.Reply, 0);
			AddButton(160, 185, 4025, 4024, 34, GumpButtonType.Reply, 0);
			AddButton(160, 214, 4025, 4024, 35, GumpButtonType.Reply, 0);
			AddButton(160, 243, 4025, 4024, 36, GumpButtonType.Reply, 0);
			AddButton(160, 272, 4025, 4024, 37, GumpButtonType.Reply, 0);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(1) ) // these lines of code add the indicator
				AddImage(240, 74, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(3) ) // to the duration gump indicating what the
				AddImage(240, 103, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(5) ) // current duration is set for gates
				AddImage(240, 132, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(10) )
				AddImage(240, 161, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(15) )
				AddImage(240, 190, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(30) )
				AddImage(240, 219, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(45) )
				AddImage(240, 248, 2223);

			if ( Server.Items.EGCPersi.EGCDur == TimeSpan.FromMinutes(60) )
				AddImage(240, 277, 2223);

			AddButton(40, 299, 4016, 4015, 7, GumpButtonType.Page, 1 );

			AddPage(4);
			AddBackground(30, 30, 300, 300, 9200);
			AddLabel(100, 48, 37, "Event System Moongates");
			AddLabel(174, 90, 37, "by");
			AddLabel(158, 136, 37, "Murzin");
			AddLabel(174, 180, 37, "@");
			AddLabel(162, 228, 37, "RunUO");
			AddButton(152, 270, 1112, 1111, 30, GumpButtonType.Page, 1);

			AddPage(5);
			AddBackground(30, 30, 300, 300, 9200);
			AddLabel(105, 45, 0, "Moongate Entrances");
			AddLabel(80, 298, 0, "Add current location");
			AddButton(210, 296, 247, 248, 10, GumpButtonType.Reply, 0);
			AddButton(40, 296, 4016, 4015, 7, GumpButtonType.Page, 1 );

			int listcount = Server.Items.EGCPersi.EGCPers.Count;

			if( listcount > 4 )
				AddButton(299, 296, 4007, 4006, 8, GumpButtonType.Page, 6 );

			if( listcount > 0 )  // make sure the array has values before we see about adding buttons for arraylist entries
			{
				int page = 5;
				int tempcount = 0;

				for( int x = 0; x < listcount; x++ ) // begin dynamic loading of arraylist entries
				{
					Point3D loc = ((EGEntry)Server.Items.EGCPersi.EGCPers[x]).Location;
					Map map = ((EGEntry)Server.Items.EGCPersi.EGCPers[x]).Map;
					string text = ((EGEntry)Server.Items.EGCPersi.EGCPers[x]).Description;

					if( (EGEntry)Server.Items.EGCPersi.EGCPers[x] != null ) // adding each entry, 4 per page
					{
						tempcount++;
						AddLabel( 80, ((50*tempcount)+30), 0, String.Format( "{0} {1}", loc.ToString(), map.ToString() ) );
						AddLabel( 80, ((50*tempcount)+50), 0, String.Format( "{0}", text ) );
						AddButton( 40, ((50*tempcount)+50), 4019, 4018, (x+2000), GumpButtonType.Reply, 0);
						AddButton( 40, ((50*tempcount)+30), 4010, 4009, (x+10000), GumpButtonType.Reply, 0);
					}

					if( tempcount == 4 ) // at 4 entries, add a new page
					{
						page++;
						string name = ("Moongate Entrances, Page " + (page - 4).ToString() );
						AddPage(page);
						AddBackground(30, 30, 300, 300, 9200);
						AddLabel(105, 45, 0, name);
						AddButton(40, 296, 4016, 4015, 7, GumpButtonType.Page, (page - 1) );

						if( ( x + 5 ) < listcount )
							AddButton(299, 296, 4007, 4006, 8, GumpButtonType.Page, (page + 1) );

						tempcount = 0;
					}
				}
			}
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;
            from.CloseGump(typeof(egategump));
			switch ( info.ButtonID )
			{
				case 0: {  // this is right click on gump
                       break;
					}
				case 4: {  // this case starts the event
						BEvent( from );
						break;
					}
				case 5: {  // this is cancel button in gump
                       break;
					}
				case 10: {  // this case adds current location as moongate entrance location

						int listcount = Server.Items.EGCPersi.EGCPers.Count;
						bool exists = false;
						Point3D test1 = from.Location;
						Map test2 = from.Map;
						string desc = "";

						if ( listcount > 0 )
						{
							for ( int i = 0; i < listcount; i++ )
							{
								Point3D loc = ((EGEntry)Server.Items.EGCPersi.EGCPers[i]).Location;
								Map map = ((EGEntry)Server.Items.EGCPersi.EGCPers[i]).Map;

								if( test1 == loc && test2 == map )
								{
									from.SendMessage( "This location is already in the entrance moongate list!" );
									exists = true;
								}
							}
						}

						if ( !(exists) )
						{
							from.SendMessage( "Enter the Description for this location" );
							from.Prompt = new EGCPrompt( test1, test2, desc );
						}
						break;
					}
				case 21: { // this is the case to teleport you to exit destination
						if ( Server.Items.EGCPersi.EGCDest != Point3D.Zero && Server.Items.EGCPersi.EGCMap != null )
						{

							Console.WriteLine( "dest is " + Server.Items.EGCPersi.EGCDest.ToString() + " ." );
							from.MoveToWorld( Server.Items.EGCPersi.EGCDest, Server.Items.EGCPersi.EGCMap );
						}
						else
						{
							from.SendMessage( "Either the map or location is not set yet!" );
						}
 						from.SendGump( new egategump() );
						break;
					}
				case 22: {  // this case sets the users current loc as destination
						Server.Items.EGCPersi.EGCDest = ((Mobile)from).Location;
						Server.Items.EGCPersi.EGCMap = ((Mobile)from).Map;
						Console.WriteLine( "dest is " + Server.Items.EGCPersi.EGCDest.ToString() + " ." );
						from.SendGump( new egategump() );
						break;
					}
				case 30: { // this sets the moongate duration to 1 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(1);
						from.SendGump( new egategump() );
						break;
					}
				case 31: { // this sets the moongate duration to 3 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(3);
						from.SendGump( new egategump() );
						break;
					}
				case 32: { // this sets the moongate duration to 5 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(5);
						from.SendGump( new egategump() );
						break;
					}
				case 33: {  // this sets the moongate duration to 10 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(10);
						from.SendGump( new egategump() );
						break;
					}
				case 34: { // this sets the moongate duration to 15 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(15);
						from.SendGump( new egategump() );
						break;
					}
				case 35: { // this sets the moongate duration to 30 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(30);
						from.SendGump( new egategump() );
						break;
					}
				case 36: { // this sets the moongate duration to 45 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(45);
						from.SendGump( new egategump() );
						break;
					}
				case 37: { // this sets the moongate duration to 60 minutes before they auto-delete
						Server.Items.EGCPersi.EGCDur = TimeSpan.FromMinutes(60);
						from.SendGump( new egategump() );
						break;
					}
			}

			if ( info.ButtonID >= 2000 && info.ButtonID < 10000) // this code removes entries from the arraylist
			{
                try // try/catch for crash protection
                {
                    int removeentry = info.ButtonID - 2000;
                    Point3D test1 = ((EGEntry)Server.Items.EGCPersi.EGCPers[removeentry]).Location;
                    Map test2 = ((EGEntry)Server.Items.EGCPersi.EGCPers[removeentry]).Map;
                    string test3 = ((EGEntry)Server.Items.EGCPersi.EGCPers[removeentry]).Description;
                    from.SendMessage("You are removing the following entry: {0} {1} {2}", test1.ToString(), test2.ToString(), test3.ToString());
                    Server.Commands.CommandLogging.WriteLine(from, " Removed an Egate entry at {0} location, {1} map with description of {2}.", test1.ToString(), test2.ToString(), test3.ToString());
                    Server.Items.EGCPersi.EGCPers.RemoveAt(removeentry);
                    from.SendGump(new egategump());
                }
                catch
                {
                    from.SendMessage("There was a problem removing that entry, please try again.");
                    from.SendGump(new egategump());
                }
			}

			if ( info.ButtonID >= 10000 && info.ButtonID < 18001 ) // code to teleport to entry 
			{
				try // try/catch for crash protection
				{
					int gotoentry = info.ButtonID-10000;
					Point3D test1 = ((EGEntry)Server.Items.EGCPersi.EGCPers[gotoentry]).Location;
					Map test2 = ((EGEntry)Server.Items.EGCPersi.EGCPers[gotoentry]).Map;
					string test3 = ((EGEntry)Server.Items.EGCPersi.EGCPers[gotoentry]).Description;
					from.SendMessage( "Travelling to: {0} at location {1} on map {2}.", test3, test1.ToString(), test2.ToString() );
					from.Map = test2;
					from.Location = test1;
 					from.SendGump( new egategump() );
				}
				catch
				{
					from.SendMessage( "There was a problem travelling to that location, please try again." );
					from.SendGump( new egategump() );
				}
			}
		}

		private class EGCPrompt : Prompt  // this is the prompt class that lets you name locations
		{
			private string i_desc;
			private Point3D i_loc;
			private Map i_map;

			public EGCPrompt( Point3D loc, Map map, string text )  // this is the pass constructor from gump
			{
				i_desc = text;
				i_loc = loc;
				i_map = map;
			}

			public override void OnResponse( Mobile from, string desc )  // this is code that adds entry after text is typed
			{
				i_desc = desc;

				if ( i_desc == null || (i_desc = i_desc.Trim()).Length == 0 || i_desc == "" )
					i_desc = "an unknown location";

				Server.Items.EGCPersi.EGCPers.Add( new EGEntry(i_loc, i_map, i_desc) );
				from.SendMessage( "This location is added to the moongate entrance list." );

				from.SendMessage( "new location added, {0} and {1} and {2}", i_loc, i_map, i_desc );
				Server.Commands.CommandLogging.WriteLine( from, " added a location {0} and map {1} with description {2} to egates.", i_loc, i_map, i_desc );
				from.SendGump( new egategump() );	
			}
		}

		public virtual void BEvent( Mobile from )  // code that creates the gates, starts delete timers, and broadcasts via world broadcast
		{

			int listcount = Server.Items.EGCPersi.EGCPers.Count;

			Point3D endloc = Server.Items.EGCPersi.EGCDest;
			Map endmap = Server.Items.EGCPersi.EGCMap;
			int times = Server.Items.EGCPersi.EGCDur.Minutes;

			if( from is PlayerMobile && listcount > 0 && endloc != Point3D.Zero )  // make sure the list is not empty before we start
			{
				foreach( EGEntry entry in Server.Items.EGCPersi.EGCPers )
				{
					Moongate firstGate = new Moongate( endloc, endmap );
					firstGate.Name = "Event Moongate";
					firstGate.Hue = 999;
					firstGate.MoveToWorld( entry.Location, entry.Map );
					Timer gdel = Timer.DelayCall( TimeSpan.FromMinutes( times ), new TimerCallback( ((Moongate)firstGate).Delete ) );
				}

				Console.WriteLine( "endloc is " + Server.Items.EGCPersi.EGCDest.ToString() + ", endmap is " + Server.Items.EGCPersi.EGCMap.ToString() + ", eglist count is " + listcount.ToString() + "." );

				World.Broadcast( 0x22, true, "An event is beginning now!  Brought to you by {0}", from.Name.ToString() );
				//World.Broadcast( 0x22, true, "World Gates will be open for {0} minutes.", Server.Items.EGCPersi.EGCDur.Minutes.ToString() );
			}
			else
			{
				from.SendMessage( "The location list for entrance gates is empty!" );
			}
		}
	}
}

namespace Server.Items
{
	public class EGCPersi : Item  // this is the persistance item that saves the dynamic values
	{ 
		private static ArrayList egarray = new ArrayList();
		private static TimeSpan egdur = TimeSpan.FromMinutes(1);
		private static Point3D egdest = Point3D.Zero;
		private static Map egmap = Map.Trammel;

		public static ArrayList EGCPers = ArrayList.Synchronized(egarray); // this is threadsafe arraylist wrapper
		public static TimeSpan EGCDur{ get{ return egdur; } set{ egdur = value; } }
		public static Point3D EGCDest{ get{ return egdest; } set{ egdest = value; } }
		public static Map EGCMap{ get{ return egmap; } set{ egmap = value; } }

		public EGCPersi(){}

		public EGCPersi(Serial serial) : base( serial ){}

		public override void Delete(){ return; }  // this prevents deletion

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write( (TimeSpan)egdur );
			writer.Write( (Point3D)egdest );
			writer.Write( (Map)egmap );

			writer.Write( (int)egarray.Count );  // this is where we write the values of the arraylist

			for ( int i = 0; i < egarray.Count; ++i )
				((EGEntry)egarray[i]).Serialize( writer );
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			egdur = reader.ReadTimeSpan();
			egdest = reader.ReadPoint3D();
			egmap = reader.ReadMap();
			int count = reader.ReadInt();

			for ( int i = 0; i < count; ++i )
				egarray.Add( new EGEntry( reader ) );
		}
	}
}

namespace Server
{
	public class EGEntry  // this is the entry definition for the arraylist entries
	{
		private Point3D m_Location;
		private Map m_Map;
		private string m_Description;

		public Point3D Location
		{
			get{ return m_Location; }
		}

		public Map Map
		{
			get{ return m_Map; }
		}

		public string Description
		{
			get{ return m_Description; }
		}

		public EGEntry( Point3D loc, Map map, string desc )
		{
			m_Location = loc;
			m_Map = map;
			m_Description = desc;
		}

		public EGEntry( GenericReader reader )
		{
			m_Location = reader.ReadPoint3D();
			m_Map = reader.ReadMap();
			m_Description = reader.ReadString();
		}

		public void Serialize( GenericWriter writer )
		{
			writer.Write( m_Location );
			writer.Write( m_Map );
			writer.Write( m_Description );
		}
	}
}