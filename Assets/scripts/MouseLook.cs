﻿using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public Camera myCamera;

	float rotationY; //will store our current pitch

	// Update is called once per frame
	void Update () {
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		//transform.Rotate (0f, mouseX, 0f); //YAW, horizontal rotation, turns capsule and camera

		//myCamera.transform.Rotate (-mouseY, 0f, 0f); //PITCH, vertical rotation of camera not capsule
		//myCamera.transform.localEulerAngles += new Vector3(-mouseY, 0f, 0f); // same as above only with euler

		//CLAMPED Y-LOOK
		// 1) modify pitch
		rotationY -= mouseY;
		//rotationY -= mouseY * 2f; //looks twice as fast
		// 2) correct pitch / clamp it
		rotationY = Mathf.Clamp (rotationY, -80f, 80f);
		// 3) apply the pitch to the camera
		myCamera.transform.localEulerAngles = new Vector3(rotationY,0f, 0f);
		//myCamera.transform.position = new Vector3 (0f, rotationY, 0f);


}
}