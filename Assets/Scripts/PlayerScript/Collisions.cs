using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2d(Collider2D collider)
    {
        Debug.Log("Trigger interaction!");

        /*if (collider.gameObject.tag == "Stick") // this also needs to only happen when stick is "attacking"
        {
          armHealth -= 1;
          Debug.Log(armHealth);
        }
        if(collider.gameObject.tag == "Stick" && armHealth == 0)
        {
            Debug.Log("Arm falls!");
          //arm drops to floor
        }*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with collider");
    }
}
