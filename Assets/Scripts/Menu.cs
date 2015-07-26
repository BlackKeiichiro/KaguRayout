using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Menu : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
	void Awake(){
		_animator = this.transform.GetComponent<Animator>();
	}
	void Start () {
			
	}
	
	void Update () {
	
	}
	public void OnPointerEnter(PointerEventData eventData){
		_animator.SetBool("Pop",true);
	}
	public void OnPointerExit(PointerEventData eventData){
		_animator.SetBool("Pop",false);
	}
	
	private Animator _animator;
}
