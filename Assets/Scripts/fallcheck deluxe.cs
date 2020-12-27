using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class fallcheck2: MonoBehaviour
{

    Vector3 pos;
    public Image white;
    public Animator anim;
    public float isded;

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        gameObject.transform.position = pos;

        if(pos.y < -13){
            isded += 1;
        }
          
        if(isded == 1){
           StartCoroutine(Fading());
           
        }
        
    }

    IEnumerator Fading(){
    anim.SetBool("fade",true);
    yield return new WaitUntil(()=>white.color.a==1);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
