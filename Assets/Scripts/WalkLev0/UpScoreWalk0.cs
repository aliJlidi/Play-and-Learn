using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class UpScoreWalk0 : MonoBehaviour {

	Text score ; 
	float scoreRise ; 
	int Reciever ; 
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> (); 
	}

	// Update is called once per frame
	void Update () {
		scoreRise = characterTrigger.increaseScore; 
		score.text = scoreRise.ToString(); 
	
	
	}
}
