using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private GameController gameController;
    private Vector3 checkpointSpawn;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        checkpointSpawn = GetComponentInParent<CheckPointTrigger>().spawnPosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.setSpawnPoint(checkpointSpawn);
        }
    }
}
