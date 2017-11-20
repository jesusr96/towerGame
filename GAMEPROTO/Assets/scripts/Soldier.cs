using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour {

	// Use this for initialization
	void Start () {
			GameObject castle = GameObject.Find("Castle");
			if(castle)
			GetComponent<UnityEngine.AI.NavMeshAgent>().destination = castle.transform.position;
	}
	void OnTriggerEnter(Collider co) {

		if (co.name == "Castle"){
			co.GetComponentInChildren<Health>().decrease();
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
