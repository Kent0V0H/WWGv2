using System;

namespace WWG
{
	public class Goblin : Monster
	{
		public Goblin (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void fart()
		{
			moveText = "Fart!";
			mP = mP - 10;
			damage = mAtk;
		}

		public void tryToEat()
		{
			moveText = "Tried to eat you!";
			damage = pAtk;
		}

		public void drinkSomethingWeird()
		{
			moveText = "Recovered HP and MP!";
			hP = hP + 30;
			mP = mP + 10;
			damage = 0;
		}

		public void pickedNose()
		{
			moveText = "Picked it's nose...";
			damage = 0;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,5); // 1-4

			switch (num) 
			{
			case 1:
				if (mP >= 10)
					fart ();
				else
					moveText = "MP is too low!";
				break;
			case 2:
				tryToEat ();
				break;
			case 3:
				drinkSomethingWeird ();	
				break;
			default:
				pickedNose ();	
				break;
			}
		}

		public void reset()
		{
			//Goblin goblin = new Goblin (70, 50, 50, 50, 70, 70);
			pAtk = 70;
			mAtk = 50;
			pDef = 50;
			mDef = 50;
			hP = 70;
			mP = 70;
		}
	}
}

