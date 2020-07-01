using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server
{
	public class PvpPointSystem
	{
		public static Type[] PvpArtifacts = new Type[]
		{
			typeof( Katana ),
			typeof( WarAxe )
		};

		// Enables Point System
		public static readonly bool EnablePointSystem = true;

		// Enable Staff Pvp Rank
		public static readonly bool EnableStaffRank = false;

		// Enable Pvp Rewards
		public static readonly bool EnablePvpRewards = true;

		// Show Global Death Message
		public static readonly bool EnableGlobalDeathMessage = true;

		// Enables Res Kill Timer
		public static readonly bool EnableResKillTimer = true;

		// Enables Res Kill Time
		public static readonly TimeSpan ResKillTime = TimeSpan.FromMinutes( 3.0 );

		// Enables Rank System
		public static readonly bool EnableRankSystem = true;

		public static void CheckTitle( PlayerMobile loser, PlayerMobile winner )
		{
			if ( EnableRankSystem == true && EnablePointSystem == true )
			{
 				int winnerpure = winner.TotalWins - winner.TotalLoses - winner.TotalResKills;
 				int loserpure = loser.TotalWins - loser.TotalLoses - loser.TotalResKills;
				
				if ( winnerpure <= 0 )
				{
					winner.PvpRank = "Ultra Newb";
				}
				else if ( winnerpure <= 2 )
				{
					winner.PvpRank = "Newbie";
				}
				else if ( winnerpure <= 10 )
				{
					winner.PvpRank = "Novice Pvper";
				}
				else if ( winnerpure <= 20 )
				{
					winner.PvpRank = "Adempt Pvper";
				}
				else if ( winnerpure <= 30 )
				{
					winner.PvpRank = "Expert Pver";
				}
				else if ( winnerpure <= 50 )
				{
					winner.PvpRank = "Roxxor";
				}
				else if ( winnerpure <= 100 )
				{
					winner.PvpRank = "Hardcore Roxxor";
				}
				else if ( winnerpure <= 300 )
				{
					winner.PvpRank = "Duelist";
				}
				else if ( winnerpure <= 600 )
				{
					winner.PvpRank = "Novice Duelist";
				}
				else if ( winnerpure <= 1200 )
				{
					winner.PvpRank = "Adempt Duelist";
				}
				else if ( winnerpure <= 3000 )
				{
					winner.PvpRank = "Expert Duelist";
				}
				else if ( winnerpure <= 5000 )
				{
					winner.PvpRank = "Master Duelist";
				}
				else if ( winnerpure <= 7000 )
				{
					winner.PvpRank = "Grandmaster Duelist";
				}
				else if ( winnerpure <= 9999 )
				{
					winner.PvpRank = "Elder Duelist";
				}
				else if ( winnerpure <= 19999 )
				{
					winner.PvpRank = "Legendary Duelist";
				}
				else
				{
					winner.SendMessage( "You cannot gain anymore in rank." );
				}

				if ( loserpure <= 0 )
				{
					loser.PvpRank = "Ultra Newb";
				}
				else if ( loserpure <= 2 )
				{
					loser.PvpRank = "Newbie";
				}
				else if ( loserpure <= 10 )
				{
					loser.PvpRank = "Novice Pvper";
				}
				else if ( loserpure <= 20 )
				{
					loser.PvpRank = "Adempt Pvper";
				}
				else if ( loserpure <= 30 )
				{
					loser.PvpRank = "Expert Pver";
				}
				else if ( loserpure <= 50 )
				{
					loser.PvpRank = "Roxxor";
				}
				else if ( loserpure <= 100 )
				{
					loser.PvpRank = "Hardcore Roxxor";
				}
				else if ( loserpure <= 300 )
				{
					loser.PvpRank = "Duelist";
				}
				else if ( loserpure <= 600 )
				{
					loser.PvpRank = "Novice Duelist";
				}
				else if ( loserpure <= 1200 )
				{
					loser.PvpRank = "Adempt Duelist";
				}
				else if ( loserpure <= 3000 )
				{
					loser.PvpRank = "Expert Duelist";
				}
				else if ( loserpure <= 5000 )
				{
					loser.PvpRank = "Master Duelist";
				}
				else if ( loserpure <= 7000 )
				{
					loser.PvpRank = "Grandmaster Duelist";
				}
				else if ( loserpure <= 9999 )
				{
					loser.PvpRank = "Elder Duelist";
				}
				else if ( loserpure <= 19999 )
				{
					loser.PvpRank = "Legendary Duelist";
				}
				else
				{
					loser.SendMessage( "You cannot gain anymore in rank." );
				}
			}
		}

		public static void GivePoints( PlayerMobile loser, PlayerMobile winner )
		{
			if ( EnablePointSystem == true )
			{
				if ( loser.TotalPoints >= 0 )
				{
					loser.TotalPoints -= 1;
					loser.TotalPointsLost += 1;
				}

				if ( EnableResKillTimer == true )
				{
					if ( loser.LastKiller != loser.LastPwner )
					{
						loser.TotalLoses += 1;
						winner.TotalPoints += 1;
						winner.TotalWins += 1;
						winner.SendMessage( "You have gained one point from {0}", loser.Name );
						loser.ResKillTime = ResKillTime;
					}
					else
					{
						if ( loser.ResKillTime != TimeSpan.Zero )
						{
							winner.TotalResKills += 1;
							loser.TotalLoses += 1;
							winner.TotalWins += 1;
							loser.TotalResKilled += 1;
						}
						else
						{
							loser.TotalLoses += 1;
							winner.TotalPoints += 1;
							winner.TotalWins += 1;
							winner.SendMessage( "You have gained one point from {0}", loser.Name );
							loser.ResKillTime = ResKillTime;
						}
					}
				}
				else
				{
					loser.TotalLoses += 1;
					winner.TotalPoints += 1;
					winner.TotalWins += 1;
					winner.SendMessage( "You have gained one point from {0}", loser.Name );
				}

				winner.LastPwned = loser;
				loser.LastPwner = winner;

				if ( EnablePvpRewards == true )
					GiveReward( winner );

				if ( EnableGlobalDeathMessage == true )
					World.Broadcast( 0x35, true, "{0} has just been killed by {1}!", loser.Name, winner.Name );
			}
		}

		public static void GiveReward( PlayerMobile winner )
		{
			int chance = Utility.Random( 10000 );

			if ( chance <= 25 )
			{
				Item item = (Item)Activator.CreateInstance( PvpArtifacts[Utility.Random(PvpArtifacts.Length)] );

				if ( winner.AddToBackpack( item ) )
					winner.SendMessage( "You have been rewarded for slaying your foe." );
				else
					winner.SendMessage( "You have been rewarded for slaying your foe, but your backpack is full the item has feel to your feet." );
			}
		}
	}
}