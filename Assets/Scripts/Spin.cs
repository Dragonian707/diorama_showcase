using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    float spinSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f, spinSpeed, 0f, Space.Self);

        if (this.transform.rotation.y >= 0.125f * Mathf.PI || this.transform.rotation.y <= -0.125f * Mathf.PI)
        {
            spinSpeed *= -1f;
        }
    }
}
