using UnityEngine;

class toggle_particles : Toggle_Item
{
    ParticleSystem PS;

    // Start is called before the first frame update
    protected override void Start()
    {
        PS = GetComponent<ParticleSystem>();
        active = true;
        buttonText = "toggle particles";
        base.Start();
    }

    public override void Toggle()
    {

        if (active)
        {
            PS.Stop();
            active = false;
        }
        else
        {
            PS.Play();
            active = true;
        }
    }
}
