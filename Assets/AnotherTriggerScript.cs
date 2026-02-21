using UnityEngine;

public class AnotherTriggerScript : MonoBehaviour
{
    public GameObject GameCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            GameCanvas.SetActive(true);
        }
    }
}
