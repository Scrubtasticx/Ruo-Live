FIND: using System.Linq;

ADD BELOW:
using Server.Poker;

FIND: private List<Mobile> m_RecentlyReported;

ADD BELOW:
        private PokerGame m_PokerGame;
        public PokerGame PokerGame
        {
            get { return m_PokerGame; }
            set { m_PokerGame = value; }
        }

FIND: protected override bool OnMove(Direction d)
        {
		
ADD BELOW:			
            if (m_PokerGame != null)
            {
                if (!HasGump(typeof(PokerLeaveGump)))
                {
                    SendGump(new PokerLeaveGump(this, m_PokerGame));
                    return false;
                }
            }


To be clear for everyone, this system does work absolutely awesome!!

Follow these steps to get it working:

1. Add poker dealer
2. Props poker dealer, using the .jpeg image on pge.2 of this thread.
3. USE ONLY PLAYER CHARACTERS! DO NOT USE ADMINS AT ALL!!!!! AT ALLL!!!!!
4. Thats right, do not use your admin at all.
5.[addpokerseat, target dealer and add your seats.
6. now click active and your set.