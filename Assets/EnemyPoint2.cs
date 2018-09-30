using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoint2 : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "BulletTag") {
			FindObjectOfType<Score> ().AddPoint (250);
			Destroy (this.gameObject);


		}

	}
}
