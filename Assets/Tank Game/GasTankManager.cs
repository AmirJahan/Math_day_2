using UnityEngine;
using System.Collections.Generic;

public class GasTankManager : MonoBehaviour
{
    [SerializeField] GameObject gasStation;

    public static List<GameObject> allStations = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {

            Vector3 randomPos = new Vector3(Random.Range(-75, 75), 
                                             gasStation.transform.position.y,
                                             Random.Range(-75, 75)); 

            GameObject newStation = Instantiate(    gasStation,
                                                    randomPos,
                                                    Quaternion.identity);

            allStations.Add(newStation);
        }

        Debug.Log("We have: " + allStations.Count + " stations");
    }
}