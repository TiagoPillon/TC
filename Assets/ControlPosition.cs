using UnityEngine;
using UnityEngine.UI;

public class ControlPosition : MonoBehaviour
{
    Animation anim;

    public Slider slider;   

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animation>();
        anim.Play("Andar");
        anim["Andar"].speed = 5;

    }

    // Update is called once per frame
    public void AnimateOnSliderValue()
    {
        anim["Andar"].normalizedTime = slider.value;
    }
}