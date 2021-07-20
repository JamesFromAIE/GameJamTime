using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorAI : MonoBehaviour
{
    // Variables
    public GameObject survivor;
    public GameObject player;

    // Grenade Variables
    [SerializeField] private GameObject grenadePrefab;
    [SerializeField] private float grenadeForce;

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
        if (Input.GetKeyDown("g"))
        {
            GrenadeThrown();
        }
    }

    void GrenadeThrown()
    {
        GameObject i = Instantiate(grenadePrefab, new Vector3(survivor.transform.position.x + 0.2f, survivor.transform.position.y + 1.2f, survivor.transform.position.z + 1f), survivor.transform.rotation);
        i.GetComponent<Rigidbody>().AddForce(survivor.transform.forward * Random.Range(grenadeForce * 0.5f, grenadeForce) + new Vector3(0,Random.Range(5,11),0), ForceMode.Impulse);
    }
}
