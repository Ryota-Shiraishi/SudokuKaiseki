using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mkDropdown : MonoBehaviour
{
    public RectTransform contentRectTransform;
    public Dropdown dropdown;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 8; i++)
        {
            Instantiate(dropdown, contentRectTransform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
