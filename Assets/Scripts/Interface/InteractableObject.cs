using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject : MonoBehaviour, IDamageable
{
    public abstract float MovementSpeed { get; set; }
    protected Health _health;

    public abstract void Attack();
    public abstract void Move(Vector2 direction, Vector2 lookDirection);
    public abstract void OnTakeDamage(int damage, int score = 0);
    public abstract void Die();
}
