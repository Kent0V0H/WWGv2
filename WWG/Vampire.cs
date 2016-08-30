using System;

namespace WWG
{
	public class Vampire : Monster
	{
		public Vampire (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public void drinkBlood()
		{
			moveText = "Sucked your blood!";
			mP = mP - 25;
			damage = mAtk;
		}

		public void useClaws()
		{
			moveText = "Assaulted you with claws!";
			damage = pAtk;
		}

		public void useCoffin()
		{
			moveText = "Recovered HP and MP!";
			hP = hP + 50;
			mP = mP + 50;
			damage = 0;
		}

		public void turnToBat()
		{
			moveText = "Became a bat...";
			hP = (int)(hP / 2);
			mP = (int)(mP / 2);
			damage = 0;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,5); // 1-4

			switch (num) 
			{
			case 1:
				if (mP >= 25)
					drinkBlood ();
				else
					moveText = "MP is too low!";
				break;
			case 2:
				useClaws ();
				break;
			case 3:
				useCoffin ();	
				break;
			default:
				turnToBat ();	
				break;
			}
		}

		public void reset()
		{
			//Vampire vampire = new Vampire (80, 80, 90, 90, 120, 80);
			pAtk = 80;
			mAtk = 80;
			pDef = 90;
			mDef = 90;
			hP = 120;
			mP = 80;
		}
	}
}

