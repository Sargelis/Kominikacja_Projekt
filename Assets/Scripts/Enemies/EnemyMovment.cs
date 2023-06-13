using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    Transform player;
    public EnemyStats enemyStats;
    PlayerStats playerStats;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyStats.moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            FindAnyObjectByType<PlayerStats>().health--; //playerStats.health--;
        }
    }
}