using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {
	public GameObject target;

	private Vector3 offset;
	
	void Start() {
		offset =  transform.position - target.transform.position;
	}
	
	void LateUpdate() {

		transform.position = target.transform.position + offset;

		transform.LookAt(target.transform);
	}
}
