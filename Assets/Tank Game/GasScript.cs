using UnityEngine;

public class GasScript : MonoBehaviour
{
    float rotSeppd = 1.0f;


    public int fuelAmount = 5;


    private void Start()
    {
        rotSeppd = Random.Range(40, 60);
    }

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * rotSeppd, 0));
    }
}
