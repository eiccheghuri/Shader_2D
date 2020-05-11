using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public Material _robotMaterial;
    public Material _zombiMaterial;

    private float _fadeValue=1f;
    private bool _isDissolving = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isDissolving = true;
        }

        if (_isDissolving)
        {
            _fadeValue = _fadeValue - Time.deltaTime;
            if (_fadeValue<=0)
            {
                _fadeValue = 1;
                _isDissolving = false;
            }
            _robotMaterial.SetFloat("_Fade", _fadeValue);
            _zombiMaterial.SetFloat("_Fade", _fadeValue);

        }
    }



}
