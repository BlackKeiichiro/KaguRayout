using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	void Awake(){
		nowObject = null;
		kagucount = 0;
	}
	public GameObject nowObject;
	public int kagucount;
}
