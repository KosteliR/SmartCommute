using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablebus : MonoBehaviour
{
    public GameObject buses;

    public void enableBuses()
    {
        buses.SetActive(true);
    }

    public void disableBuses()
    {
        buses.SetActive(false);
    }
}
