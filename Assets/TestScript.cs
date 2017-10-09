using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {
		int score = 0;
	// Use this for initialization
	//Curly braces, hiermee wordt een klasse/functie gedefinieerd. Het maakt een andere scope aan.
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {


		if(score >= 1000)
		{
			Debug.Log("You are amazing");
		}
		else
		{
			score++;
		}


	}
}
