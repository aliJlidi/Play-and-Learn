using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class CaseNum2 : MonoBehaviour {

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
		x = characterTrigger.increaseNum ; 

		if (getPass){

			switch (x) {
			case 1: 
				oper.text = " 10 "; 
				break; 
			case 2: 
				oper.text =  " 11"; 
				break; 
			case 3: 
				oper.text = " 12 "; 
				break; 
			case 4: 
				oper.text = " 13 "; 
				break; 
			case 5: 
				oper.text = " 14 "; 
				break; 
			case 6: 
				oper.text = " 15 "; 
				break; 
			case 7: 
				oper.text = " 16 "; 
				break; 
			case 8: 
				oper.text = " 17 "; 
				break; 
			case 9: 
				oper.text = " 18 "; 
				break; 
			case 10: 
				oper.text = " 19 "; 
				break; 
			case 11: 
				oper.text = " 20 "; 
				break; 

			}


		}

	}
}

