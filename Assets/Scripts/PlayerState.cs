using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : ScriptableObject
{
	public float speed;
	public List<Effect> effects;
	public List<AbilityExecuter> executers;
	public int HP;
	public float AttackSpeed;
	public float Attack;

	public Transform transform;

	// Start is called before the first frame update
	void Start()
	{
		speed = 5.0f;
		Time.fixedDeltaTime = 1;
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	void FixedUpdate()
	{
		foreach(Effect effect in effects)
		{
			if (effect.currentTimeEffect == effect.duration)
			{
				effect.times -= 1;
				if (effect.variableCurrent == Variable.HP)
				{
					HP -= (int)Mathf.Round(effect.valueCurrent);
				}
				else if(effect.variableCurrent == Variable.AttackSpeed)
				{
					AttackSpeed -= effect.valueCurrent;
				}
				else if(effect.variableCurrent == Variable.Attack)
				{
					Attack -= effect.valueCurrent;
				}
				else if(effect.variableCurrent == Variable.Speed)
				{
					speed -= effect.valueCurrent;
				}
				else if(effect.variableCurrent == Variable.PosX)
				{
					transform.position = new Vector2(transform.position.x - effect.valueCurrent, transform.position.y);
				}
				else if(effect.variableCurrent == Variable.PosY)
				{
					transform.position = new Vector2(transform.position.x, transform.position.y - effect.valueCurrent);
				}
				effect.valueCurrent += effect.valueShiftCurrent;
				if (effect.times == 0)
				{
					if (effect.variableFinal == Variable.HP)
					{
						HP -= (int)Mathf.Round(effect.valueFinal);
					}
					else if (effect.variableFinal== Variable.AttackSpeed)
					{
						AttackSpeed -= effect.valueFinal;
					}
					else if (effect.variableFinal == Variable.Attack)
					{
						Attack -= effect.valueFinal;
					}
					else if (effect.variableFinal == Variable.Speed)
					{
						speed -= effect.valueFinal;
					}
					else if (effect.variableFinal == Variable.PosX)
					{
						transform.position = new Vector2(transform.position.x - effect.valueFinal, transform.position.y);
					}
					else if (effect.variableFinal == Variable.PosY)
					{
						transform.position = new Vector2(transform.position.x, transform.position.y - effect.valueFinal);
					}
					effects.Remove(effect);
				}
			}

		}
	}
}
