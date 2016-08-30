using System;

namespace WWG
{
	public class DarkKnight : Monster
	{
		public DarkKnight (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void unholyStrength()
		{
			moveText = "Increased power!";
			mP = mP - 10;
			pAtk = pAtk + 10;
			damage = 0;
		}

		public void useSword()
		{
			moveText = "Swung sword!";
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
					unholyStrength ();
				else
					moveText = "MP is too low!";
				break;
			default:
				useSword ();	
				break;
			}
		}

		public void reset()
		{
			//DarkKnight darkKnight = new DarkKnight (90, 50, 100, 90, 100, 50);
			pAtk = 90;
			mAtk = 50;
			pDef = 100;
			mDef = 90;
			hP = 100;
			mP = 50;
		}
	}
}

