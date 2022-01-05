using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crates : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Crate);
    }
}
