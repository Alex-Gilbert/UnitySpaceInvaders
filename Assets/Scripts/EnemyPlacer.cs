using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlacer : MonoBehaviour
{
    public int NumberOfRows;
    public int EnemiesPerRow;
    public float EnemySpacing;
    public float RowSpacing;
    public GameObject EnemyObject;
    public GameObject RowMoverObject;
    public float RowTimedStartOffset;

    private List<Transform> RowTransforms;
    private void Start()
    {
        RowTransforms = new List<Transform>();
        float curY = transform.position.y;
        for (int i = 0; i < NumberOfRows; i++)
        {
            var RowObject = Instantiate(RowMoverObject);
            RowObject.GetComponent<RowMover>().SetTimeToWait (RowTimedStartOffset * i);
            
            float curX = transform.position.x;
            for (int j = 0; j < EnemiesPerRow; j++)
            {
                var enemyPosition = new Vector3(curX, curY, 0);
                var enemy = Instantiate(EnemyObject, enemyPosition, Quaternion.identity);
                enemy.transform.parent = RowObject.transform;
                curX += EnemySpacing;
            }
            RowTransforms.Add(RowObject.transform);
            curY += RowSpacing;
        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red; 
        float curY = transform.position.y;
        for (int i = 0; i < NumberOfRows; i++)
        {
            float curX = transform.position.x;
            for (int j = 0; j < EnemiesPerRow; j++)
            {
                Gizmos.DrawSphere(new Vector3(curX, curY, 0), .2f);
                curX += EnemySpacing; 
            }
            curY += RowSpacing; 
        }
    }
}
