using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    public static PlayerPos instance;

    private Transform player;

    void Start()
    {
        instance = this;

        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player != null)
        {
            Checkpoint();
        }
    }

    public void Checkpoint()
    {
        Vector3 playerPos = transform.position;
        playerPos.z = 0f;

        player.position = playerPos;
    }
}
