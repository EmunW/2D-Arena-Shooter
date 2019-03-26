using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

	public Transform Player;
 	public float speed;
 	void Update (){
    	Player = GameObject.FindWithTag ("Player").transform;
    	transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
 	}
}
