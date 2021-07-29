using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownMove : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject user = GameObject.FindWithTag("Player");
        transform.LookAt(user.transform);
    }
}
