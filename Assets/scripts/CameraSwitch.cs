using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {
	public GameObject[] cameras;
	public float newXOffset = 0f;
	public float newYOffset = 0f;
	public float newZOffset = 0f;
	public float xAngle = 0f;

	// Update is called once per frame
	void OnTriggerEnter (Collider activator){
		cameras = GameObject.FindGameObjectsWithTag("MainCamera");

		for(int i = 0; i < cameras.Length; i++){

			cameras[i].transform.rotation = Quaternion.Euler (xAngle, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
			cameras[i].GetComponent<CameraFollow>().xOffset = newXOffset;
			cameras[i].GetComponent<CameraFollow>().yOffset = newYOffset;
			cameras[i].GetComponent<CameraFollow>().zOffset = newZOffset;
		}
	}
}
