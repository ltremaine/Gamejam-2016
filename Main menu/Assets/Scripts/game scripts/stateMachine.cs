using UnityEngine;
using System.Collections;

public class stateMachine : MonoBehaviour {

	public enum battleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private battleStates currentState;


	// Use this for initialization
	void Start () 
	{
		currentState = battleStates.START;
	}
	
	// Update is called once per frame
	void Update () 
	{
		switch(currentState)
		{
		case(battleStates.START):
			break;


		case (battleStates.PLAYERCHOICE):
			for(int counter = 1; counter < 6; counter++)
			{
				if(Random.value <0.25)
				{

				}
			}
			break;



		case (battleStates.ENEMYCHOICE):
			break;
		case (battleStates.LOSE):
			break;
		case (battleStates.WIN):
			break;
		}
	}
}
