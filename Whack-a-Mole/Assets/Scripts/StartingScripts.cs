using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScripts : MonoBehaviour
{
    public Animator anim;
    public Parent parent;
    public GameObject canvas;
    

    private void OnMouseDown()
    {
        if(tag == "Start" && parent.rules == false)
        {
            parent.start = true;
            anim.SetTrigger("Start");
        }
        if(tag == "Rules" && parent.start == false && parent.rules == false)
        {
            parent.rules = true;
            canvas.SetActive(true);
        }
        
        
    }

    public void OnButtonPress()
    {             
            parent.rules = false;
            canvas.SetActive(false);

    }
    
}
