using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health;
    public float damage;

    void Start()
    {
        
    }
    void Update()
    {
        if (health <= 0) Destroy(gameObject);//Application.Quit();
    }
}
