using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class CarCase3 : MonoBehaviour {

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
				oper.text = " 6 + 6 "; 
				break; 
			case 2: 
				oper.text = " 8 + 7 "; 
				break; 
			case 3: 
				oper.text = " 6 + 5 "; 
				break; 
			case 4: 
				oper.text = " 8 + 6 "; 
				break; 
			case 5: 
				oper.text = " 5 + 5 "; 
				break; 
			case 6: 
				oper.text = " 5 + 8 "; 
				break; 
			case 7: 
				oper.text = " 9 + 9 "; 
				break; 
			case 8: 
				oper.text = " 8 + 8 "; 
				break; 
			case 9: 
				oper.text = " 9 + 10 "; 
				break; 
			case 10: 
				oper.text = " 9 + 8 "; 
				break; 
			case 11: 
				oper.text = " 10 + 10 "; 
				break; 

			}


		}

	}
}

