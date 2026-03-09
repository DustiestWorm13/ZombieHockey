using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class GoalRed : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        ScoreRed.instance.AddPoint();
        if (other.gameObject.name == "limb")
        {
            other.transform.position = new Vector3(0, 0, 0);
        }
    }
}

