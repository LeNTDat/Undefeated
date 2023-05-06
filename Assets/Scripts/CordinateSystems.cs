using TMPro;
using UnityEditor;
using UnityEngine;

[ExecuteAlways]
public class CordinateSystems : MonoBehaviour
{

    [SerializeField]TextMeshPro m_blockPos;
    string blockPos;
    void Awake()
    {
        DisplayPosBlock();
    }

    void Update()
    {
        if (!Application.isPlaying) { 
            DisplayPosBlock();
            DisplayNameBlock();
        }
    }

    void DisplayPosBlock()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.RoundToInt(pos.x / EditorSnapSettings.move.x);
        pos.z = Mathf.RoundToInt(pos.z / EditorSnapSettings.move.x);
        blockPos = string.Format( "({0}, {1})" , pos.x, pos.z);
        m_blockPos.text = blockPos;

    }

    void DisplayNameBlock()
    {
        gameObject.name = blockPos;
    }

    
}
