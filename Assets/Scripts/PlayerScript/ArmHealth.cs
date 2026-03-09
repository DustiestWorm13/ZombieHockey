using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmHealth : MonoBehaviour
{
    [SerializeField]
    int armHealth = 3;
    [SerializeField]
    GameObject rightArm;

    public bool armFell = false;
    public bool armDropComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Health script!");
    }
    private void OnTriggerEnter2d (Collider2D collider)
    {
        Debug.Log("Trigger interaction!");        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision with :" + collision.gameObject.tag);
        //Debug.Log("Arm drop complete: " + armDropComplete);

        if (armDropComplete == false)
        {
            if (collision.gameObject.tag == "Arm") // this also needs to only happen when stick is "attacking"
            {
                armHealth -= 1;
                //Debug.Log(armHealth);
            }
            if (collision.gameObject.tag == "Arm" && armHealth == 0)
            {
                Debug.Log("Arm falls!");
                rightArm.transform.parent = null;
                armFell = true;
            }
            if(armFell == true)
            {
                armDropComplete = true;
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
