using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveLeft : MonoBehaviour
{
  public float speedVal;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speedVal * Time.deltaTime;
    }
}
