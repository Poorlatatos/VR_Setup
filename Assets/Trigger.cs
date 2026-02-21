using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject TriggerBlock;
    public UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationArea TeleportationArea;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            TriggerBlock.SetActive(true);
            TeleportationArea.enabled = true;
        }

    }
}
