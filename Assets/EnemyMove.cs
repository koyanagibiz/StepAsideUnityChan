using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour
{	
	void Start(){
		iTween.MoveBy (gameObject, iTween.Hash ("x", 12f, "easeType", "easeInOutQuad", "loopType", "pingPong", "delay", .0));
		iTween.MoveAdd (gameObject, iTween.Hash ("y", 3f, "easeType", "easeInBack", "loopType", "loop", "delay", .2));
		iTween.MoveAdd (gameObject, iTween.Hash ("z", 15f, "easeType", "easeOutBounce", "loopType", "loop", "delay", .1));
		iTween.MoveAdd (gameObject, iTween.Hash ("x", -7f, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));

	}

	void Update(){
		
	}

}

