using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject kaynakNoktasi;
    public GameObject[] olusacakNesne;
    int sirano = 0;
    void Start()
    {
        StartCoroutine(objeOlustur());
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

    IEnumerator objeOlustur()
    {
        while (true)
        {

            if(sirano <= 8)
            {
                olusacakNesne[sirano].SetActive(true);
                olusacakNesne[sirano].transform.position = kaynakNoktasi.transform.position;

            }
            else
            {

                sirano = 0;
                olusacakNesne[sirano].SetActive(true);
                olusacakNesne[sirano].transform.position = kaynakNoktasi.transform.position;
            }
            

            sirano++;
            yield return new WaitForSecondsRealtime(.5f);

        }

    }
}
