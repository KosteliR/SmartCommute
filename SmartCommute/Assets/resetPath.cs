using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class resetPath : MonoBehaviour
{
    private Navigation reset_path;

    void Start()
    {
        reset_path = FindObjectOfType<Navigation>();
    }

    public void resetpath()
    {
        reset_path.deletePath(new NavMeshPath());
    }
}
