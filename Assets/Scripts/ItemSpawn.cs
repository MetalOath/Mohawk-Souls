using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.RotateAround(Vector3.up, 1f * Time.deltaTime);
    }
}
