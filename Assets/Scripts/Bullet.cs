using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Transform target;
    public float speed;
    public EnemyStats enemyStats;

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 dir = target.position - transform.position;
        float distancethisFrame = speed * Time.deltaTime;

        if ( dir.magnitude <= distancethisFrame )
        {
            HitTarget();
            return;
        }

        transform.Translate (dir.normalized * distancethisFrame, Space.World);
    }

    public void Seek(Transform _target)
    {
        target = _target;
    }
    void HitTarget()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            //enemyStats.setHp--;
            //if (enemyStats.setHp <= 0 ) Destroy(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}