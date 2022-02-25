using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    [SerializeField] private float seconds;

    void Start()
    {
        Destroy(gameObject, seconds);
    }
}
