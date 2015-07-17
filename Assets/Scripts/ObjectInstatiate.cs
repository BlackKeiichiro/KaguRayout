using UnityEngine;
using System.Collections;

public class ObjectInstatiate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float  z = 0;
		for(int i = 0;i < 10;i++){
			float x = 0;
			for(int j = 0;j < 10;j++){
				GameObject localobject = Instantiate(Resources.Load("Prefabs/Attach")) as GameObject;
				localobject.transform.position = new Vector3(45f - x,14,44.5f - z);
				localobject.transform.parent = this.transform;
				x += 10;
			}
			z += 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
