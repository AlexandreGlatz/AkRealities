using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMaker : MonoBehaviour
{
    [SerializeField] List<ACTIVITY_INFO> _activities = new List<ACTIVITY_INFO>();
    [SerializeField] GameObject _parent;
    [SerializeField] GameObject _buttonPrefab;
    [SerializeField] DescriptionPanelAction _action;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _activities.Count; i++)
        {
            ACTIVITY_INFO currentActivity = _activities[i];
            GameObject newButton = Instantiate(_buttonPrefab, _buttonPrefab.transform.position, Quaternion.identity, _parent.transform);
            newButton.SetActive(true);
            newButton.GetComponentInChildren<TextMeshProUGUI>().text = _activities[i].title;
            newButton.GetComponent<Button>().onClick.AddListener(delegate { _action.gameObject.SetActive(true); });
            newButton.GetComponent<Button>().onClick.AddListener(delegate { OpenPanel(currentActivity); });
            
        }
    }

    void OpenPanel(ACTIVITY_INFO activityInfo)
    {
        _action.Open(activityInfo);
    }
}
