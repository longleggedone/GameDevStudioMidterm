using UnityEngine;
using System.Collections;

public class StartScreenManager : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			//reloads current level
			Application.LoadLevel("Level1");
		}
	}
}
