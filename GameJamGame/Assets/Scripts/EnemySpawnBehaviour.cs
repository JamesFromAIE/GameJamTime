using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehaviour : MonoBehaviour
{
    [SerializeField] GameObject Survivor;
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
            Survivor.transform.position = SP1.position;
        }
        else if (targetPoint == 2)
        {
            Survivor.transform.position = SP2.position;
        }
        else if (targetPoint == 3)
        {
            Survivor.transform.position = SP3.position;
        }
        else
        {
            Survivor.transform.position = SP4.position;
        }
    }
}
