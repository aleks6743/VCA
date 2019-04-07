using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private SpriteRenderer _renderer;
    public Color AddColorWithEnter;
    private Color _currentAddedColor;
    private Color _clearColor = new Color(1, 1, 1, 1);
    private bool _isClear;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _currentAddedColor = _clearColor;
               
    }
    private void FixedUpdate()
    {
        if (_isClear)
        {
            _currentAddedColor = Color.Lerp(_currentAddedColor, _clearColor, Time.deltaTime);
        }
        _renderer.color = _currentAddedColor;
    }
           
    
    // Update is called once per frame
    public void OnClick()
    {
        Debug.Log("Click"); 
    }
    public void OnEnter()
    {
        _currentAddedColor = AddColorWithEnter;
        _isClear = false;
     }

    public void OnExit()
    {
    _isClear = true;
    }
    
}
