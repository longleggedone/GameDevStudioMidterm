using UnityEngine;
using System.Collections;

public class GameOverOnDestroy : MonoBehaviour {
	
	void OnDestroy(){
		//finds game manager
		GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");		
		if(gameManagerObject != null){
			
			//gets gameManager object's gameManager script
			GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
			//changes var in gameManager script
			gameManager.gameOver = true;
		}
	}
}
