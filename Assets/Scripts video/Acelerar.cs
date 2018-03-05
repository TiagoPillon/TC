using UnityEngine;
using System.Collections;

public class acelerar : MonoBehaviour
{
    public Animation anim;

    void Start()
    {
        // Walk at double speed
        anim["Andar"].speed = 2.0f;
    }
}