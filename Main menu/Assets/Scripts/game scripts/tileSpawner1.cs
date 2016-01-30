using UnityEngine;
using System.Collections;

public class tileSpawner1 : MonoBehaviour {

	public static bool pos1Filled;
	public static bool pos2Filled;
	public static bool pos3Filled;
	public static bool pos4Filled;
	public static bool pos5Filled;
	private int random;


	public GameObject firePrefab;
	public GameObject earthPrefab;
	public GameObject waterPrefab;
	public GameObject healPrefab;

	public static Vector3 pos1;
	public static Vector3 pos2;
	public static Vector3 pos3;
	public static Vector3 pos4;
	public static Vector3 pos5;

	// Use this for initialization
	void Start () 
	{
		pos1Filled = false;
		pos2Filled = false;
		pos3Filled = false;
		pos4Filled = false;
		pos5Filled = false;

		pos1 = new Vector3(-7.3f, -3.77f, 0.0f);
		pos2 = new Vector3(-3.7f, -3.77f, 0.0f);
		pos3 = new Vector3(0.24f, -3.77f, 0.0f);
		pos4 = new Vector3(3.98f, -3.77f, 0.0f);
		pos5 = new Vector3(7.71f, -3.77f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(HPcontroller.selection2 == false && HPcontroller.selection1 == false)
		{
			if(pos1Filled == false)
			{
				random = Random.Range (1, 5);
			
				if( random == 1)
				{
					Debug.Log (random);
					Instantiate(firePrefab, pos1, Quaternion.Euler (0,0,0));
				}
				else if( random == 2)
				{
					Debug.Log (random);
					Instantiate(earthPrefab, pos1, Quaternion.Euler (0,0,0));
				}
				else if( random == 3)
				{
					Debug.Log (random);
					Instantiate(waterPrefab, pos1, Quaternion.Euler (0,0,0));
				}
				else if( random == 4)
				{
					Debug.Log (random);
					Instantiate(healPrefab, pos1, Quaternion.Euler (0,0,0));
				}
				pos1Filled = true;
			}

			if(pos2Filled == false)
			{
				random = Random.Range (1, 5);
				
				if( random == 1)
				{
					Debug.Log (random);
					Instantiate(firePrefab, pos2, Quaternion.Euler (0,0,0));
				}
				else if( random == 2)
				{
					Debug.Log (random);
					Instantiate(earthPrefab, pos2, Quaternion.Euler (0,0,0));
				}
				else if( random == 3)
				{
					Debug.Log (random);
					Instantiate(waterPrefab, pos2, Quaternion.Euler (0,0,0));
				}
				else if( random == 4)
				{
					Debug.Log (random);
					Instantiate(healPrefab, pos2, Quaternion.Euler (0,0,0));
				}
				pos2Filled = true;
			}

			if(pos3Filled == false)
			{
				random = Random.Range (1, 5);
				
				if( random == 1)
				{
					Debug.Log (random);
					Instantiate(firePrefab, pos3, Quaternion.Euler (0,0,0));
				}
				else if( random == 2)
				{
					Debug.Log (random);
					Instantiate(earthPrefab, pos3, Quaternion.Euler (0,0,0));
				}
				else if( random == 3)
				{
					Debug.Log (random);
					Instantiate(waterPrefab, pos3, Quaternion.Euler (0,0,0));
				}
				else if( random == 4)
				{
					Debug.Log (random);
					Instantiate(healPrefab, pos3, Quaternion.Euler (0,0,0));
				}
				pos3Filled = true;
			}

			if(pos4Filled == false)
			{
				random = Random.Range (1, 5);
				
				if( random == 1)
				{
					Debug.Log (random);
					Instantiate(firePrefab, pos4, Quaternion.Euler (0,0,0));
				}
				else if( random == 2)
				{
					Debug.Log (random);
					Instantiate(earthPrefab, pos4, Quaternion.Euler (0,0,0));
				}
				else if( random == 3)
				{
					Debug.Log (random);
					Instantiate(waterPrefab, pos4, Quaternion.Euler (0,0,0));
				}
				else if( random == 4)
				{
					Debug.Log (random);
					Instantiate(healPrefab, pos4, Quaternion.Euler (0,0,0));
				}
				pos4Filled = true;
			}

			if(pos5Filled == false)
			{
				random = Random.Range (1, 5);
				
				if( random == 1)
				{
					Debug.Log (random);
					Instantiate(firePrefab, pos5, Quaternion.Euler (0,0,0));
				}
				else if( random == 2)
				{
					Debug.Log (random);
					Instantiate(earthPrefab, pos5, Quaternion.Euler (0,0,0));
				}
				else if( random == 3)
				{
					Debug.Log (random);
					Instantiate(waterPrefab, pos5, Quaternion.Euler (0,0,0));
				}
				else if( random == 4)
				{
					Debug.Log (random);
					Instantiate(healPrefab, pos5, Quaternion.Euler (0,0,0));
				}
				pos5Filled = true;
			}
		}
	}
}
