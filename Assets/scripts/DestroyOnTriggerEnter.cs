using UnityEngine;
using System.Collections;

public class DestroyOnTriggerEnter : MonoBehaviour {
	public GameObject[] players;
	public GameObject[] playerAudio;


	void OnTriggerEnter (Collider activator){
		
		players = GameObject.FindGameObjectsWithTag("Player");
		
		for(int i = 0; i < players.Length; i++){
			
			Destroy(players[i]);
		}
		
		
//		playerAudio = GameObject.FindGameObjectsWithTag("PlayerAudio");
//		AudioSource audio = playerAudio.GetComponent<AudioSource>();
//		audio.Play ();
//		
		//AudioSource audio = playerAudio.GetComponent<AudioSource>();
		//audio.Play();
		for(int i = 0; i < playerAudio.Length; i++){
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			Debug.Log (audio);
		}
	}
}