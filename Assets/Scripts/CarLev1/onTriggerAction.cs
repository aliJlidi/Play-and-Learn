using UnityEngine;
using System.Collections;

public class onTriggerAction : MonoBehaviour {

	public static int y = 1 ; 
	public static float z = 0 ; 
	public static int w = 4 ;
	public AudioSource ohNo; 
	public AudioSource yes;
	public GameObject winPanel ; 
	public GameObject pauseButton; 
	// Use this for initialization
	void Start () { 
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider target){
		if (target.tag == "col") {
			y += 1; 
		}
		if (target.tag == "F") {

			ohNo.Play(); 
			w -= 1; 
			if (w == 3) {
				Destroy (GameObject.FindWithTag("Car3"));
			}
			if (w == 2) {
				Destroy (GameObject.FindWithTag("Car2"));
			}
			if (w == 1) {
				Destroy (GameObject.FindWithTag("Car1"));
			}

		}
		if ( target.tag =="T" ) {
			z += .2f;
			yes.Play ();
		}
		if ( target.tag =="Win" ) {

			winPanel.SetActive (true); 
			pauseButton.SetActive (false);
			Time.timeScale = 0;
		}

	}
}
