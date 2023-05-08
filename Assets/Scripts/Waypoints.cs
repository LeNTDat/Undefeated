using Unity.VisualScripting;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] GameObject Tower;
    [SerializeField] bool isPlaceable;
    public bool GetIsPlaceable { get { return isPlaceable; } }
    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(Tower, new Vector3 (transform.position.x, Tower.transform.position.y , transform.position.z), Quaternion.identity);
            isPlaceable = false;
        }
    }
}
