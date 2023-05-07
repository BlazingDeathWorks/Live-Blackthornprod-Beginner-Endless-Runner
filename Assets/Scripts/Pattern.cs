using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{
    [SerializeField] private float destroyTime;

    void Update()
    {
        Destroy(gameObject, destroyTime);
    }
}
