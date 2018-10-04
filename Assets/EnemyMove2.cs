using UnityEngine;
using System.Collections;

public class EnemyMove2 : MonoBehaviour
{	
	void Start(){

		iTween.MoveBy (gameObject, iTween.Hash ("x", -7f, "easeType","easeOutQuad", "loopType", "pingPong", "delay", .1));
		iTween.MoveAdd (gameObject, iTween.Hash ("y", -1f, "easeType","easeInOutExpo", "loopType", "loop", "delay", .1));

		iTween.ScaleFrom(gameObject, iTween.Hash("x", -3f,"y",2f,"z",4f,"easeType","easeInOutQuad","loopType","pingPong","delay",.1));

	}

	void Update(){



	}

}

