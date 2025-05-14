using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionPanelAction : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _titleComponent;
    [SerializeField] TextMeshProUGUI _descriptionComponent;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] GameObject _canvas;
    AudioClip _sound;

    private void Start()
    {
    }
    public void Open(ACTIVITY_INFO activityInfo)
    {
        _canvas.SetActive(true);
        _titleComponent.text = activityInfo.title;
        _descriptionComponent.text = activityInfo.description;
        _sound = activityInfo.sound;
    }

    public void PlaySound()
    {
        _audioSource.clip = _sound;
        _audioSource.Play();
    }
}
