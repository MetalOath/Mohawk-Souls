using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipItem : MonoBehaviour
{
    public GameObject helmetObject;
    public GameObject shieldObject;
    public GameObject swordObject;

    public bool helmet = false;
    public bool shield = false;
    public bool sword = false;

    private void Start()
    {
        if (helmet == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (shield == true)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        if (sword == true)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Paladin")
        {
            if (helmet == true)
            {
                helmetObject.SetActive(true);
            }
            if (shield == true)
            {
                shieldObject.SetActive(true);
            }
            if (sword == true)
            {
                swordObject.SetActive(true);
            }
            Destroy(transform.parent.gameObject);
        }
    }
}
