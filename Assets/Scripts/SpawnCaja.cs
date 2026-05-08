using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCaja : MonoBehaviour
{
    int randomNumber;
    public float StartYValue;
    // Start is called before the first frame update
    void Start()
    {
        LocateBoxAtRandomPosition();
    }

    // Update is called once per frame
    public void LocateBoxAtRandomPosition()
    {
        Vector3 currentPosition = transform.position;
        float newX = 0f;
        randomNumber = Random.Range(0,3);
        if(randomNumber == 0){
            newX = -2f;
        }
        else if(randomNumber == 1){
            newX = 0f;
        }
        else if(randomNumber == 2){
            newX = 2f;
        }
        currentPosition.x = newX;
        currentPosition.y = StartYValue;
        transform.position = currentPosition;
    }
}
