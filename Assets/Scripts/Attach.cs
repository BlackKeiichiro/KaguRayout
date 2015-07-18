using UnityEngine;
using System.Collections;

public class Attach : MonoBehaviour {
	// Use this for initialization
	void Start () {
		clear = Resources.Load("Materials/clear") as Material;
	}
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(this.transform.position,Vector3.up,out hit,2)){
			Kagu kagu = hit.transform.gameObject.transform.GetComponent<Kagu>();
			switch(kagu.getKaguName()){
				case "isu":
					_color = Color.blue;
				break;
				case "colorbox":
					
				break;
				case "desk":
					_color = Color.yellow;
				break;
			}
		}
		else _color = clear.color;
		this.transform.GetComponent<MeshRenderer>().material.color = _color;
	}
	private Material clear;
	private RaycastHit hit;
	private Color _color;
}