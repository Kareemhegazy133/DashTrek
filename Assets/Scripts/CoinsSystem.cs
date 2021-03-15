using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSystem : MonoBehaviour
{
    public float coinsCollected = 0f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Coin")
        {
            coinsCollected += 1f;
            Destroy(other.gameObject);
        }
    }

}
