using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyaudio : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
