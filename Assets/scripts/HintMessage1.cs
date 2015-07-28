using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HintMessage1 : MonoBehaviour {
	public Text hintText;

	void OnTriggerEnter(Collider activator){
		hintText.GetComponent<Text>().text = "Press G to switch to rolling mode! Use W and S to move!";
	}
}
