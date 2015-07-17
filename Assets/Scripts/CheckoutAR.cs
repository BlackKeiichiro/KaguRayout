using UnityEngine;
using System.Collections;

public class CheckoutAR : MonoBehaviour {
	void Awake(){
		ARs = GameObject.Find("ARs") as GameObject;
		setAR = false;
	}
	public void ChangeAR(){
		setAR = (!setAR)?true:false;
		foreach(Transform myson in ARs.transform){
			myson.gameObject.SetActive(setAR);
		}
	}
	private GameObject ARs;
	public bool setAR;
}
