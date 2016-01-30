using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPcontroller : MonoBehaviour 
{

	public static int playerHP;
	public static int enemyHP;
	public static bool selection1;
	public static bool selection2;
	public int playerMaxHP;
	public int enemyMaxHP;
	public static bool fire;
	public static bool earth;
	public static bool water;
	public static bool heal;
	public static bool fire2;
	public static bool earth2;
	public static bool water2;
	public static bool heal2;
	private int enemySelection;

	public int enemyAttack1;


	public int doubleFireDamage;
	public int fireEarthDamage;
	public int fireWaterDamage;
	public int fireHealBoost;

	public int doubleEarthDamage;
	public int earthWaterDamage;
	public int earthHealBoost;

	public int doubleWaterDamage;
	public int waterHealBoost;

	public int doubleHealBoost;
	
	public Text playerHPDisplay;
	public Text enemyHPDisplay;


	// Use this for initialization
	void Start () 
	{
		playerHP = playerMaxHP;
		enemyHP = enemyMaxHP;
		playerHPDisplay.text = playerHP.ToString ();
		enemyHPDisplay.text = enemyHP.ToString();
		selection1 = false;
		selection2 = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (playerHP <= 0) 
		{
			Application.LoadLevel ("lose");
		} 
		else if (enemyHP <= 0) 
		{
			Application.LoadLevel ("win");
		} 
		else if(selection1 == true && selection2 == true)
		{
			if (fire == true) 
			{
				if(fire2 == true)
				{
					enemyHP -= doubleFireDamage;
				}
				else if (earth2 == true)
				{
					enemyHP -= fireEarthDamage;
				}
				else if (water2 == true)
				{
					enemyHP -= fireWaterDamage;
				}
				else if(heal2 == true)
				{
					playerHP+= fireHealBoost;
				}
			} 

			if (earth == true) 
			{
				if(fire2 == true)
				{
					enemyHP -= fireEarthDamage;
				}
				else if (earth2 == true)
				{
					enemyHP -= doubleEarthDamage;
				}
				else if (water2 == true)
				{
					enemyHP -= earthWaterDamage;
				}
				else if(heal2 == true)
				{
					playerHP+= earthHealBoost;
				}
			} 

			if (water == true) 
			{
				if(fire2 == true)
				{
					enemyHP -= fireWaterDamage;
				}
				else if (earth2 == true)
				{
					enemyHP -= earthWaterDamage;
				}
				else if (water2 == true)
				{
					enemyHP -= doubleWaterDamage;
				}
				else if(heal2 == true)
				{
					playerHP+= waterHealBoost;
				}
			} 

			if (heal == true) 
			{
				if(fire2 == true)
				{
					playerHP += fireHealBoost;
				}
				else if (earth2 == true)
				{
					playerHP += earthHealBoost;
				}
				else if (water2 == true)
				{
					playerHP += waterHealBoost;
				}
				else if(heal2 == true)
				{
					playerHP+= doubleHealBoost;
				}
			} 
			
			
			
			if(playerHP > playerMaxHP)
		{
			playerHP = playerMaxHP;
		}
		playerHPDisplay.text = playerHP.ToString();
		enemyHPDisplay.text = enemyHP.ToString();



		fire = false;
		fire2 = false;
		earth = false;
		earth2 = false;
		water = false;
		water2 = false;
		heal = false;
		heal2 = false;

		selection1 = false;
		selection2 = false;

		
		StartCoroutine(enemyTurn());
		}

		playerHPDisplay.text = playerHP.ToString();
		enemyHPDisplay.text = enemyHP.ToString();
	
	}

		
	IEnumerator enemyTurn()
	{
		yield return new WaitForSeconds(5);
		enemySelection = Random.Range (0, 5);
			
		if (enemySelection <= 0) 
		{
			enemyHP += Random.Range (5,25);
		}
		if (enemySelection > 0) 
		{
			playerHP -= Random.Range (5,25);
		}
			
		if (enemyHP > enemyMaxHP) 
		{
			enemyHP = enemyMaxHP;
		}


		Debug.Log ("shit streaks");


	}

}



