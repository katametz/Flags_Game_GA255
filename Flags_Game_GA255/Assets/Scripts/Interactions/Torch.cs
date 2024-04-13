using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public Light torchLight;

    private float currentTimer = 0f;
    public float torchEnableTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        torchLight.gameObject.SetActive(true);
        StartCoroutine(DisableTorchAfterTime());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && torchLight.gameObject.activeSelf == false)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer >= torchEnableTime)
            {
                torchLight.gameObject.SetActive(true);
                StartCoroutine(DisableTorchAfterTime());
                currentTimer = 0f;
            }
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            currentTimer = 0f;
        }
    }

    IEnumerator DisableTorchAfterTime()
    {
        yield return new WaitForSeconds(30f);
        torchLight.gameObject.SetActive(false);
    }
}