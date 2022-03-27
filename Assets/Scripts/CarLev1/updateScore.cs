using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class updateScore : MonoBehaviour {

	Text score ; 
	float scoreRise ; 
	int Reciever ; 
	public GameObject losePanel; 
	// Use this for initialization
	void Start () {
		score = GetComponent<Text> (); 
	}

	// Update is called once per frame
	void Update () {
		scoreRise = onTriggerAction.z; 
		score.text = scoreRise.ToString(); 
		Reciever = onTriggerAction.w; 

		if (Reciever == 0) {
			Time.timeScale = 0; 
			losePanel.SetActive (true);
		}

	}
}