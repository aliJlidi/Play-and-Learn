using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public bool moveForward { get ; set ; }
	public bool moveBackward { get ; set ; }
	public bool moveLeft { get ; set ; }
	public bool moveRight { get ; set ; }
	public bool running { get ; set ; }
	public bool moveJump{ get ; set ; }
	public float walkSpeed = 2 ; 
	public float runSpeed = 6 ; 
	public float gravity = -10f ; 
	float velocityY ; 
	public float jumpHiegh = 1 ;

	public float turnSmouthTime = 0.2f; 
	float turnSmoothVelocity ; 

	public float speedSmouthTime = 0.1f ; 
	float speedSmoothVelocity ; 

	float currentSpeed ; 
	Animator animator ; 
	Transform cameraT ; 
	CharacterController controller ; 

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> (); 
		cameraT = Camera.main.transform; 
		controller = GetComponent<CharacterController> ();  
	}

	// Update is called once per frame
	void Update () {
		//recieve the input and normalize them to get perfect mouvement 
		Vector2 input = new Vector2 (Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) ; 
		if ((moveForward || running) && controller.isGrounded) {
			input = new Vector2 (0, 1); 
		}
		if (moveLeft && controller.isGrounded) {
			input = new Vector2 (-1, 0); 
		}
		if (moveRight && controller.isGrounded) {
			input = new Vector2 (1, 0); 
		}
		Debug.Log (input); 
		Vector2 inputDir = input.normalized; 
		//jump move 
		if (moveJump && controller.isGrounded ) {
			StartCoroutine (Jump ());

		}

		//find the angle of rotation when the two direction are combined and attch them to the rotation value
		//smooth the rotation by it's time 
		if (inputDir != Vector2.zero ) {
			float targetRotation = Mathf.Atan2 (inputDir.x, inputDir.y) *
				Mathf.Rad2Deg + cameraT.eulerAngles.y;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle (transform.eulerAngles.y, targetRotation,
				ref turnSmoothVelocity, turnSmouthTime);
		}
		// play animation  

			float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
			currentSpeed = Mathf.SmoothDamp (currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmouthTime); 
			velocityY += Time.deltaTime * gravity; 
			Vector3 velocity = transform.forward * currentSpeed + Vector3.up * velocityY;
			controller.Move (velocity * Time.deltaTime); 


		// attaching the animation to the paramater
		float animationSpeedPercent = ((running)? 0.66f : .33f ) * inputDir.magnitude ; 
		animator.SetFloat("SpeedPercent",animationSpeedPercent ,speedSmouthTime,Time.deltaTime);

	}



	IEnumerator Jump() {
		if (controller.isGrounded) {
			
			yield return new WaitForSeconds (.3f);
			animator.SetFloat("SpeedPercent", 1.4f );
			float jumpVelocity = Mathf.Sqrt (-2 * gravity * jumpHiegh);
			velocityY = jumpVelocity;
			yield return new WaitForSeconds (.5f);
		}
			
		moveJump = false; 

	}



}

