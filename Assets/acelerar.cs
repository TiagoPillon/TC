using UnityEngine;
using System.Collections;

public class Acelerar : MonoBehaviour
{
    public Animation anim;
    public AnimationClip Andar;

    void Start()
    {
        // Walk at double speed
        anim["Andar"].speed = 2.0f;
    }
}