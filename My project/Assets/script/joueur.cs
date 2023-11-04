using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class joueur : MonoBehaviour
{
    public int count;

    
private void OnTriggerEnter(Collider other){


}

private void OnTriggerExit(Collider other){
    if(other.tag == "livre")
    {
        other.gameObject.SetActive(false);
        count ++;
    }



}



}
