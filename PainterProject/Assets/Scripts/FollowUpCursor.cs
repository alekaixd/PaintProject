using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class FollowUpCursor : MonoBehaviour
{
    private Vector2 mainCursorPos;
    private Vector2 nextPos;
    private bool insideArea;
    public GameObject player;
    public float cursorSpeed;
    public float cursorRange = 5.0f;
    public GameObject circleCollider;

    private void Start()
    {
        nextPos = transform.position;
    }


    private void Update()
    {
        mainCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (insideArea == true)
        {
            nextPos = Vector2.MoveTowards(transform.position, mainCursorPos, cursorSpeed);
        }
        else
        {
            nextPos = Vector2.MoveTowards(transform.position, player.transform.position, cursorSpeed);
        }
        
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = nextPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MouseField"))
        {
            insideArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("MouseField"))
        {
            insideArea = false;
        }
    }
}
