using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;



public class joueur : MonoBehaviour
{
    public int count;
    public GameObject skydefault;
    public GameObject skyville;
    public GameObject skydesert;
    public GameObject skyespace;
    public GameObject skyantartique;
    public GameObject skysousleau;
    float m_FieldOfView;
    jump joump;
    public GameObject Joueur;


    

    
private void OnTriggerEnter(Collider other){
        if (other.tag == "ville")
        {
            skyville.SetActive(true);
            skydefault.SetActive(false);
            
        
        }else if (other.tag == "desert")
        {
            skydesert.SetActive(true);
            skydefault.SetActive(false);
            //Camera champ de vision rétréci
            Camera.main.fieldOfView = 30.0f;
        }else if (other.tag == "espace")
        {
            skyespace.SetActive(true);
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
            //Arrete Shake la camera
            

        }else if (other.tag == "desert")
        {
            skydesert.SetActive(false);
            skydefault.SetActive(true);
            Camera.main.fieldOfView = 60.0f;
        }else if (other.tag == "espace")
        {
            skyespace.SetActive(false);
            skydefault.SetActive(true);
        }



    }



}
