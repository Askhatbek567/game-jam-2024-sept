using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class PlayerAbilityController : MonoBehaviour
{
	public List<AbilityCaller> abilities;
	public PlayerState player;
	public TMP_Text Message;
	// Start is called before the first frame update
	void Start()
	{
	   
	}

	// Update is called once per frame
	void Update()
	{
		AbilityCaller abil = null;
		if (Input.GetKeyDown(KeyCode.Q))
		{
			if(abilities.Count > 0)
			{
				abil = abilities[0];
			}
			else
			{
				Message.text = "There is no such ability";
			}
		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			if(abilities.Count > 1)
			{
				abil= abilities[1];
			}
			else
			{
				Message.text = "There is no such ability";
			}
		}
		if (Input.GetKeyDown(KeyCode.F))
		{
			if(abilities.Count > 2)
			{
				abil = abilities[2];
			}
			else
			{
				Message.text = "There is no such ability";
			}
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			if(abilities.Count > 3)
			{
				abil= abilities[3];
			}
			else
			{
				Message.text = "There is no such ability";
			}
		}
		if (Input.GetKeyDown(KeyCode.X))
		{
			if(abilities.Count > 4)
			{
				abil= abilities[4];
			}
			else
			{
				Message.text = "There is no such ability";
			}
		}
		if(abil == null)
			return;
		if(abil.type == AbilityType.Player)
		{
			player.executers.Append(abil.executer);
			switch(abil.executer.ability.effect.variablInitial)
			{
				case Variable.HP:
					player.HP -= abil.executer.ability.effect.valueInitial;
					break;
				case Variable.PosX:
					player.transform.position = new Vector2(player.transform.position.x - abil.executer.ability.effect.valueInitial, player.transform.position.y);
					break;
				case Variable.PosY:
					player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - abil.executer.ability.effect.valueInitial);
					break;
				case Variable.Speed:
					player.speed -= abil.executer.ability.effect.valueInitial;
					break;
				case Variable.Attack:
					player.Attack -= abil.executer.ability.effect.valueInitial;
					break;
				case Variable.AttackSpeed:
					player.AttackSpeed -= abil.executer.ability.effect.valueInitial;
					break;
			}
		}
		else
		{
			//create entity
			//do everything as above
		}
	}
}
