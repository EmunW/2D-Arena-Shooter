using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOn : MonoBehaviour {

	private Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//A vector pointing to where the target is
    	target = GameObject.FindWithTag ("Player").transform;
		Vector3 direction = target.position - transform.position;
		//Turn to look at target
		float angle = Mathf.Atan2(direction.y, direction.x);
		transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90f);
	}
}
