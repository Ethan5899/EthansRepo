using UnityEngine;
using System.Collections;

public class EnemyDestroyOnCollide : MonoBehaviour
{
	public int EnemyHP = 1;

	void OnCollisionEnter2D (Collision2D ColInfo)
	{
		if (ColInfo.gameObject.tag == "Bullet" && ColInfo.otherCollider.gameObject.tag == "Enemy") {
			EnemyHP -= 1;
			Destroy (ColInfo.gameObject);
		}
		if (EnemyHP < 1) {
			Destroy (gameObject);
		}
	}






	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

