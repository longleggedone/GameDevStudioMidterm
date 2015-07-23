using UnityEngine;
using System.Collections;

public class PlayerMoveModeScript : MonoBehaviour {
	//player's standing object
	public GameObject playerStanding;
	//player's rolling object
	public GameObject playerRolling;
	//bool, is the standing object in use
	public bool upright = true;

	// Update is called once per frame
	void Update () {

		//attempt to create an offset vector3 to add or subtract from given objects transform.rotation 
		Vector3 rotationOffset = new Vector3 (90f, 270f, 0f);
		//tried to workaround by creating new vector3s for the objects, don't know what was thinking
		//Vector3 standingRotation = new Vector3 (playerStanding.transform.rotation.x, playerStanding.transform.rotation.y, playerStanding.transform.rotation.z);
		//Vector3 rollingRotation = new Vector3 (playerRolling.transform.rotation.x, playerRolling.transform.rotation.y, playerRolling.transform.rotation.z);
		if(Input.GetKeyDown(KeyCode.G) && upright){
			playerRolling.transform.position = playerStanding.transform.position;
			playerRolling.transform.rotation = Quaternion.Euler(playerStanding.transform.rotation.x + 90f,
			                                                	playerStanding.transform.rotation.y + 270f, 
			                                               	 	playerStanding.transform.rotation.z);
			playerStanding.SetActive (false);
			playerRolling.SetActive (true);
			upright = false;
		} else if (Input.GetKeyDown (KeyCode.G) && upright == false){
			playerStanding.transform.position = playerRolling.transform.position;
			playerStanding.transform.rotation = Quaternion.Euler(playerRolling.transform.rotation.x - 90f,
			                                                     playerRolling.transform.rotation.y - 270f, 
			                                                     playerRolling.transform.rotation.z);
			playerRolling.SetActive (false);
			playerStanding.SetActive (true);
			upright = true;	
		}
	}
}
