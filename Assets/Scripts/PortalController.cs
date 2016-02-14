using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PortalController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		SceneManager.LoadScene ("Level1");
		Debug.Log("fuck back");
	}
}
