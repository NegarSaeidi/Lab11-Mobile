using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CheckPointTrigger : MonoBehaviour
{
    public Transform spawnPoint, trigger;
    public Vector3 spawnPosition, triggerPOsition;

    private Vector3 currentSpwanPosition, currentTriggerPOsition;

    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = spawnPoint.position;
        triggerPOsition = trigger.position;
        currentSpwanPosition = spawnPosition;
        currentTriggerPOsition = triggerPOsition;
     
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfPositionChanged(); 
    }
    public void CheckIfPositionChanged()
    {
        if(spawnPosition != currentSpwanPosition)
        {
            spawnPoint.position = spawnPosition;
            currentSpwanPosition = spawnPosition;
        }
        if(currentTriggerPOsition!=triggerPOsition)
        {
            trigger.position = triggerPOsition;
            currentTriggerPOsition = triggerPOsition;
        }
      
    }
  
}
