using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDT_Script : MonoBehaviour
{
    #region Some extra code
    public GameObject pressPlayWindow;

    private void Start()
    {
        //DEACTIVATE THE WINDOW ON START

        pressPlayWindow.SetActive(false);

        /*TO SEE MORE INFO ABOUT THIS CHECK THESE VIDEOS
        
        ACTIVATE AND DEACTIVATE GAMEOBJECTS IN UNITY:
        https://www.youtube.com/watch?v=ddSHCwnksW0

        HOW TO KNOW IF A GAMEOBJECT IS ACTIVE IN HIERARCHY:
        https://www.youtube.com/watch?v=jsl-0Z5dT_w

        */
    }
    public void MysteriousFunction(string s)
    {
        #region don't
        //Subscribe :)
        Application.OpenURL(s);
        #endregion
    }
    #endregion
}
