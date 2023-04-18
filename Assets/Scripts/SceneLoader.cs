using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string Query = "sceneID=1&1234=QWER"; //Application.absoluteURL.Split('?')[1];

/*#if UNITY_WEBGL
        Query = Application.absoluteURL.Split('?')[1];
#endif*/


        string[] Values = Query.Split('&');
        string[] val1 = Values[0].Split('=');
        string[] val2 = Values[1].Split('=');
        string UniqueKey = val2[1];

        int sceneID = 0;

        try { sceneID = Int32.Parse(val1[1]); }
        catch { Debug.Log("not an int");}
        

        switch (sceneID) 
        {
            case 1:
                {
                    SceneManager.LoadScene("Diorama_Chris");
                    break;
                }
            case 2:
                {
                    SceneManager.LoadScene("Diorama_Chris_2");
                    break;
                }
            case 3: 
                {
                    SceneManager.LoadScene("Diorama_Verena");
                    break;
                }
            case 4:
                { 
                    SceneManager.LoadScene("Diorama_Verena_2");
                    break;
                }
            case 5:
                {
                    SceneManager.LoadScene("Diorama_hellen");
                    break;
                }
            case 6: 
                {
                    SceneManager.LoadScene("Diorama_Jeppe");
                    break;
                }
            default:
                Debug.Log("No scene found " + val1[1]);
                break;
        
        }
        int x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
