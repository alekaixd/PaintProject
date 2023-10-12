using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollection : MonoBehaviour
{
    public GameObject player;
    public NextLevel nextLevel;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            nextLevel.stars += 1;
            Destroy(gameObject);
        }
    }

}
