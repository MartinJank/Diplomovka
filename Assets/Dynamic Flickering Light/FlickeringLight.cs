using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FlickeringLight : MonoBehaviour
{
    // public Transform flickerLight;
    public UnityEngine.Rendering.Universal.Light2D flickerLightComponent;


    // Start is called before the first frame update
    void Start()
    {
        // flickerLight = this.transform.GetChild(1);
        // flickerLightComponent = flickerLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>();

        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        while (true)
        {
            float randomIntensity = Random.Range(0.0f, 1.2f);
            flickerLightComponent.intensity = randomIntensity;


            float randomTime = Random.Range(0.2f, 1.0f);
            yield return new WaitForSeconds(randomTime);
        }
    }
}