using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dicesides : MonoBehaviour
{
    public Text zar1Text;
  
    public int diceVal;

    public int sendedVal; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Awake()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "yer")
        {
            zar1Text.text = diceVal   + "";

            sendedVal = diceVal;


            transform.GetComponentInParent<dicerotation>().zarValue = sendedVal;
        }
    }


    
}
