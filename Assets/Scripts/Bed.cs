using UnityEngine;
using System.Collections;

public class Bed : Kagu {
	override protected void Start () {
		kagu_name = "bed";
		objectsizey = this.transform.localScale.y/this.transform.localScale.y*1.8f;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
