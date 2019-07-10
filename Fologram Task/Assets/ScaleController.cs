using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    public bool x;
    public bool y;
    public bool z;

    Slider slider;
    CanvasMasterControl cmc;

    void Start()
    {
        cmc = CanvasMasterControl.cmc;
        slider = GetComponent<Slider>();
    }

    // Keeping all the sliders the same value on both canvases
    void LateUpdate()
    {
        if (x) slider.value = cmc.x;
        if (y) slider.value = cmc.y;
        if (z) slider.value = cmc.z;
    }

    public void Scale()
    {
        if (x) cmc.Scale("x", slider.value);
        if (y) cmc.Scale("y", slider.value);
        if (z) cmc.Scale("z", slider.value);
    }
}
