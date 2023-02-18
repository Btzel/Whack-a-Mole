using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public bool start = false;
    public bool rules = false;
    public Animator anim;
    public GameObject[] gameObjects;
    public GameObject Hammer;
    public bool gameon = false;
   
    public int objectNum = -1;
    public float timer = 0;
    float timeSet = 0.5f;
    public float speed;
    public UIManager manager;
    public GameObject canvasenab;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start && !gameon)
        {
            StartCoroutine(Game());
        }
        timer += Time.deltaTime;
        if (timer > timeSet && gameon)
        {
            timer = 0;
            ObjectNumber();
            
        }
        
    }

    IEnumerator Game()

    { 
        yield return new WaitForSeconds(2.5f);
        canvasenab.SetActive(true);
        
        yield return new WaitForSeconds(1f);
        gameon = true;
        manager.timerStarted = true;
        
        yield return new WaitForSeconds(0.5f);
        anim.enabled = false;
        
        timer = 0f;
        
    }
    public int ObjectNumber()
    {
        objectNum = Random.Range(0, 9);
        return objectNum;
    }
}
