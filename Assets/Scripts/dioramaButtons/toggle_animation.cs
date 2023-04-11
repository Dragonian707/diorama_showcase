using UnityEngine;

class toggle_animation : Toggle_Item
{
    Animator anim;
    // Start is called before the first frame update
    protected override void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        active = true;
        buttonText = "toggle animation";
        base.Start();
    }

    public override void Toggle()
    {
        if (active)
        {
            active = false;
            anim.SetBool(gameObject.name, true);
        }
        else
        {
            active = true;
            anim.SetBool(gameObject.name, false);
        }
    }
}
