using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHealth : MonoBehaviour {
public float health;
	public GameObject damaged;
	public GameObject explosion;
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("EnemyBullet")){
			health--;
			Destroy(other.gameObject);
			Instantiate(damaged, other.gameObject.transform.position, other.gameObject.transform.rotation);
		}
		if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Enemy")){
			health = health - 5;
			Instantiate(damaged, other.gameObject.transform.position, other.gameObject.transform.rotation);
		}
		if(health <= 0){
			Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy(gameObject);
		}
	}
}
