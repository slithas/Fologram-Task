using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleLock : MonoBehaviour
{
    CanvasMasterControl cmc;
    Toggle link;

    // Start is called before the first frame update
    void Start()
    {
        cmc = CanvasMasterControl.cmc;
        link = GetComponent<Toggle>();
    }
}
