using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] Tower PrefabTower;
    [SerializeField] bool isPlaceable;
    public bool GetIsPlaceable { get { return isPlaceable; } }
    void OnMouseDown()
    {
        if (isPlaceable)
        {
            bool isPlaced = PrefabTower.CreateTower(PrefabTower, transform.position);
            isPlaceable = !isPlaced;
        }
    }
}
