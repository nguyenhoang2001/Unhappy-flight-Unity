using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip Click;
    public AudioClip Scream;
    public AudioClip Crate;

    public static SFXManager sfxInstance;

    void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);
    }
}
