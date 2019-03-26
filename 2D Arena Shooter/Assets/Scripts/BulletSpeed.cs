using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour {

	public float speed;

	public GameObject bulletExplosion;
	public GameObject impact;

	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.up * speed * Time.deltaTime;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(gameObject.CompareTag("Bullet")){
			if(other.gameObject.CompareTag("EnemyBullet") || other.gameObject.CompareTag("RedBullet")){
				Instantiate(bulletExplosion, gameObject.transform.position, gameObject.transform.rotation);
				Destroy(gameObject);
				Destroy(other.gameObject);
			}
		}
		if(gameObject.CompareTag("EnemyBullet")){
			if(other.gameObject.CompareTag("RedBullet") || other.gameObject.CompareTag("Bullet")){
				Instantiate(bulletExplosion, gameObject.transform.position, gameObject.transform.rotation);
				Destroy(gameObject);
				Destroy(other.gameObject);
			}
		}
		if(gameObject.CompareTag("RedBullet")){
			if(other.gameObject.CompareTag("EnemyBullet") || other.gameObject.CompareTag("Bullet")){
				Instantiate(bulletExplosion, gameObject.transform.position, gameObject.transform.rotation);
				Destroy(gameObject);
				Destroy(other.gameObject);
			}
		}
	}
}
