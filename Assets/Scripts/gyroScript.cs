using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gyroScript : MonoBehaviour
{
    Gyroscope gyro;
    Compass compass;
    Quaternion originRot;
    // Start is called before the first frame update
    void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;

        originRot = this.gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Quaternion newRot = new Quaternion(-gyro.attitude.y, -gyro.attitude.z, gyro.attitude.x, -gyro.attitude.w);
            this.gameObject.transform.rotation = newRot * originRot;
        }
        else
        {
            Debug.Log("no gyroscope");
        }
    }
}
