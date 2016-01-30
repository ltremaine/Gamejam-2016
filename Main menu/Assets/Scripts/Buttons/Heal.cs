using UnityEngine;
using System.Collections;

public class  Heal : MonoBehaviour 
{
	private Vector3 currentPosition;

	void OnMouseDown()
	{
		currentPosition = transform.position;

		Debug.Log("Heal");
		AudioSource audio = gameObject.GetComponent<AudioSource>();
		audio.Play();

		if (HPcontroller.selection1 == false) 
		{
			HPcontroller.selection1 = true;
			HPcontroller.heal = true;
		}
		else if(HPcontroller.selection2 == false)
		{
			HPcontroller.selection2 = true;
			HPcontroller.heal2 = true;
		}

		if (currentPosition == tileSpawner1.pos1) 
		{
			tileSpawner1.pos1Filled = false;
		}
		if (currentPosition == tileSpawner1.pos2) 
		{
			tileSpawner1.pos2Filled = false;
		}
		if (currentPosition == tileSpawner1.pos3) 
		{
			tileSpawner1.pos3Filled = false;
		}
		if (currentPosition == tileSpawner1.pos4) 
		{
			tileSpawner1.pos4Filled = false;
		}
		if (currentPosition == tileSpawner1.pos5) 
		{
			tileSpawner1.pos5Filled = false;
		}

		Destroy(gameObject);
	}
	

}