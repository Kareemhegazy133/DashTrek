using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumEffect : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float leftpushRange;
    public float rightpushRange;
    public float velocityThreshold;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.angularVelocity = velocityThreshold;
    }

    // Update is called once per frame
    void Update()
    {
        activateEffect();
    }

    public void activateEffect()
	{
        if(transform.rotation. z > 0 && transform.rotation.z < rightpushRange && (rigidBody.angularVelocity > 0) && rigidBody.angularVelocity < velocityThreshold)
		{
            rigidBody.angularVelocity = velocityThreshold;
		}
        
        else if (transform.rotation.z < 0 && transform.rotation.z > leftpushRange && (rigidBody.angularVelocity < 0) && rigidBody.angularVelocity > velocityThreshold * -1)
		{
            rigidBody.angularVelocity = velocityThreshold * -1;
        }

    }
}
