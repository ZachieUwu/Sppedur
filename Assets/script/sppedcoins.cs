using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sppedcoins : MonoBehaviour
{
    private Coroutine speedo;

    public void ActivaSpeed(plaer pc, int duration)
    {
        if (speedo != null)
        {
            StopCoroutine(speedo);
        }
        speedo = StartCoroutine(speedBoo(pc, duration));
    }

    private IEnumerator speedBoo(plaer pc, int duration)
    {
        float originalSpeed = pc.speed;
        pc.speed *= 1.5f;

        yield return new WaitForSeconds(duration);

        pc.speed = originalSpeed;
        speedo = null;
    }
}
