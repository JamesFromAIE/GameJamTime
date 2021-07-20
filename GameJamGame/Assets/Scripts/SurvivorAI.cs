using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorAI : MonoBehaviour
{
    // Variables
    public GameObject survivor;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        survivor = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        survivor.transform.LookAt(player.transform);
    }
}
