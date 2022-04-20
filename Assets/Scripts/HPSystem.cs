using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSystem : MonoBehaviour
{
	[SerializeField] private int health = 3;
	[SerializeField] private int maxHealth = 3;

	private void Start()
	{
		maxHealth = health;
	}

	public void PlusHealth(int amount)
	{
		if (health + amount > maxHealth)
		{
			health = maxHealth;
		}
	}

	public void TakeHealth(int amount)
    {
		health -= amount;

		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}

	public void ModifyHealth(int amount)
	{
		if (health + amount > maxHealth)
		{
			amount = maxHealth - health;
		}

		health += amount;

		//DEAD
		if (health <= 0)
		{
			Destroy(gameObject);
		}
	}
}
