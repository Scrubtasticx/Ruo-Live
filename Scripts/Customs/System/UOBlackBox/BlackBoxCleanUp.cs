 //UO Black Box - By GoldDraco13
//1.0.0.102

using System;

namespace Server.UOBlackBox
{
    public class BlackBoxCleanUp
    {
        public void Initialize()
        {
            EventSink.Logout += new LogoutEventHandler(OnLogout);
        }

        private void OnLogout(LogoutEventArgs e)
        {
            int cnt = 0;

            foreach (Item item in World.Items.Values)
            {
                if (item.Name != null)
                {
                    if (item.Name.Contains("Black Box Portal") || item.Name.Contains("Black Box SoulStone"))
                    {
                        BlackBoxTravel BBT = item as BlackBoxTravel;

                        if (BBT.Owner == e.Mobile.Name)
                        {
                            item.Delete();

                            cnt++;
                        }
                    }

                    if (item.Name.Contains("Black Box Portal Exit"))
                    {
                        BlackBoxTravelEnd BBT = item as BlackBoxTravelEnd;

                        if (BBT.Owner == e.Mobile.Name)
                        {
                            item.Delete();

                            cnt++;
                        }
                    }
                }
            }
        }
    }
}
