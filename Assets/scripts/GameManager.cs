using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public bool gameOver = false;
	public bool gameWin = false;
	
	
	
	void Update(){
		//checks for gameover or gamewin
		if(gameOver){
			//activates gameover after 2 seconds
			Invoke ("GameOver",2);
		}
		if(gameWin){
			//activates gamewin after 2 seconds
			Invoke ("GameWin",2);
		}
	}
	
	void GameOver(){
		//loads gameoverscreen
		Application.LoadLevel("GameOverScreen");
	}
	
	void GameWin(){
		//loads gamewinscreen
		Application.LoadLevel("GameWinScreen");
	}
}
