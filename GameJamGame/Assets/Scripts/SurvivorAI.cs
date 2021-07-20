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
    [SerializeField] private float grenadeThrowTimer;
    [SerializeField] private float currentTimer;
    private GameObject i;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        survivor = gameObject;
        currentTimer = Random.Range(grenadeThrowTimer, grenadeThrowTimer * 2f);
    }

    // Update is called once per frame
    void Update()
    {
        survivor.transform.LookAt(player.transform);
        currentTimer -= Time.deltaTime;
        if  (currentTimer <= 0)
        {
            GrenadeThrown();
            currentTimer = Random.Range(grenadeThrowTimer,grenadeThrowTimer * 1.5f);
        }
        /*if (Input.GetKeyDown("g"))
        {
            GrenadeThrown();
        }
        if (Input.GetKeyDown("b"))
        {
            DistanceBetween();
        }*/
    }

    void GrenadeThrown()
    {
        i = Instantiate(grenadePrefab, new Vector3(survivor.transform.position.x, survivor.transform.position.y + 2.7f, survivor.transform.position.z), Random.rotation);
        float a = grenadeForce + DistanceBetween();
        i.GetComponent<Rigidbody>().AddForce(survivor.transform.forward * Random.Range(a * 0.75f, a * 1.25f) + new Vector3(0,Random.Range(5,11),0), ForceMode.Impulse);
    }

    float DistanceBetween()
    {
        float a = player.transform.position.x;
        float b = survivor.transform.position.x;
        float c = player.transform.position.y;
        float d = survivor.transform.position.y;
        float e = player.transform.position.z;
        float f = survivor.transform.position.z;
        //Debug.Log(Mathf.Abs(a - b + c - d + e - f));
        return Mathf.Abs((a - b + c - d + e - f) / 3);
    }
}
