using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chargementscene : MonoBehaviour
{
    public Animator canvas;

    public void onPress1(){
        StartCoroutine("chargerNiveau1");
    }

    public void onPress2(){
        StartCoroutine("chargerNiveau2");
    }

    IEnumerator chargerNiveau1(){

    canvas.SetTrigger("debut");
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene(1);
    yield break;
}

IEnumerator chargerNiveau2(){

    canvas.SetTrigger("debut");
    yield return new WaitForSeconds(1f);
    SceneManager.LoadScene(0);
    yield break;
}

}
