using TMPro;
using UnityEngine;
using UnityEditor;

[ExecuteAlways]
public class CordinateSystems : MonoBehaviour
{
    [SerializeField]TextMeshPro m_blockPos;
    [SerializeField] Color c_isPlaceable = Color.blue;
    [SerializeField] Color c_blocked = Color.red;
    string blockPos;
    Waypoints waypoints;
    TextMeshPro m_textMeshPro;

    void Awake()
    {
        DisplayPosBlock();
        waypoints = GetComponent<Waypoints>();
        m_textMeshPro =GetComponentInChildren<TextMeshPro>(); 
        m_textMeshPro.enabled = false;
    }

    void Update()
    {
        if (!Application.isPlaying) { 
            DisplayPosBlock();
            DisplayNameBlock();
        }
        CordinateChangeColor();
        ToggleLabels();
    }

    void ToggleLabels()
    {
        if(Input.GetKeyDown(KeyCode.C)) { 
            m_textMeshPro.enabled = !m_textMeshPro.IsActive();
        }
    }

    void CordinateChangeColor ()
    {
        if (waypoints.GetIsPlaceable)
        {
            m_textMeshPro.color = c_isPlaceable;
        }
        else { 
            m_textMeshPro.color = c_blocked;
        }
    }

    void DisplayPosBlock()
    {
        Vector3 pos = transform.position;
        #if UNITY_EDITOR
        pos.x = Mathf.RoundToInt(pos.x / UnityEditor.EditorSnapSettings.move.x);
        pos.z = Mathf.RoundToInt(pos.z / UnityEditor.EditorSnapSettings.move.x);
        #endif
        blockPos = string.Format( "({0}, {1})" , pos.x, pos.z);
        m_blockPos.text = blockPos;

    }

    void DisplayNameBlock()
    {
        gameObject.name = blockPos;
    }

    
}
