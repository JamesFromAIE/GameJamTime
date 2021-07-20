using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehaviour : MonoBehaviour
{
    [SerializeField] Transform Survivor;
    [SerializeField] Transform SP1;
    [SerializeField] Transform SP2;
    [SerializeField] Transform SP3;
    [SerializeField] Transform SP4;
    int targetPoint;
    void Start()
    {
        targetPoint = Random.Range(1, 5);

        if (targetPoint == 1)
        {
            Survivor = SP1;
        }
        else if (targetPoint == 2)
        {
            Survivor = SP2;
        }
        else if (targetPoint == 3)
        {
            Survivor = SP3;
        }
        else
        {
            Survivor = SP4;
        }
    }
}
