using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {

	public float jumpSpeed = 100f;
	public bool isGrounded = true;
	public bool isJumping = false;
	//public int jumpCounter = 1;

	// Update is called once per frame
	void Update () {
		Rigidbody rbody = GetComponent<Rigidbody>();
		//if (!isGrounded && rbody.velocity.y ==0){
		//	isGrounded = true;
		//}
		if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true){ //&& jumpCounter == 1){
			//jumpCounter += 1;
			isGrounded = false;
			isJumping = true;
		}
		//Debug.Log(jumpCounter);
	}

	void FixedUpdate (){
		Rigidbody rbody = GetComponent<Rigidbody>();
		if(isJumping == true){
			//Rigidbody rbody = GetComponent<Rigidbody>();
			rbody.AddForce(Vector3.up * jumpSpeed);
			isJumping = false;
			//isGrounded = false;
			//jumpCounter = 1;
		}
		if (!isGrounded && rbody.velocity.y ==0){
			isGrounded = true;

		}
	}

//	void Jump(){
//		Rigidbody rbody = GetComponent<Rigidbody>();
//		rbody.AddForce(Vector3.up * jumpSpeed);
//		isFalling = true;
//	}
//
//	void OnCollisionStay(){
//		isFalling = false;
//	}
}
