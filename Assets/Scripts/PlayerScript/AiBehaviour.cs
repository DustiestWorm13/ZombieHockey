using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBehaviour : MonoBehaviour
{
    State currentState;
 
    // Update is called once per frame
    void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        //State nextState = currentState != null ? currentState.RunCurrentState : null;

       // if(nextState != null)
        {
            //switch to next state
        }
    }

    private void SwitchToNextState(State nextState)
    {
        currentState = nextState;
    }
}
