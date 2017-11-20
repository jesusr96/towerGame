using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 10;

	public Transform target;

	void fixedupdate(){

		if(target){
			Vector3 dir = target.position - transform.position;
			GetComponent<Rigidbody> ().velocity = dir.normalized * speed;
		}else{
			Destroy (gameObject);
		}

	}
		void OnTriggerEnter(Collider co) {
			Health Health = co.GetComponentInChildren<Health>();
			if (Health) {
			Health.decrease();
			Destroy (gameObject);
		}

	

		}
	}

