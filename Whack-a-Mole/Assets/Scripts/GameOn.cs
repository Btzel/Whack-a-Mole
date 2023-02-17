using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameOn : MonoBehaviour
{
    public Parent parent;
    bool gameon = false;
    public float TimeLeft;
    public Text TimerTxt;
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(parent.start && !gameon)
        {
            StartCoroutine(Game());
        }


    }

    IEnumerator Game()
    {
        gameon = true;
        Debug.Log("Start");
        yield return new WaitForSeconds(4);
        parent.anim.enabled = false;
        
    }

    void Motion()
    {
        
        
    }

    


}
