using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    private GameObject player;
    private Vector2 target;

    public float chaseSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        target = new Vector2(player.transform.position.x, transform.position.y); //Only get the x so they dont start hovering
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * chaseSpeed);
    }
}
