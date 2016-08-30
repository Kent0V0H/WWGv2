using System;

namespace WWG
{
	public class Wizard : Monster
	{
		public Wizard (int a, int b, int c, int d, int e, int f) 
			: base(a,b,c,d,e,f) {}

		public int getMp()
		{
			return mP;
		}

		public void useSpell()
		{
			moveText = "Used spell!";
			mP = mP - 30;
			damage = mAtk;
		}

		public void useSword()
		{
			moveText = "Used sword!";
			damage = pAtk;
		}

		public void usePotionHp()
		{
			moveText = "Used a potion, recovered HP!";
			hP = hP + 50;
			damage = 0;
		}

		public void usePotionMp()
		{
			moveText = "Used a potion, recovered MP!";
			mP = mP + 25;
			damage = 0;
		}

		public void makeMoves()
		{
			Random rnd = new Random();
			int num = rnd.Next(1,5); // 1-4

			switch (num) 
			{
			case 1:
				if (mP >= 30)
					useSpell ();
				else
					moveText = "MP is too low!";
				break;
			case 2:
				useSword ();
				break;
			case 3:
				usePotionHp ();	
				break;
			default:
				usePotionMp ();	
				break;
			}
		}

		public void reset()
		{
			//Wizard wizard = new Wizard (50, 100, 50, 90, 100, 100);
			pAtk = 50;
			mAtk = 100;
			pDef = 50;
			mDef = 90;
			hP = 100;
			mP = 100;
		}
	}
}

