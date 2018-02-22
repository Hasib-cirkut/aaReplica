using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public rotator rotator_;
	public Shooter shooter;
	public Animator animator;
	private bool gameHasEnded = false;


	public void EndGame()
	{
		if(gameHasEnded)
			return;

		rotator_.enabled = false;
		shooter.enabled = false;

		animator.SetTrigger("EndGame");

		gameHasEnded = true;
		Debug.Log("Game Ended");
	}

}
