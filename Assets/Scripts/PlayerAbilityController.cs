using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerAbilityController : MonoBehaviour
{
    public AbilityExecuter executing;
    public AbilityCaller caller;
    public TMP_Text Message;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(executing.ability != null)
            {
                executing.ExecuteQAbility();
            }
            else
            {
                Message.text = "There is no such ability";
                return;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (executing.ability != null)
            {
                executing.ExecuteEAbility();
            }
            else
            {
                Message.text = "There is no such ability";
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (executing.ability != null)
            {
                executing.ExecuteFAbility();
            }
            else
            {
                Message.text = "There is no such ability";
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (executing.ability != null)
            {
                executing.ExecuteCAbility();
            }
            else
            {
                Message.text = "There is no such ability";
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (executing.ability != null)
            {
                executing.ExecuteXAbility();
            }
            else
            {
                Message.text = "There is no such ability";
                return;
            }
        }
    }
}
