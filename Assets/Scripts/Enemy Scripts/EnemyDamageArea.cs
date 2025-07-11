using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageArea : MonoBehaviour
{
    [SerializeField]
    private float deactiveWaitTime = 0.1f;
    private float deactiveTimer;

    [SerializeField]
    private LayerMask playerLayer;

    private bool canDealDamage;

    [SerializeField]
    private float damageAmount = 5f;

    // player health
    private PlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = GameObject.FindWithTag(TagManager.PLAYER_TAG).GetComponent<PlayerHealth>();

        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Physics2D.OverlapCircle(transform.position, 1f, playerLayer))
        {
            if (canDealDamage)
            {
                canDealDamage = false;
                // deal damage to player
                playerHealth.TakeDamage(damageAmount);
            }
        }
        DeactiveDamageArea();
    }

    void DeactiveDamageArea()
    {
        if (Time.time > deactiveTimer)
            gameObject.SetActive(false);
    }

    public void ResetDeactiveTimer() 
    {
        canDealDamage = true;
        deactiveTimer = Time.time + deactiveWaitTime;
    }

} // class



















