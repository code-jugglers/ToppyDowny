using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public int speed;
	private Rigidbody2D rb;
	public int health = 100;

	public bool dead {
		get { return health <= 0; }
	}

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		speed = 4;
	}

	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		transform.position +=  new Vector3 (moveHorizontal, moveVertical, 0) * Time.deltaTime * speed;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.CompareTag ("Soda")) {
			other.gameObject.SetActive (false);
		}
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag ("Enemy")) {
			health = health - 25;
		}
	}
}
