using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTower : MonoBehaviour
{
    [SerializeField] bool isShowUpgrade = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShowUpgradeTower();
    }

    void ShowUpgradeTower() {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.SetActive(true);
            return;
        }
        gameObject.SetActive(false);
    }

}
