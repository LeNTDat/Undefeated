using Unity.VisualScripting;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    void OnMouseDown()
    {
        if (isPlaceable)
        {
            print(gameObject.name);
        }
    }
}
