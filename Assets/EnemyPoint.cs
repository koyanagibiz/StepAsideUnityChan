using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoint : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "BulletTag") {
			FindObjectOfType<Score> ().AddPoint (200);
			Destroy (this.gameObject);


		}
			
	}
}
