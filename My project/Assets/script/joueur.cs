using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class joueur : MonoBehaviour
{
    public int count;
    public GameObject skydefault;
    public GameObject skyville;

    
private void OnTriggerEnter(Collider other){
        if (other.tag == "ville")
        {
            skyville.SetActive(true);
            skydefault.SetActive(false);
        }

    }

private void OnTriggerExit(Collider other){
    if(other.tag == "livre")
    {
        other.gameObject.SetActive(false);
        count ++;
    }else if (other.tag == "ville")
        {
            skyville.SetActive(false);
            skydefault.SetActive(true);
        }



    }



}
