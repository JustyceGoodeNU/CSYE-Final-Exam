using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
