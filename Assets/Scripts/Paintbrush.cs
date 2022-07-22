using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintbrush : MonoBehaviour
{
    [SerializeField] private ParticleSystem Paintsplash;
    [SerializeField] private Animator anim;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // Plays bucket slosh animation, waits .05 seconds, and then plays the particles
            StartCoroutine(Splash());
        }
    }

    IEnumerator Splash()
    {
        anim.SetTrigger("Slosh");
        yield return new WaitForSeconds(.15f);
        Paintsplash.Play();
    }
}
