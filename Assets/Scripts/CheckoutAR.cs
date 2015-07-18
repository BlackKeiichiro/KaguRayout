using UnityEngine;
using System.Collections;

public class CheckoutAR : MonoBehaviour {
	void Awake(){
		ARs = GameObject.Find("ARs") as GameObject;
	}
	public void ChangeAR(){
		foreach(Transform myson in ARs.transform){
			myson.gameObject.SetActive((myson.gameObject.activeSelf?false:true));
		}
	}
	private GameObject ARs;
}
