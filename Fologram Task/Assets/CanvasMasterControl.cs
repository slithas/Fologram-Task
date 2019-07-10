using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMasterControl : MonoBehaviour
{
    public GameObject world;
    public GameObject screen;

    bool swap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //flip the active canvas
    public void Swap()
    {
        world.SetActive(swap);
        screen.SetActive(!swap);
        swap = !swap;
    }
}
