using System;
using Gtk;
using WWG;

public partial class MainWindow: Gtk.Window
{
	//pAtk, mAtk, pDef, mDef, hP, mP
	DarkKnight darkKnight = new DarkKnight (90, 50, 100, 90, 100, 50);
	Dragon dragon = new Dragon (90, 90, 90, 90, 150, 100);
	Goblin goblin = new Goblin (70, 50, 50, 50, 70, 70);
	KillerFish killerFish = new KillerFish (100, 20, 50, 50, 80, 20);
	Malboro malboro = new Malboro (80, 60, 70, 70, 110, 50);
	QueenBee queenBee = new QueenBee (80, 40, 60, 60, 80, 20);
	Vampire vampire = new Vampire (80, 80, 90, 90, 120, 80);
	Wizard wizard = new Wizard (50, 100, 50, 90, 100, 100);
	Zombie zombie = new Zombie (70, 10, 30, 30, 50, 50);

	Wizard player = new Wizard (50, 100, 50, 90, 100, 100);

	int roundCount = 0;


	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		spawn ();
		getStats ();
	}


	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}


	protected void OnMoveButtonClicked (object sender, EventArgs e)
	{
		if (player.getHp () > 0) {
			switch (monsterLabel.Text) {
			case "Dark Knight":
				doBattle (player, darkKnight);
				use2Label.Text = Convert.ToString (darkKnight.moveText);
				damageE2Label.Text = Convert.ToString (darkKnight.getDamage ());
				break;
			case "Dragon":
				doBattle (player, dragon);
				use2Label.Text = Convert.ToString(dragon.moveText);
				damageE2Label.Text = Convert.ToString (dragon.getDamage ());
				break;
			case "Goblin":
				doBattle (player, goblin);
				use2Label.Text = Convert.ToString(goblin.moveText);
				damageE2Label.Text = Convert.ToString (goblin.getDamage ());
				break;
			case "Killer Fish":
				doBattle (player, killerFish);
				use2Label.Text = Convert.ToString(killerFish.moveText);
				damageE2Label.Text = Convert.ToString (killerFish.getDamage ());
				break;
			case "Malboro":
				doBattle (player, malboro);
				use2Label.Text = Convert.ToString(malboro.moveText);
				damageE2Label.Text = Convert.ToString (malboro.getDamage ());
				break;
			case "Queen Bee":
				doBattle (player, queenBee);
				use2Label.Text = Convert.ToString(queenBee.moveText);
				damageE2Label.Text = Convert.ToString (queenBee.getDamage ());
				break;
			case "Vampire":
				doBattle (player, vampire);
				use2Label.Text = Convert.ToString(vampire.moveText);
				damageE2Label.Text = Convert.ToString (vampire.getDamage ());
				break;
			case "Wizard":
				doBattle (player, wizard);
				use2Label.Text = Convert.ToString(wizard.moveText);
				damageE2Label.Text = Convert.ToString (wizard.getDamage ());
				break;
			case "Zombie":
				doBattle (player, zombie);
				use2Label.Text = Convert.ToString(zombie.moveText);
				damageE2Label.Text = Convert.ToString (zombie.getDamage ());
				break;
			}

			damageP2Label.Text = Convert.ToString(player.getDamage ());
			useLabel.Text = Convert.ToString(player.moveText);

			getStats ();
		} else {
			hp2Label.Text = Convert.ToString(0);
			mp2Label.Text = Convert.ToString(0);
			useLabel.Text = "GAME OVER";
			use2Label.Text = "GAME OVER";
			getStats ();
		}
	}


	public void getStats ()
	{
		hp2Label.Text = Convert.ToString(player.getHp ());
		mp2Label.Text = Convert.ToString(player.getMp ());
		rc2Label.Text = Convert.ToString(roundCount);
	}


	// DARK KNIGHT ------------------------------------------------------------------------
	public void doBattle (Wizard pObject, DarkKnight mObject)
	{
		switch (combobox1.ActiveText) 
		{
		case "Use spell!":
			pObject.useSpell ();
			break;
		case "Use sword!":
			pObject.useSword ();
			break;
		case "Use HP potion!":
			pObject.usePotionHp ();
			break;
		case "Use MP potion!":
			pObject.usePotionMp ();
			break;
		}

		mObject.damageCalc (pObject.getDamage ());

		if (mObject.getHp () > 0) {
			mObject.makeMoves ();
			pObject.damageCalc (mObject.getDamage ());
		} else {
			spawn ();
			roundCount++;
		}
	}


	// DRAGON -----------------------------------------------------------------------------
	public void doBattle (Wizard pObject, Dragon mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// GOBLIN -----------------------------------------------------------------------------
	public void doBattle (Wizard pObject, Goblin mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// KILLER FISH ------------------------------------------------------------------------
	public void doBattle (Wizard pObject, KillerFish mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// MALBORO ----------------------------------------------------------------------------
	public void doBattle (Wizard pObject, Malboro mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// QUEEN BEE --------------------------------------------------------------------------
	public void doBattle (Wizard pObject, QueenBee mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// VAMPIRE ----------------------------------------------------------------------------
	public void doBattle (Wizard pObject, Vampire mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// WIZARD -----------------------------------------------------------------------------
	public void doBattle (Wizard pObject, Wizard mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	// ZOMBIE -----------------------------------------------------------------------------
	public void doBattle (Wizard pObject, Zombie mObject)
	{
		if (pObject.getHp () > 0 && mObject.getHp () > 0)
		{
			switch (combobox1.ActiveText) 
			{
			case "Use spell!":
				pObject.useSpell ();
				break;
			case "Use sword!":
				pObject.useSword ();
				break;
			case "Use HP potion!":
				pObject.usePotionHp ();
				break;
			case "Use MP potion!":
				pObject.usePotionMp ();
				break;
			}

			mObject.damageCalc (pObject.getDamage ());

			if (mObject.getHp () > 0) 
			{
				mObject.makeMoves ();
				pObject.damageCalc (mObject.getDamage ());
			} else {
				spawn ();
				roundCount++;
			}
		}
	}


	public void hideImages()
	{
		darkKnightImage.Visible = false;
		dragonImage.Visible = false;
		goblinImage.Visible = false;
		killerFishImage.Visible = false;
		malboroImage.Visible = false;
		queenBeeImage.Visible = false;
		vampireImage.Visible = false;
		wizardImage.Visible = false;
		zombieImage.Visible = false;
	}


	public void spawn()
	{
		Random rnd = new Random();
		int num = rnd.Next(1,10); // 1-9
		hideImages ();

		switch (num) 
		{
		//pAtk, mAtk, pDef, mDef, hP, mP
		case 1:
			darkKnight.reset ();
			monsterLabel.Text = "Dark Knight";
			darkKnightImage.Visible = true;
			break;
		case 2:
			dragon.reset ();
			monsterLabel.Text = "Dragon";
			dragonImage.Visible = true;
			break;
		case 3:
			goblin.reset ();
			monsterLabel.Text = "Goblin";
			goblinImage.Visible = true;
			break;
		case 4:
			killerFish.reset ();
			monsterLabel.Text = "Killer Fish";
			killerFishImage.Visible = true;
			break;
		case 5:
			malboro.reset ();
			monsterLabel.Text = "Malboro";
			malboroImage.Visible = true;
			break;
		case 6:
			queenBee.reset ();
			monsterLabel.Text = "Queen Bee";
			queenBeeImage.Visible = true;
			break;
		case 7:
			vampire.reset ();
			monsterLabel.Text = "Vampire";
			vampireImage.Visible = true;
			break;
		case 8:
			wizard.reset ();
			monsterLabel.Text = "Wizard";
			wizardImage.Visible = true;
			break;
		case 9:
			zombie.reset ();
			monsterLabel.Text = "Zombie";
			zombieImage.Visible = true;
			break;
		}
	}
}

