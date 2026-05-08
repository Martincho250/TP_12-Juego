using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-2, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(2, 0, 0);
        }
          float xLimitada = Mathf.Clamp(transform.position.x, -2f, 2f);

        transform.position = new Vector3(
            xLimitada,
            transform.position.y,
            transform.position.z
        );
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            Destroy(gameObject);
        }
    }
    }
