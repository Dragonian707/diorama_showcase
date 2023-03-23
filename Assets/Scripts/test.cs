using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    // Gyroscope gyro;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.acceleration);
        if (SystemInfo.supportsGyroscope)
        {
            text.text = Input.gyro.attitude.ToString();
            this.transform.rotation = Input.gyro.attitude;
        }
        else
        {
            text.text = "No gyroscope";
        }
    }
}
