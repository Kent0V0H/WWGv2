using System;

namespace WWG
{
	public class Malboro : Monster
	{
		public Malboro (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void badBreath()
		{
			moveText = "Bad breath attack!";
			mP = mP - 25;
			damage = (int)(mAtk * 1.5);
		}

		public void tryToEat()
		{
			moveText = "Tried to eat you!";
			damage = pAtk;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,3); // 1-2

			switch (num) 
			{
			case 1:
				if (mP >= 25)
					badBreath ();
				else
					moveText = "MP is too low!";
				break;
			default:
				tryToEat ();	
				break;
			}
		}

		public void reset()
		{
			//Malboro malboro = new Malboro (80, 60, 70, 70, 110, 50);
			pAtk = 80;
			mAtk = 60;
			pDef = 70;
			mDef = 70;
			hP = 110;
			mP = 50;
		}
	}
}

