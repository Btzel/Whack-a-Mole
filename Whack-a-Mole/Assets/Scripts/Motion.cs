using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public bool hit = false;
    public Parent parent;
    public Texture2D cursor_normal;

    private void Start()
    {
        Cursor.SetCursor(cursor_normal, new Vector2(40,40), CursorMode.ForceSoftware);
    }
    void Update()
    {

        if (this.tag == parent.objectNum.ToString() && transform.position.y <= -1.922f && !hit)
        {
            transform.Translate(Vector3.up * Time.deltaTime * parent.speed);
        }
        else if(this.tag == parent.objectNum.ToString() && !hit)
        {
            transform.position = new Vector3(transform.position.x, -1.922f,transform.position.z);
        }
        else if(transform.position.y >= -2.88)
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
        
        if(this.tag == parent.objectNum.ToString())
        {
           
            hit = true;
            parent.timer = 0;
            parent.ObjectNumber();
        }
    }

    

    
    


}
