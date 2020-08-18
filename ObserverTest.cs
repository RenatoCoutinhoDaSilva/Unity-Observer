using UnityEngine;

public class ObserverTest : MonoBehaviour
{
    private void Start() {
        // We can call an anonymous method too.
        Observer.Instance.AddCallback(() => {
            Debug.Log("This is an anonymous method!");
        });

        // To invoke this method and call player and enemy invokes too, please make sure that this script 
        // is called before the others in the script order.
        // It's is only an example, in a real game you cannot make this acoupling.
        Observer.Instance.Invoke();
    }
}
