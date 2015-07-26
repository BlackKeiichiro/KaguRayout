using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {
	void Awake(){
		nowObject = GameObject.Find("EmptyObject") as GameObject;
		kagucount = 0;
	}
	void Update(){
		Text nowObjtext = GameObject.Find("Canvas/Now/Text").GetComponent<Text>();
		nowObjtext.text = nowObject.name;
	}
	public void DeleteObject(){
		if(nowObject.name != "EmptyObject"){
			keep = nowObject;
			nowObject = GameObject.Find("EmptyObject") as GameObject;
			Destroy(GameObject.Find(keep.name));
		}
	}
	public GameObject nowObject;
	private GameObject keep;
	public int kagucount;	
}
