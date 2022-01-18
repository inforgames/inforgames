using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KI : MonoBehaviour
{
    public bool playerInChaseRange, playerInAttackRange;

    public NavMeshAgent agent;
    public Transform Player;
    private bool alreadyAttacked;
    public float timeBetweenAttacks;
    private bool ResetAttack;
    public float sightRange, attackRange;
    public LayerMask whatIsGround, whatIsPlayer;

    public PlayerHealth playerhealth;
    public Transform projectile;

    private void Awake()
    {
        Player = GameObject.Find("PlayerObj").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }
        // Update is called once per frame
    void Update()
    {
        playerInChaseRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInChaseRange && !playerInAttackRange) Patroling();
        if (playerInChaseRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange) AttackPlayer();
    }

    void Patroling()
    {
        
    }

    void AttackPlayer()
    {
        Invoke("PlayertakeDamage", 3f);
    }

    void PlayertakeDamage()
    {
        playerhealth.health -= 10f;
    }

    void ChasePlayer()
    {
        agent.SetDestination(Player.position);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
