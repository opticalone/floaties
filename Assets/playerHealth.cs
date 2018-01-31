using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour, IDamagable {


    public float maxHealth = 150.0f;
    public float currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;

	}

    public void takeDamage(float damage)
    {
        currentHealth -= damage;
    }

    public void idDead()
    {
        if(currentHealth <=0 )
        {
            SceneManager.LoadScene("NavMesh");
            Application.LoadLevel(Application.loadedLevel);s
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
