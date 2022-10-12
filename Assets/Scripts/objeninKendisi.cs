using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeninKendisi : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {

            gameObject.SetActive(false);
        }
    }

}
