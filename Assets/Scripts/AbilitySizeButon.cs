using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySizeButon : MonoBehaviour
{

    public TMP_InputField Radius;
    public TMP_InputField Width;
    public TMP_Text Message;
    public TMP_Text firstHeader;
    public TMP_Text secondHeader;
    public float maxRadius;
    public float minRadius;
    public float maxWidth;
    public float minWidth;

    void Start()
    {
    }

    public void ButtonDown()
    {
        float radius = 0;
        float width = 0;
        if (!float.TryParse(Radius.text, out radius))
        {
            Message.text = $"{secondHeader.text} must be a float";
            return;
        }
        if(!float.TryParse(Width.text, out width))
        {
            Message.text = $"{firstHeader.text} must be an float";
            return;
        }    
        if(radius < minRadius || radius > maxRadius)
        {
            Message.text = $"{secondHeader.text} must be between {minRadius} and {maxRadius}";
            return;
        }
        if(width < minWidth || width > maxWidth)
        {
            Message.text = $"{firstHeader.text} must be between {minWidth} and {maxWidth}";
            return;
        }
        Message.text = ""; 
        
        PlayerPrefs.SetFloat("Radius", radius);
        PlayerPrefs.SetFloat("Width", width);
        PlayerPrefs.Save();

    }
}
