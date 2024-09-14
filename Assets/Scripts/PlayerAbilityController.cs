using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace Player;
public class PlayerAbilityController : MonoBehaviour
{
	public List<AbilityCaller> abilities;
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
			if(abilities.Count > 0)
			{
				abilities[0].executer.Execute();
			}
			else
			{
				Message.text = "There is no such ability";
				return;
			}
		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			if(abilities.Count > 1)
			{
				abilities[1].executer.Execute();
			}
			else
			{
				Message.text = "There is no such ability";
				return;
			}
		}
		if (Input.GetKeyDown(KeyCode.F))
		{
			if(abilities.Count > 2)
			{
				abilities[2].executer.Execute();
			}
			else
			{
				Message.text = "There is no such ability";
				return;
			}
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			if(abilities.Count > 3)
			{
				abilities[3].executer.Execute();
			}
			else
			{
				Message.text = "There is no such ability";
				return;
			}
		}
		if (Input.GetKeyDown(KeyCode.X))
		{
			if(abilities.Count > 4)
			{
				abilities[4].executer.Execute();
			}
			else
			{
				Message.text = "There is no such ability";
				return;
			}
		}
	}
}
