using UnityEngine;
using System.Collections;

public class Voltar : MonoBehaviour
{
    public Animation anim;
    public AnimationClip Andar;

    void Start()
    {
        // Walk backwards
        anim["Andar"].speed = -1.0f;
        
    }
}