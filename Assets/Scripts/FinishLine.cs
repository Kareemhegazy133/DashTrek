using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{ 
	public GameManager gameManager;
	public GameObject player;

	void OnTriggerEnter2D()
	{
		if (player.transform.position.x >= 112)
		{
			gameManager.LevelComplete();
		}
	}
}
