using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atttack : MonoBehaviour
{
    bool stickInRightHand = true;
    bool stickInLeftHand = false;
    bool justAtttacked = false;
    
    [SerializeField]
    float cooldownTimer = 1.2f;
    float currentTime = 0f;
    float startingTime = 0f;
    
    [SerializeField]
    public Animator anim;

    //[SerializeField]
    //Vector3 rotation;

    [SerializeField]
    GameObject leftHand;
    [SerializeField]
    GameObject rightHand;

    // Start is called before the first frame update
    void Start()
    {
        //startingTime = cooldownTimer;
        currentTime = cooldownTimer;

        if(leftHand == false || rightHand == false)
        {
            Debug.Log("Hand not allocated correctly");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && stickInRightHand)
        {
            //right hand attack
            rightHand.GetComponent<Animator>().Play("AttackRightHand");
            //Debug.Log("Attack (right hand)");
            justAtttacked = true;
        }

        if (currentTime > 0 && justAtttacked == true)
        {
             currentTime -= 1 * Time.deltaTime;
             //Debug.Log(currentTime);
             //Debug.Log("Timer should decrease here : " + timer);
        }   

        if (Input.GetKeyDown("space") && stickInLeftHand)
        {
            Debug.Log("Attack (left hand)");
            //left hand attack
        }

        if (currentTime <= 0 && justAtttacked == true)
        {
            rightHand.GetComponent<Animator>().Play("Default");
            justAtttacked = false;
            currentTime = cooldownTimer;            
        }
    }
}
