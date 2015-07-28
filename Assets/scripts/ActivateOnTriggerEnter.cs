using UnityEngine;
using System.Collections;

public class ActivateOnTriggerEnter : MonoBehaviour {

	public GameObject[] traps;

	void OnTriggerEnter(Collider activator){
		//Debug.Log ("triggered");

		//turns out this doesn't work on objects that are already inactive
		//traps = GameObject.FindGameObjectsWithTag("Trap");
		for(int i = 0; i < traps.Length; i++){
			traps[i].SetActive (true);
		}
	}
}
