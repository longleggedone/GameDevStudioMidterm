using UnityEngine;
using System.Collections;

public class RollRigidbody : MonoBehaviour {

	public float speed = 115f;
	public float turnSpeed = 90f;
	
	// FixedUpdate is called once per physics frame
	void FixedUpdate () {
		// "GetAxis" returns a float from -1 to 1
		// from a "virtual joystick"...
		float x = Input.GetAxis ("Horizontal"); // imagine [A] = -1, [D] = +1
		float y = Input.GetAxis ("Vertical"); // imagine [W] = +1, [S] = -1
		
		// transform.Translate (0f, 0f, y * speed * Time.deltaTime );
		Rigidbody rbody = GetComponent<Rigidbody>();
		Debug.Log (y);
		rbody.AddRelativeForce (y * speed * Time.deltaTime, 0f, 0f );
		//		rbody.AddForce (new Vector3(0f,10f,10f));
		
		transform.Rotate ( 0f, 0f, -x * turnSpeed * Time.deltaTime);
	}
}
