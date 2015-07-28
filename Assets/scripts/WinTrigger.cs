using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour {



	void OnTriggerEnter (Collider accessor) {

		GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");		
		if(gameManagerObject != null){
			
			//gets gameManager object's gameManager script
			GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
			//changes var in gameManager script
			gameManager.gameWin = true;
		}
	}
}
