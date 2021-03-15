using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingEffect : MonoBehaviour
{
    public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D (Collider2D col)
	{
        if(col.gameObject.name == "Player")
		{
            rigidBody.isKinematic = false;
		}
	}
}
