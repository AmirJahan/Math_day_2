using UnityEngine;

public class DotProductScript : MonoBehaviour
{

    GameObject target;

    // Start is called before the first frame update
    void Start()
    {

        // assuming that we are at 0, 0, 0 

        // the smaller one is better aligend

        Vector3.Dot( gameObject.transform.position.normalized,  // 1
                     target.transform.position.normalized); // 1


        gameObject.transform.LookAt(target.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
