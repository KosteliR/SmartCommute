using UnityEngine;
using UnityEngine.UI;

public class GoalPointRotOnCar : MonoBehaviour
{
    public GameObject goal;
    public Button car;

    public void rotGoalPoint()
    {
        Image img = goal.GetComponent<Image>();
        if (car.GetComponentInChildren<Text>().text == "Car")
        {
            Vector3 p = img.transform.position;
            p.z -= 4.5f;
            img.transform.position = p;
            img.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else if(car.GetComponentInChildren<Text>().text == "OK")
        {
            img.gameObject.SetActive(false);
            Vector3 p = img.transform.position;
            p.z += 4.5f;
            img.transform.position = p;
            img.transform.eulerAngles = new Vector3(90, 0, 0);
        }
    }
}
