using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTransform : MonoBehaviour
{

    public Vector3 positionChange;
    private float positionInitialX;
    private float positionInitialY;
    private float positionInitialZ;
    private Boolean isIncrementing;

    // Start is called before the first frame update
    void Start()
    {
        positionInitialX = transform.position.x;
        positionInitialY = transform.position.y;
        positionInitialZ = transform.position.z;
        isIncrementing = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y >= (positionInitialY + 2.5))
        {
            isIncrementing = false;

        } else if (transform.position.y <= (positionInitialY - 2.5))
        {
            isIncrementing = true;
        }

        if (isIncrementing)
        {
            transform.position += positionChange;
        } else
        {
            transform.position -= positionChange;
        }
        
    }
}
