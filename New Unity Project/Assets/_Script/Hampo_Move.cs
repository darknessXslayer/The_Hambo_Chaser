using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Hampo_Move : MonoBehaviour
{

    private NavMeshAgent nav;
    private int currentDestination = 0;

    public List<Transform> target;
    public float targetDistanceThreshold;
    public static Hampo_Move instance;
    public bool follow = false;
    //these are used to move the AI towards the character
    public Transform Player;
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;


    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(follow == false)
        {
         if (nav.remainingDistance < targetDistanceThreshold)
         {
          SetNewDestination();
         }
        }
        else if(follow == true)
        {
            nav.SetDestination(Player.position);
            Debug.Log("Bool True");
        }

    }

    private void SetNewDestination()
    {
        currentDestination++;

        if (currentDestination > target.Count - 1)
        {
            currentDestination = 0;
        }
        nav.SetDestination(target[currentDestination].position);
    }
}
