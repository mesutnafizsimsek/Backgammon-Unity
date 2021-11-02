using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulSayaci : MonoBehaviour
{
    public int pulsayisi;
    public string pulRengi;
    public int siraNumarasi;
    int doluPulSayisi = -1;

    GameObject beyazPul;
    GameObject siyahPul;

    bool isFirstStart = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }



    public void PulYarat()
    {
        beyazPul = GameObject.FindGameObjectWithTag("beyazpul");
        siyahPul = GameObject.FindGameObjectWithTag("siyahpul");

        doluPulSayisi += pulsayisi;
        if (pulRengi.Equals("beyaz"))
        {
            Debug.Log("beyaz giriş");
            for (int i = 0; i <= doluPulSayisi; i++)
            {
                Debug.Log("Yaratildi");
                GameObject yer = transform.GetChild(i).gameObject;
                Instantiate(beyazPul, yer.transform.position, Quaternion.identity);
                
            }

        }


        if (pulRengi.Equals("siyah"))
        {
            Debug.Log("siyah giriş");
            for (int i = 0; i <= doluPulSayisi; i++)
            {
                Debug.Log("Yaratildi");
                GameObject yer = transform.GetChild(i).gameObject;
                Instantiate(siyahPul, yer.transform.position, Quaternion.identity);
                
            }

        }
    }
   
}
