using UnityEngine;
using System.Collections;

public class TrapTimer : MonoBehaviour {
	public GameObject fire;
	public float timer = 4.0f;
	//public ParticleSystem fireParticles; //assign in inspector
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if(timer <= 0){
			fire.SetActive (true);
			Invoke ("trapReset", 5);
			timer = 9;
		}
	}
	void trapReset(){
		fire.SetActive (false);
		//fireParticles.Play ();
		}
}
