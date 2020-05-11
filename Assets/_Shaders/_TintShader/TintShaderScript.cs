using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintShaderScript : MonoBehaviour
{

    [SerializeField]
    private Material _tintShaderMaterial;
    [SerializeField]
    private float _tintSpeed=6f;
    [SerializeField]
    private Color _materialColor;


    private Color _tempColor;
    private bool _isTinting=true;


    private void Awake()
    {
        //  _materialColor = new Color(1, 0, 0, 0);
        _tempColor = _materialColor;
       
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _isTinting = true;
        }

        if (_isTinting)
        {
            if (_tempColor.a > 0)
            {
                _tempColor.a = Mathf.Clamp01(_tempColor.a - _tintSpeed * Time.deltaTime);
                _tintShaderMaterial.SetColor("_Tint", _tempColor);
            }
            else
            {
                _isTinting = false;
                _tempColor = _materialColor;
            }


        }

        
    }

    



}
