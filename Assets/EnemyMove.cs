using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{	
	void Start(){
		iTween.MoveBy (gameObject, iTween.Hash ("x", 8f, "easeType","easeOutQuad", "loopType", "pingPong", "delay", .2));
		iTween.MoveAdd (gameObject, iTween.Hash ("y", 1f, "easeType","easeInOutExpo", "loopType", "loop", "delay", .1));

		iTween.ScaleFrom(gameObject, iTween.Hash("x", -2f,"y",2f,"z",3f,"easeType","easeInOutQuad","loopType","pingPong","delay",.1));

	}

	void Update(){
		
	}

}

