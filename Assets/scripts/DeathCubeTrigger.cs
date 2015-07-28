using UnityEngine;
using System.Collections;

public class DeathCubeTrigger : MonoBehaviour {
	public GameObject[] players;
	public GameObject[] playerAudio;
	//public GameObject playerScream;
	//public ParticleSystem fireParticles; //assign in inspector
	//public GameObject target1;
	//public GameObject target2;
	//public Camera cam1;
	//public Camera cam2;
	//public GameObject camFocus;
	//if the player enters this trigger, delete the player from the game
	void OnTriggerEnter (Collider activator){

		players = GameObject.FindGameObjectsWithTag("Player");

		for(int i = 0; i < players.Length; i++){
			
			Destroy(players[i]);
		}


		playerAudio = GameObject.FindGameObjectsWithTag("PlayerAudio");

		//AudioSource audio = playerAudio.GetComponent<AudioSource>();
		//audio.Play();
		for(int i = 0; i < playerAudio.Length; i++){
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			Debug.Log ("triggered");
		}

		//fireParticles.Play (); //and now the fire will begin

		//to delete the whole thing, you must delete the game object

		//unnecessary since the player model is a separate object from the player object, and has no mesh
		//MeshRenderer mesh1 = target1.GetComponent<MeshRenderer>();
		//MeshRenderer mesh2 = target2.GetComponent<MeshRenderer>();
		//if (mesh1.enabled == true){
		//	mesh1.enabled = false;
		//}else if (mesh2.enabled == true){
		//	mesh2.enabled = false;
		//}
//		if (target1 == true){
//
//			//Instantiate(camFocus, target1.transform.position, target1.transform.rotation);
//			//cam1.GetComponent<CameraFollow>().target = camFocus;
//
//			Destroy (target1);
//			fireParticles.Play (); //and now the fire will begin
//		} else if (target2 == true){
//
//			//Instantiate (camFocus, target2.transform.position, target2.transform.rotation);
//			//cam2.GetComponent<CameraFollow>().target = camFocus;
//
//			Destroy (target2);
//			fireParticles.Play (); //and now the fire will begin
//		//Destroy (activator.gameObject);
//		//Destroy (toBeDestroyed);
//		}

	}
}
