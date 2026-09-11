using TMPro;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private int startingSeeds = 5;

    private int currentSeeds = 0;
    private int seedsPlantedInt = 0;

    [SerializeField] private GameObject spawnSeed;
    [SerializeField] private TextMeshProUGUI seedsRemaining;
    [SerializeField] private TextMeshProUGUI seedsPlanted;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        currentSeeds = startingSeeds;
        seedsRemaining.text = "seeds remaining - " + currentSeeds;
        seedsPlanted.text = "seeds planted - " + seedsPlantedInt;

    }
    private void PlantSeed()
    {
                    Debug.Log("Space Button Pressed Planting seed");
            Instantiate(spawnSeed, transform.position, Quaternion.identity);
            currentSeeds -= 1;
            seedsPlantedInt += 1;
            Debug.Log("Current Seeds remaining - " + currentSeeds);
            Debug.Log("Seeds Planted - " + seedsPlantedInt);
            
            seedsPlanted.text = "seeds planted - " + seedsPlantedInt;
            seedsRemaining.text = "seeds Remaining - " + currentSeeds;
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, v, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

    if (Input.GetKeyDown(KeyCode.Space) && currentSeeds > 0)
        {

            PlantSeed();
        }

    }
}
