using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

	public Transform playerPosition;

	void Update () {
		this.transform.position = new Vector3 (playerPosition.position.x, this.transform.position.y, this.transform.position.z);
	}

}
