using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap : MonoBehaviour
{
    public PlayerMove playerMove;
    public PlayerMove player2Move;
    public bool player1Active = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerSwitch();
        }
    }

    public void PlayerSwitch()
    {
        if (player1Active)
        {
            playerMove.enabled = false;
            player2Move.enabled = true;
            player1Active = false;
        }
        else
        {
            playerMove.enabled = true;
            player2Move.enabled = false;
            player1Active = true;
        }
    }

    
}
