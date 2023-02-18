using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public bool hit = false;
    public Parent parent;
    public Texture2D cursor_normal;
    public UIManager manager;
    public ParticleSystem hitEffect;
    public ParticleSystem missEffect;
    public AudioSource source;



    private void Start()
    {
       

        
    }
    void Update()
    {

        if (this.tag == parent.objectNum.ToString() && transform.position.y <= -1.922f && !hit && manager.currentTime != 0)
        {
            
            transform.Translate(Vector3.up * Time.deltaTime * parent.speed);
        }
        else if(this.tag == parent.objectNum.ToString() && !hit && manager.currentTime != 0)
        {
            transform.position = new Vector3(transform.position.x, -1.922f,transform.position.z);
        }
        else if(transform.position.y >= -2.88 )
        {
            
            transform.Translate(Vector3.down * Time.deltaTime * parent.speed);
        }
        else
        {
            
            transform.position = new Vector3(transform.position.x, -2.88f, transform.position.z);
            hit = false;
        }
       

    }

    private void OnMouseDown()
    {
        
        if(this.tag == parent.objectNum.ToString() )
        {
            
            if (parent.gameon && manager.currentTime != 0)
            {
                source.Play();
                hit = true;
                manager.score += 2;
                hitEffect.Play();
                parent.timer = 0;
                parent.ObjectNumber();
            }
            
        }
        else
        {
            if (parent.gameon && manager.currentTime != 0)
            {
                
                missEffect.Play();
                if(manager.score != 0)
                {

                manager.score -= 1;
                }
            }
            
        }
    }

    

    
    


}
