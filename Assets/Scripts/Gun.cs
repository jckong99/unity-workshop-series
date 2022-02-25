using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
