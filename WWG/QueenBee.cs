using System;

namespace WWG
{
	public class QueenBee : Monster
	{
		public QueenBee (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void swarm()
		{
			moveText = "Calls forth an army!";
			mP = mP - 20;
			Random rnd = new Random();
			int num = rnd.Next(1,4); // 1-3
			damage = pAtk * num;
		}

		public void sting()
		{
			moveText = "Stung you!";
			mP = mP + 10;
			damage = pAtk;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,3); // 1-2

			switch (num) 
			{
			case 1:
				if (mP >= 20)
					swarm ();
				else
					moveText = "MP is too low!";
				break;
			default:
				sting ();	
				break;
			}
		}

		public void reset()
		{
			//QueenBee queenBee = new QueenBee (80, 40, 60, 60, 80, 20);
			pAtk = 80;
			mAtk = 40;
			pDef = 60;
			mDef = 60;
			hP = 80;
			mP = 20;
		}
	}
}

