using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScript : MonoBehaviour
{
    public static BgScript BgInstane;

    void Awake()
    {
        if (BgInstane != null && BgInstane != this)
        {
            Destroy(this.gameObject);
        }

        BgInstane = this;
        DontDestroyOnLoad(this);
    }
}
