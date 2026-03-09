using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckMovement : MonoBehaviour
{
    public float force = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision c)
    {
        
        if (c.gameObject.tag == "Puck" || c.gameObject.tag == "Stick")
        {
            Vector3 dir = c.contacts[0].point - transform.position;
            dir = -dir.normalized;
            GetComponent<Rigidbody>().AddForce(dir * force * Time.deltaTime);
        }
    }


// Update is called once per frame
    void Update()
    {
        
    }

}