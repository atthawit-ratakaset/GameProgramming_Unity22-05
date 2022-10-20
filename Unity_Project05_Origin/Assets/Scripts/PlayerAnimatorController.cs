using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private static readonly int YVelocity = Animator.StringToHash("yVelocity");

    public void SetAnimatorParameters(Vector2 playerVelocity)
    {
        animator.SetFloat(YVelocity, playerVelocity.y);
    }
}
