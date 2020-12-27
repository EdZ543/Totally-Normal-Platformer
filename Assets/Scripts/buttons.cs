using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class buttons : MonoBehaviour
{

    public Image white;
    public Animator anim;
    
    public void play(){

        StartCoroutine(fadetoplay());
        

    }

    public void instructions(){

        StartCoroutine(fadetoinstructions());
        

    }

    public void bakbak(){

        StartCoroutine(back());
        

    }

    IEnumerator fadetoplay(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadScene("level 1");
    }

    IEnumerator fadetoinstructions(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadScene("instructions");
    }

    IEnumerator back(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadScene("home");
    }

}
