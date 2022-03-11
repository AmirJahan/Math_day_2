using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float speed = 1.0f, rotationSpeed = 1.0f;


    private int playerFuel = 60;
    private int playerHealth = 3;


    GameObject targetStation;
    float cosinValue = float.NegativeInfinity;



    void Update()
    {
        float forwardTrans = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        gameObject.transform.Translate(new Vector3(0, 0, forwardTrans));


        float yRotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        gameObject.transform.Rotate(new Vector3(0, yRotation, 0));

        checkGasStations();
        checkEnemies();



        if (Input.GetKeyUp(KeyCode.Space))
        {
            cosinValue = float.NegativeInfinity;

            foreach (GameObject gasStation in GasTankManager.allStations)
            {

                Vector3 facing = gameObject.transform.forward;
                Debug.Log("Forward is: " + facing);

                Vector3 vecBetween = gasStation.transform.position - gameObject.transform.position;


                float dot = Vector3.Dot(facing,  // 1
                         vecBetween);

                if (dot > cosinValue)
                {
                    targetStation = gasStation;
                    cosinValue = dot;
                }
            }


            gameObject.transform.LookAt(targetStation.transform.position);
        }


    }




    void checkEnemies()
    {
        foreach (GameObject enemy in
            EnemyManagerScript.allEnemies)
        {
            float distance =
                Vector3.Distance(gameObject.transform.position,
                                       enemy.transform.position);

            if (distance < 3)
            {
                if (!enemy.GetComponent<SingleEnemyScript>().causedDamage)
                {
                    enemy.GetComponent<SingleEnemyScript>().causedDamage = true;
                    playerHealth--;
                }
            }
        }
    }








    void checkGasStations()
    {
        foreach (GameObject gasStation in GasTankManager.allStations)
        {
            float distance = Vector3.Distance(gameObject.transform.position,
                                                gasStation.transform.position);

            if (distance < 3)
            {
                if (gasStation.GetComponent<GasScript>().fuelAmount > 0)
                {
                    playerFuel += 5;
                    gasStation.GetComponent<GasScript>().fuelAmount = 0;


                    gasStation.GetComponentInChildren<Renderer>().material.color = Color.gray;


                    playerFuel = Mathf.Clamp(playerFuel, 0, 80);

                    Debug.Log("Current Fuel Level is: " + playerFuel.ToString());
                }
            }
        }
    }

}
