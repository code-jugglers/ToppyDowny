using UnityEngine;
using System.Collections;

public class EmemyController : MonoBehaviour {
	private GameObject target;
	private int speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (1, 4);
		target = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 heading = target.transform.position - transform.position;

		transform.position += (heading/heading.magnitude) * speed * Time.deltaTime;
	}
}
