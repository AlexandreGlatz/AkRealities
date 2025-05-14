using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonMaker : MonoBehaviour
{
    [SerializeField] List<ACTIVITY_INFO> _activities = new List<ACTIVITY_INFO>();
    [SerializeField] GameObject _parent;
    [SerializeField] GameObject _buttonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _activities.Count; i++)
        {
            GameObject newButton = Instantiate(_buttonPrefab, _buttonPrefab.transform.position, Quaternion.identity, _parent.transform);
            newButton.SetActive(true);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = _activities[i].title;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
