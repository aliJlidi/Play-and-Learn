using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class CaseChanger : MonoBehaviour {

	Text oper ; 
	bool getPass ;  
	int x ; 

	// Use this for initialization
	void Start () {




	}



	// Update is called once per frame
	void FixedUpdate () {
		oper = GetComponent<Text> ();
		getPass = fadeAndChange.pass; 
		x = onTriggerAction.y; 

		if (getPass){

			switch (x) {
			case 1: 
				oper.text = " 2 + 1 "; 
				break; 
			case 2: 
				oper.text = " 1 + 1 "; 
				break; 
			case 3: 
				oper.text = " 3 + 2 "; 
				break; 
			case 4: 
				oper.text = " 5 + 3 "; 
				break; 
			case 5: 
				oper.text = " 1 + 8 "; 
				break; 
			case 6: 
				oper.text = " 2 + 5 "; 
				break; 
			case 7: 
				oper.text = " 6 + 2 "; 
				break; 
			case 8: 
				oper.text = " 2 + 2 "; 
				break; 
			case 9: 
				oper.text = " 1 + 5"; 
				break; 
			case 10: 
				oper.text = " 3 + 1 "; 
				break; 

			}


		}

	}
}

