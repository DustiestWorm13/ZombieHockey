using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwap2 : MonoBehaviour
{
    public PlayerMove2 playerMove;
    public PlayerMove2 player2Move;
    public bool player2Active = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            PlayerSwitch();
        }
    }

    public void PlayerSwitch()
    {
        if (player2Active)
        {
            playerMove.enabled = false;
            player2Move.enabled = true;
            player2Active = false;
        }
        else
        {
            playerMove.enabled = true;
            player2Move.enabled = false;
            player2Active = true;
        }
    }   
}

