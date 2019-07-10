using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour
{
    public float speed = 6.0f;

    void Update()
    {
        // Move the controller
        transform.eulerAngles += new Vector3(0, Input.GetAxis("Horizontal"), 0) * speed;
        if (Input.GetAxis("Vertical") > 0) transform.position += transform.forward * Time.deltaTime * speed;
    }
}