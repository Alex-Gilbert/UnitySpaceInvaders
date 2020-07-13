using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum RowState
{
    MovingLeft, MovingRight, MovingDown, WaitToStart 
}
public class RowMover : MonoBehaviour
{
    public float Xmax;
    public float Xmin;
    public float speed;
    public float drop;
    private float waitTime;
    private float TimeElapsed; 
    private RowState State;
    private float AmountMovedDown;
    public void SetTimeToWait(float TimeToWait)
    {
        waitTime = TimeToWait;
    }
    // Start is called before the first frame update
    void Start()
    {
        State = RowState.WaitToStart;
        TimeElapsed = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        switch (State) 
        {
            case RowState.WaitToStart:
                TimeElapsed += Time.deltaTime;
                if (TimeElapsed > waitTime)
                    State = RowState.MovingRight;
                break;

            case RowState.MovingRight:
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (transform.position.x > Xmax)
                    State = RowState.MovingDown;
                break;

            case RowState.MovingLeft:
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (transform.position.x < Xmin)
                    State = RowState.MovingDown;
                break;

            case RowState.MovingDown:
                var AmountToMoveDown = speed * Time.deltaTime;
                transform.Translate(Vector3.down * speed * Time.deltaTime);
                AmountMovedDown += AmountToMoveDown;
         
                if (AmountMovedDown > drop)
                {
                    AmountMovedDown = 0;
                    if (transform.position.x < Xmin)
                        State = RowState.MovingRight;
                    if (transform.position.x > Xmax)
                        State = RowState.MovingLeft;
                }
                break;
        }
    }
}
