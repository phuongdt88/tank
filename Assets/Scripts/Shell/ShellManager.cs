using UnityEngine;
using System.Collections;

public class ShellManager : MonoBehaviour {


	public float speed = 50f;
	Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.velocity = transform.forward * speed;
	}
	

	// Update is called once per frame
	void Update () {
	
	}
}
