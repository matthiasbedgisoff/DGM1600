using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public int myHealth;
	public GameObject explosionEffect;

	public GameObject explosionEffect2;

	private int curHealth;
	private int maxHeartAmount = 3;
	private int startHearts = 3;
	private int maxHealth;
	private int healthPerHeart = 1;



	public Sprite[] healthSprite;
	public Image[] healthImages;

	void Start(){
		
			curHealth = startHearts * healthPerHeart;
			maxHealth = maxHeartAmount * healthPerHeart;
		checkHealthAmount ();
		}

		void checkHealthAmount()
	{
		for (int i = 0; i < maxHeartAmount; i++) {
			if (startHearts <= i) {
				healthImages [i].enabled = false;
			} else {
				healthImages [i].enabled = true;
			}
		}
	}

	void updateHearts()
	{
		bool empty = false;
		int i = 0;

		foreach (Image image in healthImages) {
			if (empty) {
				image.sprite = healthSprite [0];
			} else {
				i++;
				if (curHealth >= i * healthPerHeart) {
					image.sprite = healthSprite [healthSprite.Length - 1];
				} else {
					int currentHeartHealth = (int)(healthPerHeart - (healthPerHeart * i - curHealth));
					int healthPerImage = healthPerHeart / (healthSprite.Length - 1);
					int imageIndex = currentHeartHealth / healthPerImage;
					image.sprite = healthSprite [imageIndex];
					empty = true;
				}
			}
		}
	}

	public void TakeDamage(int amount)
	{
		curHealth += amount;
		curHealth = Mathf.Clamp (curHealth, 0, startHearts * healthPerHeart);
		updateHearts ();
	}

	public void AddHeartContainer()
	{
		startHearts++;
		startHearts = Mathf.Clamp (startHearts, 0, maxHeartAmount);

		curHealth = startHearts * healthPerHeart;
		maxHealth = maxHeartAmount * healthPerHeart;

		checkHealthAmount ();
	}

	//ship damage
	void OnCollisionEnter2D (Collision2D myCollider) {
		Instantiate(explosionEffect2, myCollider.transform.position, Quaternion.identity);
		//take away health

		myHealth--;


		if (myHealth <= 0) {
			Destroy (this.gameObject);
			Instantiate(explosionEffect, gameObject.transform.position, Quaternion.identity);

			//if (!Player ()){
			//IncrementScore();
			//}
		}

	}

	void OnTriggerEnter2D (Collider2D myCollider)
	{
		Instantiate (explosionEffect2, myCollider.transform.position, Quaternion.identity);
		//take away health

		myHealth--;


		if (myHealth <= 0) {
			Destroy (this.gameObject);
			Instantiate (explosionEffect, gameObject.transform.position, Quaternion.identity);
		}

	}



}


