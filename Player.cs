using UnityEngine;

public class Player : MonoBehaviour
{
    void Start() {
        // The player can call Observer too.
        Observer.Instance.AddCallback(HelloWorld);
    }

    private void HelloWorld() {
        Debug.Log("The player is alive!");
    }
}
