using System; 
using System.Text; 
using System.Collections; 
using Server; 
using Server.Network; 
using Server.Guilds; 
using Server.Mobiles;
using Server.Commands;

namespace Server.Scripts.Commands 
{ 
   public class GUILDC 
      { 
      private static int usercount; 

      public static void Initialize() 
      { 
         CommandSystem.Register( "g", AccessLevel.Player, new CommandEventHandler( GUILDC_OnCommand ) ); 
            } 

      [Usage( "g [<text>|list]" )] 
      [Description( "Guild Chat system." )] 
      private static void GUILDC_OnCommand( CommandEventArgs e ) 
      { 
         switch( e.ArgString.ToLower() ) 
         { 
            case "list": 
               List ( e.Mobile ); 
               break; 
            default: 
               Msg ( e ); 
               break; 
         } 
      } 

      private static void List( Mobile g ) 
      { 
         usercount = 0; 
         Guild GuildC = (Guild)(g.Guild); 
         if ( GuildC == null ) 
         { 
            g.SendMessage( "You do not have a guild!" ); 
         } 
         else 
         { 
            foreach ( NetState state in NetState.Instances ) 
            { 
               Mobile m = state.Mobile; 
               if ( m != null && GuildC.IsMember( m ) ) 
               { 
                  usercount++; 
               } 
            } 
            if (usercount == 0) 
            { 
               g.SendMessage( "No other player from your guild online." ); 
            } 
            else 
            { 
               g.SendMessage( "{0} of {0} online now.", usercount, usercount == 1 ? "" : "s"); 
            } 
            g.SendMessage ("Online List:" ); 
            foreach ( NetState state in NetState.Instances ) 
            { 
               Mobile m = state.Mobile; 
               if ( m != null && GuildC.IsMember( m ) ) 
               { 
                  string region = m.Region.ToString(); 
                  if (region == "") 
                  { 
                     region = "Sosaria"; 
                  }                
                  g.SendMessage( "{0}", m.Name); 
               } 
            }       

         } 
      } 

      private static void Msg( CommandEventArgs e  ) 
      { 
         Mobile from = e.Mobile; 

         Guild GuildC = (Guild)(from.Guild); 
         if ( GuildC == null ) 
         { 
            from.SendMessage( "You do not have a guild!" ); 
         } 
         else 
         { 
            foreach ( NetState state in NetState.Instances ) 
            { 
               Mobile m = state.Mobile; 
               if ( m != null && GuildC.IsMember( m ) ) 
               { 
                  m.SendMessage( 0x2C, String.Format( "{0} [{1}]: {2}", GuildC.Abbreviation, from.Name, e.ArgString ) );
               } 
            } 
         } 
      } 
   } 
}