using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private void Awake() // Runs before void Start()
    {
        DontDestroyOnLoad(this.gameObject); // Don't destroy this gameObject when loading different scenes

    }
}
