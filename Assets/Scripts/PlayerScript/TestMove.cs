using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour

{
    public Rigidbody2D rb;
    Vector2 movement, movementOrder;
    bool moveUp = false, moveLeft = false, moveDown = false, moveRight = false;
    [SerializeField]
    float fSpeed = 1.5f, fMaxSpeed = 5.0f, fFriction = 3.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveUp = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDown = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRight = true;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            moveUp = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            moveLeft = false;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            moveDown = false;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveRight = false;
        }
    }

    void FixedUpdate()
    {
        //movement order
        if(moveUp && !moveDown)
        {
            movementOrder.y = fMaxSpeed;
        }
        else if (moveDown && !moveUp)
        {
            movementOrder.y = -fMaxSpeed;
        }
        else if (moveDown && moveUp)
        {
            movementOrder.y = 0;
        }
        if(moveRight && !moveLeft)
        {
            movementOrder.x = fMaxSpeed;
        }
        else if (moveLeft && !moveRight)
        {
            movementOrder.x = -fMaxSpeed;
        }
        else if (moveLeft && moveRight)
        {
            movementOrder.x = 0;
        }

        //Executing Order
        if(moveUp && movement.y < movementOrder.y)
        {
            movement.y += fSpeed * Time.fixedDeltaTime;
        }
        if(moveDown && movement.y > movementOrder.y)
        {
            movement.y -= fSpeed * Time.fixedDeltaTime;
        }
        if(moveLeft && movement.x > movementOrder.x)
        {
            movement.x -= fSpeed * Time.fixedDeltaTime;
        }
        if(moveRight && movement.x < movementOrder.x)
        {
            movement.x += fSpeed * Time.fixedDeltaTime;
        }

        //Friction
        if(!moveUp && !moveDown && movement.y > 0)
        {
            movement.y += fSpeed * fFriction * Time.fixedDeltaTime;
        }
        else if(!moveUp && !moveDown && movement.y > 0)
        {
            movement.y -= fSpeed * fFriction * Time.fixedDeltaTime;
        }
         if(!moveRight && !moveLeft && movement.y > 0)
        {
            movement.x += fSpeed * fFriction * Time.fixedDeltaTime;
        }
        else if(!moveRight && !moveLeft && movement.y > 0)
        {
            movement.x -= fSpeed * fFriction * Time.fixedDeltaTime;
        }

        //Updating the position
        gameObject.transform.position = gameObject.transform.position + (Vector3) movement * fSpeed * Time.fixedDeltaTime;
       //Debug.DrawLine(gameObject.transform.position, gameObject.transform.position + (Vector3)movement);
    }
}
/*
{
    [SerializeField]
    float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveCharacter(new Vector2(0, 1));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveCharacter(new Vector2(0, -1));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveCharacter(new Vector2(1, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveCharacter(new Vector2(-1, 0));
        }
    }

    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
*/