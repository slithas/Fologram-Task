using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMasterControl : MonoBehaviour
{
    public static CanvasMasterControl cmc;

    public GameObject world;
    public GameObject screen;

    public Transform scaler;
    public float x = 1;
    public float y = 1;
    public float z = 1;
    public bool join;   //toggle the link for all scaling on and off

    bool swap = true;

    // Start is called before the first frame update
    void Awake()
    {
        cmc = this;
    }

    // Update is called once per frame
    void Update()
    {
        scaler.localScale = new Vector3(x, y, z);
    }

    //flip the active canvas
    public void Swap()
    {
        world.SetActive(swap);
        screen.SetActive(!swap);
        swap = !swap;
    }

    public void Scale(string n, float value)
    {
        if (n == "x" || join) x = value;
        if (n == "y" || join) y = value;
        if (n == "z" || join) z = value;
    }

    public void Toggle()
    {
        join = !join;
    }
}
