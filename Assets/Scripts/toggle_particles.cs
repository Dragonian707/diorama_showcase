//To use this script place it into a particleSystem
//You will also need a canvas and a button
//(available under UI when right-clicking in
//the inspector)
//In the button drag the particleSystem into the
//button component and select 'ToggleParticles'
//in 'toggle_particles'

using UnityEngine;

public class toggle_particles : MonoBehaviour
{
    ParticleSystem PS;
    bool systemActive;
    // Start is called before the first frame update
    void Start()
    {
        PS = GetComponent<ParticleSystem>();
        systemActive = true;
    }

    public void ToggleParticles()
    {
        if (systemActive)
        {
            PS.Stop();
            systemActive = false;
        }
        else
        {
            PS.Play();
            systemActive = true;
        }
    }
}
