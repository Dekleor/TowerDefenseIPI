using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTranform;
   private NavMeshAgent navMeshAgents;
    void Awake()
    {
        navMeshAgents = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        navMeshAgents.destination =movePositionTranform.position;
    }
    
}
