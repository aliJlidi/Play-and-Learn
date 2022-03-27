using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class fadeAndChange : MonoBehaviour {
	Text replacement ; 
	public static bool pass = false; 

	// Use this for initialization
	IEnumerator Start () {
		replacement = GetComponent<Text> (); 
		StartCoroutine (wait (.3f)); 
		yield return new WaitForSeconds (2f); 
		replacement.text = "GO !"; 
		yield return new WaitForSeconds (1f); 
		replacement.text = ""; 
		pass = true; 
	
	}
	
	// Update is called once per frame
	IEnumerator wait(float x ) {

		int i = 0; 
		while (i < 5) {
			replacement.enabled = true; 
			yield return new WaitForSeconds (x); 
			replacement.enabled = false; 
			yield return new WaitForSeconds (x); 
			replacement.enabled = true; 
			i += 1; 
		}
	}
}
