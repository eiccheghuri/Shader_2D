using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurScript : MonoBehaviour
{
    [Header("Put shader material here")]
    public Material blurMaterial;
    public float blurAmount=0f;

    private bool _isBlurActive = false;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isBlurActive = !_isBlurActive;
            
        }

        float blurSpeed = 5f;

        if (_isBlurActive)
        {
            blurAmount += blurSpeed * Time.deltaTime;
            
        }
        else
        {
            blurAmount -= blurSpeed * Time.deltaTime;
        }

        blurAmount = Mathf.Clamp(blurAmount, 0f, 5f);
        blurMaterial.SetFloat("_BlurAmount", blurAmount);

    }



}
