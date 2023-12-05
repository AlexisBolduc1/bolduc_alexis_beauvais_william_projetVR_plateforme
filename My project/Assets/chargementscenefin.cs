using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class chargementscenefin : MonoBehaviour
{
    public Animator canvas;

    public void onPress()
    {
        StartCoroutine("chargerNiveau");
    }

    IEnumerator chargerNiveau()
    {

        canvas.SetTrigger("debut");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
        yield break;
    }

}
