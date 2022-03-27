using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class finalScoreWalk0 : MonoBehaviour {



		Text finalScore ; 
		float scoreReciever ; 
		// Use this for initialization
		void Start () {
			finalScore = GetComponent<Text> (); 
		}

		// Update is called once per frame
		void Update () {
			scoreReciever = characterTrigger.increaseScore;
			finalScore.text = "YOU WIN" + "\n" + "Score : " + scoreReciever.ToString() ; 

		}
	}
