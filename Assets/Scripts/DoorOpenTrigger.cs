using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenTrigger : MonoBehaviour {

	public SpriteRenderer youwin;
	public SpriteRenderer youlose;

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			youwin.enabled = true;
		}
	}
}
