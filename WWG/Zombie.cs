using System;

namespace WWG
{
	public class Zombie : Monster
	{
		public Zombie (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void tryToEat()
		{
			moveText = "Zombie is hungry!";
			mP = mP - 25;
			damage = pAtk + mAtk;
		}

		public void gnawSelf()
		{
			moveText = "Gnawed on itself!";
			hP = hP - 25;
			mP = mP + 25;
			damage = 0;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,3); // 1-2

			switch (num) 
			{
			case 1:
				if (mP >= 25)
					tryToEat ();
				else
					moveText = "MP is too low!";
				break;
			default:
				gnawSelf ();	
				break;
			}
		}

		public void reset()
		{
			//Zombie zombie = new Zombie (70, 10, 30, 30, 50, 50);
			pAtk = 70;
			mAtk = 10;
			pDef = 30;
			mDef = 30;
			hP = 50;
			mP = 50;
		}
	}
}

