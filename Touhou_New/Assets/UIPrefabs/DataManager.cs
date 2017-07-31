using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {
	static int num = Cha_Box.chabox_children_count;
	public static int money;
	public static bool[] locklist = new bool[num];
	public static int slct_cha_index;
//	void Awake() {
//		DontDestroyOnLoad(transform.gameObject);
//	}
}