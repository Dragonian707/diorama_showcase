using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Toggle_Item : MonoBehaviour
{
    protected bool active;
    public string buttonText;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        ToggleManager.Instance.RegisterItem(this);
    }

    public abstract void Toggle();
}
