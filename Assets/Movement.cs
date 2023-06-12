using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    private Vector2Int targetPosition;
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = new Vector2Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y));
        transform.position = (Vector2)targetPosition;
    }

    // Update is called once per frame
    void Update()
    {
        var moving = (Vector2)transform.position != targetPosition;

        if (moving)
        {
            MoveTowardsTarget();
        }
        else
        {
            SetNewTarget();
        }
    }

    private void MoveTowardsTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private void SetNewTarget()
    {
        if (Input.GetKey(KeyCode.W))
        {
            targetPosition += Vector2Int.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            targetPosition += Vector2Int.down;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            targetPosition += Vector2Int.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            targetPosition += Vector2Int.right;
        }
    }
}


