using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoalBlue : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D other)
    {
        ScoreBlue.instance.AddPoint();
        if(other.gameObject.name == "limb")
        {
            other.transform.position = new Vector3(0, 0, 0);
        }
        
    }
}
