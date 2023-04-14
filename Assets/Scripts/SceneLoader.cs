using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string Query = "diam=cool&1234=QWER"; //Application.absoluteURL.Split('?')[1];
        string[] Values = Query.Split('&');
        string[] val1 = Values[0].Split('=');
        string[] val2 = Values[1].Split('=');
        SceneManager.LoadScene(val1[1]);
        string UniqueKey = val2[1];
        int x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
