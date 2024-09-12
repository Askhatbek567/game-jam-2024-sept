using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeAbilityButton : MonoBehaviour
{
    public Image image;
    public Sprite CircleSprite;
    public Sprite SquareSprite;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Type", 0);
        image.sprite = CircleSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonDown()
    {
        int currentType = PlayerPrefs.GetInt("Type");

        if(currentType == 0)
        {
            PlayerPrefs.SetInt("Type", 4);
            image.sprite = SquareSprite;

        }
        else
        {
            PlayerPrefs.SetInt("Type", 0);
            image.sprite = CircleSprite;
        }
        PlayerPrefs.Save();

    }
}
