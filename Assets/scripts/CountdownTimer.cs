using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {
	public Text timerText;
	public Text hintText;
	public float timer = 90.0f;

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		int timerInt = (int)Mathf.Round(timer);
		string textBuffer = "Time left: " + timerInt;
		timerText.GetComponent<Text>().text = textBuffer;
		if(timer <= 0){
			hintText.GetComponent<Text>().text = "(x_x)";
			GameObject gameManagerObject = GameObject.FindGameObjectWithTag("GameManager");		
			if(gameManagerObject != null){
				
				//gets gameManager object's gameManager script
				GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
				//changes var in gameManager script
				gameManager.gameOver = true;
			}
		}else if(timer <= 5){
			hintText.GetComponent<Text>().text = "OH NO IT'S HERE!";
		}else if (timer <= 15){
			hintText.GetComponent<Text>().text = "I CAN HERE SOMETHING COMING CLOSER!";
		}else if (timer <= 30){
			hintText.GetComponent<Text>().text = "I'M RUNNING OUT OF TIME!";
		}else if (timer <= 60){
			hintText.GetComponent<Text>().text = "I CAN'T STAY HERE MUCH LONGER!";
		}else if (timer <= 120){
			hintText.GetComponent<Text>().text = "BETTER PICK UP THE PACE!";
		}

	}
}

