using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulYerleri : MonoBehaviour
{

    GameObject pulSiralari;
    static int childCount;


    public GameObject beyazPul;
    public GameObject siyahPul;


    GameObject zarYeri0;
    GameObject zarYeri1;
    GameObject zarYeri2;
    GameObject zarYeri3;
    GameObject zarYeri4;
    GameObject zarYeri5;
    GameObject zarYeri6;
    GameObject zarYeri7;
    GameObject zarYeri8;
    GameObject zarYeri9;
    GameObject zarYeri10;
    GameObject zarYeri11;
    GameObject zarYeri12;
    GameObject zarYeri13;
    GameObject zarYeri14;
    GameObject zarYeri15;
    GameObject zarYeri16;
    GameObject zarYeri17;
    GameObject zarYeri18;
    GameObject zarYeri19;
    GameObject zarYeri20;
    GameObject zarYeri21;
    GameObject zarYeri22;
    GameObject zarYeri23;


    void Start()
    {

        zarYeri0 = transform.GetChild(0).gameObject;
        zarYeri1 = transform.GetChild(1).gameObject;
        zarYeri2 = transform.GetChild(2).gameObject;
        zarYeri3 = transform.GetChild(3).gameObject;
        zarYeri4 = transform.GetChild(4).gameObject;
        zarYeri5 = transform.GetChild(5).gameObject;
        zarYeri6 = transform.GetChild(6).gameObject;
        zarYeri7 = transform.GetChild(7).gameObject;
        zarYeri8 = transform.GetChild(8).gameObject;
        zarYeri9 = transform.GetChild(9).gameObject;
        zarYeri10 = transform.GetChild(10).gameObject;
        zarYeri11 = transform.GetChild(11).gameObject;
        zarYeri12 = transform.GetChild(12).gameObject;
        zarYeri13 = transform.GetChild(13).gameObject;
        zarYeri14 = transform.GetChild(14).gameObject;
        zarYeri15 = transform.GetChild(15).gameObject;
        zarYeri16 = transform.GetChild(16).gameObject;
        zarYeri17 = transform.GetChild(17).gameObject;
        zarYeri18 = transform.GetChild(18).gameObject;
        zarYeri19 = transform.GetChild(19).gameObject;
        zarYeri20 = transform.GetChild(20).gameObject;
        zarYeri21 = transform.GetChild(21).gameObject;
        zarYeri22 = transform.GetChild(22).gameObject;
        zarYeri23 = transform.GetChild(23).gameObject;


        childCount = transform.GetChild(0).childCount;
        //Debug.Log(childCount);




        pulEkle(0, "beyaz",2);
        pulEkle(11, "beyaz",5);
        pulEkle(17, "beyaz",3);
        pulEkle(18, "beyaz",5);


        pulEkle(5, "siyah", 5);
        pulEkle(6, "siyah", 3);
        pulEkle(12, "siyah", 5);
        pulEkle(23, "siyah", 2);




        /*
        for (int i = 0; i <= childCount; i++) {

            pulSiralari = transform.GetChild(i).transform.GetChild(0).gameObject;

            Instantiate(beyazPul, yerler[i].transform.position,Quaternion.identity);
        }*/

    }



    void pulEkle(int pulyeriNumarasi, string pulRengi,int pulsayisi)
    {
        GameObject a = transform.GetChild(pulyeriNumarasi).gameObject;
        a.transform.GetChild(0).gameObject.GetComponent<pulSayaci>().pulRengi = pulRengi;
        a.transform.GetChild(0).gameObject.GetComponent<pulSayaci>().pulsayisi = pulsayisi;
        a.transform.GetChild(0).gameObject.GetComponent<pulSayaci>().PulYarat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
