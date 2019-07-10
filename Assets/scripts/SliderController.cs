using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = 8f;
        slider.minValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = timer.timeLeft;
    }
}
