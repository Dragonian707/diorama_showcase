using UnityEngine;

class toggle_light : Toggle_Item
{
    Light light;

    // Start is called before the first frame update
    protected override void Start()
    {
        light = GetComponent<Light>();
        buttonText = "toggle light";
        base.Start();
    }

    public override void Toggle()
    {

        light.enabled = !light.enabled;
        // active = false;
    }
}
