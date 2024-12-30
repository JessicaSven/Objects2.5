using UnityEngine;

public interface IUncontroll
{
    public int ExperiencePoint { get; set; }

    public void RunAway();

    public virtual void Die()
    {
        Debug.Log("Enemy is dead");
    }

}
