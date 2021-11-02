using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dicerotation : MonoBehaviour
{

    Rigidbody rb;
    Vector3 speed;
    public float xAngle, yAngle, zAngle;


    bool onGround;
    bool diceWasRotated;
   
    public int zarValue;
    
    private void Start()
    {

        rb = transform.gameObject.GetComponent<Rigidbody>();
        onGround = false;
        diceWasRotated = false;

    }
    void Awake()
    {
      
    }

    void Update()
    {
       
        

        if (Input.GetKeyDown(KeyCode.Space)) {

            if (!onGround)
            {

                RollDice();
            }
        
        }
        //Debug.Log(zarValue);
    }

    public void RollDice()
    {
       
        rb.AddTorque(Random.Range(30, 500), Random.Range(30, 500), Random.Range(30, 500));


    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "yer")
        {
            onGround = true;
            //Debug.Log("Yerde");
        }
        
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.tag == "yer")
        {
            onGround = false;
            //Debug.Log("Yerde Değil");
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        
    }




}
