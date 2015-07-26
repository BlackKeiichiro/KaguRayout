using UnityEngine;
using System.Collections;

public class InstantKagu : MonoBehaviour {
	void Awake(){
		manager = GameObject.Find("Manager").GetComponent<Manager>();
	}
	public void DropKagu(GameObject kagu){
		int count = 0;
		foreach(GameObject obj in UnityEngine.Object.FindObjectsOfType(typeof(GameObject))){
			if(obj.name.Contains(kagu.name)){
				count++;
			}		
		}
		GameObject localobject = Instantiate(Resources.Load("Prefabs/"+kagu.name)) as GameObject;
		localobject.transform.position = new Vector3(0,25,0);
		localobject.name = kagu.name + count++.ToString();
	}
	Manager manager;
}
