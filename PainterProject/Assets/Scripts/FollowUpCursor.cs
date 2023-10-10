using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUpCursor : MonoBehaviour
{
    private Vector2 mainCursorPos;
    private float nextYPos;
    private float nextXPos;
    public GameObject player;
    public float cursorSpeed;
    public float cursorRange = 5.0f;
    private void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        mainCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        nextXPos = Vector2.MoveTowards(transform.position, mainCursorPos, cursorSpeed).x;
        nextYPos = Vector2.MoveTowards(transform.position, mainCursorPos, cursorSpeed).y;
        if (nextXPos <= player.transform.position.x +cursorRange && nextXPos >= player.transform.position.x -cursorRange 
            && nextYPos <= player.transform.position.y + cursorRange && nextYPos >= player.transform.position.y - cursorRange)
        {
            transform.position = Vector2.MoveTowards(transform.position, mainCursorPos, cursorSpeed);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, cursorSpeed);
        }
        


    }
}
