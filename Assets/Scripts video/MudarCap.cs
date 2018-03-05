using UnityEngine;
using System.Collections;

public class MudarCap : MonoBehaviour
{
    public Animation anim;
    public AnimationClip Andar;
    void Start()
    {
        anim = GetComponent<Animation>();
        foreach (AnimationState state in anim)
        {
            state.speed = 0.5F;
        }
    }
}