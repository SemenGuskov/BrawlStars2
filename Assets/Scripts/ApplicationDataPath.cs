using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationDataPath : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Persistent Data Path: " + Application.persistentDataPath);
    }
}
