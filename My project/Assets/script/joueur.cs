using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using TMPro;



public class joueur : MonoBehaviour
{
    public int count;
    public int countburger;
    public GameObject skydefault;
    public GameObject skyville;
    public GameObject skydesert;
    public GameObject skyespace;
    public GameObject skyantartique;
    public GameObject skysousleau;
    public GameObject montagnedesert;
    public GameObject audiodefault;
    public GameObject audioville;
    public GameObject audiodesert;
    public GameObject audioespace;
    public GameObject audioantartique;
    public GameObject audiosousleau;

    float m_FieldOfView;
    jump joump;
    public GameObject Joueur;

    public TextMeshProUGUI pointage;


    

    
private void OnTriggerEnter(Collider other){
        if (other.tag == "ville")
        {
            skyville.SetActive(true);
            skydefault.SetActive(false);
            skydesert.SetActive(false);
            skyespace.SetActive(false);
            skyantartique.SetActive(false);
            skysousleau.SetActive(false);
            audioville.SetActive(true);
            audiodefault.SetActive(false);
            
        
        }else if (other.tag == "desert")
        {
            skydesert.SetActive(true);
            skydefault.SetActive(false);
            skyville.SetActive(false);
            skyespace.SetActive(false);
            skyantartique.SetActive(false);
            skysousleau.SetActive(false);
            audiodesert.SetActive(true);
            audiodefault.SetActive(false);
            //Camera champ de vision rétréci
            Camera.main.fieldOfView = 30.0f;
        }else if (other.tag == "espace")
        {
            skyespace.SetActive(true);
            skydefault.SetActive(false);
            skyville.SetActive(false);
            skydesert.SetActive(false);
            skyantartique.SetActive(false);
            skysousleau.SetActive(false);
            audioespace.SetActive(true);
            audiodefault.SetActive(false);
        }else if (other.tag == "antartique")
        {
            skyantartique.SetActive(true);
            skydefault.SetActive(false);
            skyville.SetActive(false);
            skydesert.SetActive(false);
            skyespace.SetActive(false);
            skysousleau.SetActive(false);
            audioantartique.SetActive(true);
            audiodefault.SetActive(false);
        }else if (other.tag == "eau")
        {
            skysousleau.SetActive(true);
            skydefault.SetActive(false);
            skyville.SetActive(false);
            skydesert.SetActive(false);
            skyespace.SetActive(false);
            skyantartique.SetActive(false);
            audiosousleau.SetActive(true);
            audiodefault.SetActive(false);
        }

    }

private void OnTriggerExit(Collider other){
    if(other.tag == "livre")
    {
        other.gameObject.SetActive(false);
        count ++;
        pointage.text = count.ToString();
    }else if (other.tag == "burger")
        {
            other.gameObject.SetActive(false);
            countburger ++;
            if (countburger == 4)
        {
            montagnedesert.SetActive(false);
            
            

        }}else if (other.tag == "ville")
        {
            skyville.SetActive(false);
            skydefault.SetActive(true);
            audioville.SetActive(false);
            audiodefault.SetActive(true);

            

        }else if (other.tag == "desert")
        {
            skydesert.SetActive(false);
            skydefault.SetActive(true);
            audiodesert.SetActive(false);
            audiodefault.SetActive(true);
            Camera.main.fieldOfView = 60.0f;
        }else if (other.tag == "espace")
        {
            skyespace.SetActive(false);
            skydefault.SetActive(true);
            audioespace.SetActive(false);
            audiodefault.SetActive(true);
        }else if (other.tag == "antartique")
        {
            skyantartique.SetActive(false);
            skydefault.SetActive(true);
            audioantartique.SetActive(false);
            audiodefault.SetActive(true);
        }else if (other.tag == "eau")
        {
            skysousleau.SetActive(false);
            skydefault.SetActive(true);
            audiosousleau.SetActive(false);
            audiodefault.SetActive(true);
        }



    }



}
