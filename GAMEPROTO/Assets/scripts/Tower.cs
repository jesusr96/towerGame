using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	public GameObject bulletPrefab;

	public float rotationSpeed = 35;

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);	
	}

	void OnTriggerEnter(Collider co) {

		if (co.GetComponent<Soldier> ()) {
			GameObject g = (GameObject)Instantiate (bulletPrefab, transform.position, Quaternion.identity);
			g.GetComponent<Bullet> ().target = co.transform;
		}
	}
}
