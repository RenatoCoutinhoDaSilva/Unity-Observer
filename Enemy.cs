using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        // The enemy can call Observer for any purpose.
        Observer.Instance.AddCallback(HelloWorld);
    }

    private void HelloWorld() {
        Debug.Log("The enemy is alive!");
    }
}
