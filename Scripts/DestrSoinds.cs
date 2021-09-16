using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrSoinds : MonoBehaviour
{
    public static DestrSoinds instance;

    AudioSource destr;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        destr = GetComponent<AudioSource>();
    }

 public void ExploseSound()
    {
        destr.Play();
    }
}
