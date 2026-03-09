using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addRigidbody : MonoBehaviour
{
    [SerializeField]
    ArmHealth armHealth;

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(armHealth.armFell == true)
        {
            Debug.Log("Adding Rigidbody!");
            /*foreach (Transform child in transform)
            {
                //transform.parent = null;
                //Destroy(child.gameObject);
            }*/
            Rigidbody2D rigid = gameObject.AddComponent<Rigidbody2D>();
            rigid.gravityScale = 0;
            
        }
    }
}
