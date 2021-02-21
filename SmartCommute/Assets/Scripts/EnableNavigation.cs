using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnableNavigation : MonoBehaviour
{
    public GameObject navigator;
    public Button b;
    private int flag = 0;

    public void enableNav()
    {
        if(b.GetComponentInChildren<Text>().text == "OK")
        {
            flag = 1;
            navigator.GetComponent<Navigation>().enabled = true;
        }
    }

    public void disableNav()
    {
        if (b.GetComponentInChildren<Text>().text == "Car")
        {
            navigator.GetComponent<Navigation>().enabled = false;
        }
    }

    public void newpath()
    {
        if (b.GetComponentInChildren<Text>().text == "OK" && flag == 1)
        {
            navigator.GetComponent<LineRenderer>().positionCount = 0;
            //navigator.GetComponent<NavMeshAgent>().isStopped= true;
            //navigator.GetComponent<NavMeshAgent>().ResetPath();
        }
        flag = 0;
    }
}
