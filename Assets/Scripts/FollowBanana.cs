using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowBanana : MonoBehaviour
{

    public Transform banane;
    private NavMeshAgent zombie;
    // Start is called before the first frame update
    void Start()
    {
        zombie = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        zombie.SetDestination(banane.position);
    }
}
