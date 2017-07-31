using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chamanager : MonoBehaviour {
	public Image myImageComponent;
	public Image myStateBtnImage;
	public Text myText;
	public Sprite my_cha_Image;
	public string my_rarity;
	public int current_index;
	public int slcted_index;
	public bool load_index_flag = false;
	public Sprite GreenBtn;
	public Sprite GreyBtn;
	// Use this for initialization
	void Start(){
		current_index = -1;
	}
	// Update is called once per frame
	void Update () {
		if (load_index_flag) {
			regular_check ();
			load_index_flag = false;
		}
	}

	public void regular_check(){
		SnL.request_for_load_index = true;
		slcted_index = DataManager.slct_cha_index;
		img_receive ();
		if (slcted_index == current_index) {
			print ("Go Green");
			myStateBtnImage.sprite = GreenBtn;
		}
		if (slcted_index != current_index) {
			print ("Go Grey");
			myStateBtnImage.sprite = GreyBtn;
		}
	}
	public void img_receive(){
		myImageComponent.sprite = my_cha_Image;
		myText.text = my_rarity;
	}

	public void Button(){
		SnL.select_cha_index = current_index;
		SnL.request_for_save_index = true;
		SnL.request_for_load_index = true;
		StartCoroutine (Btnwork ());
	}
	IEnumerator Btnwork(){
		yield return new WaitForSeconds(0.1f);
		int data_index = DataManager.slct_cha_index;
		if (data_index == current_index) {
			print ("Go Green");
			myStateBtnImage.sprite = GreenBtn;
		}
		if (data_index != current_index) {
			print ("Go Grey");
			myStateBtnImage.sprite = GreyBtn;
		}
	}


}
