using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    new Camera camera;
    float oriFOV;
    // Start is called before the first frame update
    void Start()
    {
        camera = FindObjectOfType<Camera>();
         oriFOV = camera.fieldOfView;
    }

    public void ZoomIn()
    {
        camera.fieldOfView -= 5;
    }
    public void ZoomOut()
    {
        camera.fieldOfView += 5;
    }
    public void ResetZoom()
    {
        camera.fieldOfView = oriFOV;
    }
}
