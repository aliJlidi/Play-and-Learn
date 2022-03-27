using UnityEngine;
using System.Collections;
using System.Collections.Generic ; 
using UnityEngine.UI ; 

[System.Serializable]
public class ThisTrack : System.Object {
	public WheelCollider leftWheel ; 
	public GameObject leftWheelMesh ; 
	public WheelCollider rightWheel ; 
	public GameObject rightWheelMesh ; 
	public bool motor ; 
	public bool steering ; 
	public bool reverseTurn ; 


}

public class CarControler : MonoBehaviour {
	// set and get the input output 
	public bool forwardMove{ get ; set; } 
	public bool backwardMove{ get ; set ;} 
	public bool RightMove{ get ; set; } 
	public bool LeftMove{ get ; set ;} 
	// give a variable for the speed text 
	public Text speed; 
	public WheelCollider speedWheel; 
	public float motor ; 
	public float steering ;
	int speedVar ; 
	public float maxMotorTorque ; 
	public float maxSteeringAngel ; 
	public List<ThisTrack>truckInfos ; 
	AudioSource startSound ; 
	Rigidbody rb ; 

	public void VisualizeWheel(ThisTrack wheelPair ) {
		Quaternion rot; 
		Vector3 pos; 
		wheelPair.leftWheel.GetWorldPose (out pos, out rot); 
		wheelPair.leftWheelMesh.transform.position = pos; 
		wheelPair.leftWheelMesh.transform.rotation = rot; 
		wheelPair.rightWheel.GetWorldPose (out pos, out rot); 
		wheelPair.rightWheelMesh.transform.position = pos; 
		wheelPair.rightWheelMesh.transform.rotation = rot; 
	
	}
	// Use this for initialization
	void Start () {
	startSound = GetComponent<AudioSource> (); 
		startSound.Play(); 
		rb = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {
	if (Speed () != 0) {
			startSound.pitch = Mathf.Lerp (1, 2, Speed () * Time.deltaTime); 
		}
		if (forwardMove) {
			motor = maxMotorTorque * 1.5f; 
		} else if (backwardMove) {
			motor = maxMotorTorque * -2f; 
		} else {
			motor = 0f; 
		}
		if (RightMove) {
			steering = maxSteeringAngel * 1; 
		} else if (LeftMove) {
			steering = maxSteeringAngel * -1; 
		} else {
			steering = 0f; 
		}

		if (Speed () >= 0) {
			speed.text = "Speed :" +"\n\n" +Speed().ToString("f0")+"Km/h "; 
		}
		else {
			speed.text = "R"  ; 
		}
		foreach(ThisTrack truckInfo in  truckInfos  ) {
			if(truckInfo.steering == true ) {
				truckInfo.leftWheel.steerAngle = truckInfo.rightWheel.steerAngle =
					((truckInfo.reverseTurn)? -1 :1 )*steering;
				if ( steering != 0 ){
					rb.AddForce(0,-800*Mathf.Abs(steering),0);
				}
			}
			if (truckInfo.motor == true ) {
				truckInfo.leftWheel.motorTorque = motor ; 
				truckInfo.rightWheel.motorTorque = motor ; 
			}
			VisualizeWheel(truckInfo) ; 
		}
	
	}
	public float Speed(){
		return 0.85f * Mathf.PI * speedWheel.rpm* 60f / 1000f; 
	}
}
