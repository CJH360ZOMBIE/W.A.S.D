using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    float ReadyForNextShot;
    public float FireRate;
    private bool ThrowIsPlaying;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            if(Time.time > ReadyForNextShot)
            {
                
                ReadyForNextShot = Time.time + 1/FireRate;
                animator.SetBool("Throw",true);

            } 
        }
    }
}

