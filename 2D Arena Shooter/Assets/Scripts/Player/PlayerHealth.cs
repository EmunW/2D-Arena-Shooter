using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public float health;
	public GameObject damaged;
	public GameObject explosion;
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("EnemyBullet") || other.gameObject.CompareTag("RedBullet")){
			health--;
			Instantiate(damaged, other.gameObject.transform.position, other.gameObject.transform.rotation);
			Destroy(other.gameObject);
		}
		if(other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("RedEnemy")){
			health = health - 5;
			Instantiate(damaged, other.gameObject.transform.position, other.gameObject.transform.rotation);
		}
		if(health <= 0){
			Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
			Destroy(gameObject);
		}
	}
}
