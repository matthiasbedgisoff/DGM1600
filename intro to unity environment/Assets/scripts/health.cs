using System.Collections;
using System.Collections.Generic;
using UnityEngine;

private Health;

public class health : MonoBehaviour {
	

	public void TakeDamage(int amount)
	{
		Health -= amount;
		if (Health <= 0)
		{
			Health = 0;
			Debug.Log("Dead!");
		}
	}
}