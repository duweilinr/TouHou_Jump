using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Index_receiver : MonoBehaviour {
	int currentindex;
	string currentrarity;
	GameObject Sum_Can;

	void receive(){
		currentindex = Sum_manager.drawindex;
		currentrarity = Sum_manager.rarity;
		Sum_Can = GameObject.FindGameObjectWithTag ("SummonCanvas");
		Sum_Can.transform.FindChild ("Cha").GetComponent<Image> ().sprite = Sum_manager.imglist [currentindex].sprite;
		Sum_Can.transform.FindChild ("Rarity").GetComponent<Text> ().text = currentrarity;
	}
	void Update () {
		receive ();
	}
}
