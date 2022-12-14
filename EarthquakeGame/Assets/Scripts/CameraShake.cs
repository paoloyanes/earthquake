using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public AudioSource earthquakeSound; // added by eljan
    public static bool shaking = false;
    public IEnumerator Shake(float duration, float magnitude)
    

    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        earthquakeSound.Play();

        while (elapsed < duration)
        {
            shaking = true;
            float x = Random.Range(-1f, 1f) * magnitude;
            //float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, originalPos.y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        shaking = false;
        earthquakeSound.Stop();

        transform.localPosition = originalPos;
    }
}
