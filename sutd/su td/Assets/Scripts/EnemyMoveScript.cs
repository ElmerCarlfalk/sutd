using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class EnemyMoveScript : MonoBehaviour
{
    //movement
    public Rigidbody2D rb;
    public float speed = 25f;

    //Set path 
    public int currentWaypoint = 0;
    public Transform[] waypointList;
    Transform target;
    public Transform point1;
    public Transform point2;

    // Start is called before the first frame update
    void Start()
    {
        waypointList = GameObject.FindGameObjectWithTag("SpawnPoints").GetComponent<spawnPointArray>().waypointList;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentWaypoint < waypointList.Length)
        {
            if (target = null)
            {
                target = waypointList[currentWaypoint];
                //Move();
            }
            Move();
        }
    }

    void Move()
    {
        //rotate towards the target
        //transform.forward = Vector3.RotateTowards(transform.forward, target.position - transform.position, speed * Time.deltaTime, 0f);

        //move towards target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (transform.position == target.position)
        {
            currentWaypoint++;
            target = waypointList[currentWaypoint]; 
        }
    }
}
