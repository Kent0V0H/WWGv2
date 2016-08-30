using System;

namespace WWG
{
	public class Dragon : Monster
	{
		public Dragon (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void breathFire()
		{
			moveText = "Watch out for fire!";
			mP = mP - 50;
			damage = (int)(mAtk * 1.5);
		}

		public void tryToEat()
		{
			moveText = "Tried to eat you!";
			damage = pAtk;
		}

		public void sleep()
		{
			moveText = "Recovered HP and MP!";
			hP = hP + 50;
			mP = mP + 25;
			damage = 0;
		}

		public void covet()
		{
			moveText = "Coveted treasure...";
			damage = 0;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,5); // 1-4

			switch (num) 
			{
			case 1:
				if (mP >= 50)
					breathFire ();
				else
					moveText = "MP is too low!";
				break;
			case 2:
				tryToEat ();
				break;
			case 3:
				sleep ();	
				break;
			default:
				covet ();	
				break;
			}
		}

		public void reset()
		{
			//Dragon dragon = new Dragon (90, 90, 90, 90, 150, 100);
			pAtk = 90;
			mAtk = 90;
			pDef = 90;
			mDef = 90;
			hP = 150;
			mP = 100;
		}
	}
}

