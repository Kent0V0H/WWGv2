using System;

namespace WWG
{
	public class KillerFish : Monster
	{
		public KillerFish (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void useTheCurrent()
		{
			moveText = "Increased power!";
			mP = mP - 10;
			pAtk = pAtk + 10;
			damage = 0;
		}

		public void chomp()
		{
			moveText = "Took a bite out of you!";
			damage = pAtk;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,3); // 1-2

			switch (num) 
			{
			case 1:
				if (mP >= 10)
					useTheCurrent ();
				else
					moveText = "MP is too low!";
				break;
			default:
				chomp ();	
				break;
			}
		}

		public void reset()
		{
			//KillerFish killerFish = new KillerFish (100, 20, 50, 50, 80, 20);
			pAtk = 100;
			mAtk = 20;
			pDef = 50;
			mDef = 50;
			hP = 80;
			mP = 20;
		}
	}
}

