using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class coins : MonoBehaviour
{
    public bool isCoins, isSpeed;
    public int speeddur;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            plaer pc = other.GetComponent<plaer>();

            if (isSpeed)
            {
                sppedcoins spee = other.GetComponent<sppedcoins>();
                if (spee != null)
                {
                    spee.ActivaSpeed(pc, speeddur);
                }
            }
            if (isCoins)
            {
                pc.score++;
                Destroy(gameObject);
            }
        }
    }
}