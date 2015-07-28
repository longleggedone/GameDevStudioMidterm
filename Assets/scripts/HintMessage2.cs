using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HintMessage2 : MonoBehaviour {
	public Text hintText;

	void OnTriggerEnter(Collider activator){
		hintText.GetComponent<Text>().text = "Press G again to switch back to standing!";
	}
}
