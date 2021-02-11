using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
