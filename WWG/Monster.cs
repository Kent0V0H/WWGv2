using System;

namespace WWG
{
	public class Monster
	{
		public int pAtk;
		public int mAtk;
		public int pDef;
		public int mDef;
		public int hP;
		public int mP;
		public int damage = 0;
		public String moveText = "--";

		public Monster (int a, int b, int c, int d, int e, int f)
		{
			pAtk = a;
			mAtk = b;
			pDef = c;
			mDef = d;
			hP = e;
			mP = f;
		}

		public int getHp()
		{
			return hP;
		}

		public int getDamage()
		{
			return damage;
		}

		public void damageCalc(int a)
		{
			hP = hP - a;
		}
	}
}

