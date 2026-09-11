using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 10f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, v, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

    }
}
