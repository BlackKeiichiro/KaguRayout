using UnityEngine;
using System.Collections;

public class LongDesk : Kagu {

	// Use this for initialization
	override protected void Start () {
		kagu_name = "longdesk";
		objectsizey = this.transform.localScale.y/this.transform.localScale.y*1.8f;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
