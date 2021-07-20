using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehaviour : MonoBehaviour
{
    public GameObject Survivor;
    public Transform SP1;
    public Transform SP2;
    public Transform SP3;
    public Transform SP4;
    int targetPoint;
    void Start()
    {
        Survivor = gameObject;

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
