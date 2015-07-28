using UnityEngine;
using System.Collections;

//"SINGLETON"
//"game manager" / "logic controller"
// and there's only ONE

public class GameLogic : MonoBehaviour {

	// "static" means it live in the code memory itself
	//"static" means it does not live on a GameObject
	//this can ONLY be one copy
	//public static GameLogic instance;

	public int currentScore = 0;

	// Use this for initialization
	void Start () {
		//instance = this;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
