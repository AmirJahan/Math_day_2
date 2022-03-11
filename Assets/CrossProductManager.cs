using UnityEngine;


[ExecuteInEditMode]
public class CrossProductManager : MonoBehaviour
{
    [SerializeField] GameObject baseObj, tar_1, tar_2;


    float total = 100;

    void Update()
    {
        Vector3 baseToTarg_1 = tar_1.transform.position - baseObj.transform.position;
        Vector3 baseToTarg_2 = tar_2.transform.position - baseObj.transform.position;


        Debug.DrawLine(baseObj.transform.position,
                        tar_1.transform.position, Color.red);


        Debug.DrawLine(baseObj.transform.position,
                        tar_2.transform.position, Color.red);


        Vector3 upOfTheTwo = Vector3.Cross(baseToTarg_1, baseToTarg_2);


        Debug.DrawLine(baseObj.transform.position, upOfTheTwo, Color.blue);



        /**
         * This is to align the player to a gas station graually using Cross
         * this was your ungraded homework
        float journey = Time.time / total; // 0, .01, .5, .9, 1, 1.2

        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position,
                                                        new Vector3(100, 100, 0),
                                                           journey);

        gameObject.transform.eulerAngles = Vector3 ()

        */
    }
}
