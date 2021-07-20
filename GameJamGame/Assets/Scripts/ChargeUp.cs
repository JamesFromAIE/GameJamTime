using UnityEngine;

public class ChargeUp : MonoBehaviour
{
    [SerializeField] float maxTime = 3f;

    float elapsedTime = 0f;
    public float percentage = 0;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            if (elapsedTime >= maxTime)
            {
                elapsedTime = maxTime;
            }
            else
            {
                elapsedTime += Time.deltaTime;
            }
        }

        percentage = elapsedTime / maxTime;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            elapsedTime = 0;
        }
    }
}
