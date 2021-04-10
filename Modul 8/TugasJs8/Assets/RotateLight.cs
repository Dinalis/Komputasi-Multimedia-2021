using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public float speed = -1.0f;
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
