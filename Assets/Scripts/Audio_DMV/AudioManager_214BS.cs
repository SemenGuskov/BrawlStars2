using System.Collections.Generic;
using UnityEngine;
using System.IO.IsolatedStorage;

public class AudioManager_214BS : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourceMusic;
    [SerializeField] private AudioSource _audioSourceFXUI;
    
    [SerializeField] private List<AudioClip> _musicClip;
    [SerializeField] private List<AudioClip> _soundsClip;
    [SerializeField] private List<AudioClip> _soundsHeroClip;
    [SerializeField] private List<AudioClip> _soundsUIEffectClip;

    [SerializeField] private GameObject buttonSoundOn;
    [SerializeField] private GameObject buttonSoundOff;
    [SerializeField] private GameObject buttonMusicOn;
    [SerializeField] private GameObject buttonMusicOff;

    [SerializeField] AudioSource[] _cashedAudio;
    
    private void Start()
    {
        CheckMusic();
        if (Save_214BS.save_BS().saveDataBS.SoundsBS)
        {
            _audioSourceFXUI.mute = false;
            buttonSoundOn.SetActive(true);
            buttonSoundOff.SetActive(false);
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            foreach (var audioSource in _cashedAudio)
            {
                audioSource.mute = false;
            }
        }
        else
        {
            _audioSourceFXUI.mute = true;
            buttonSoundOn.SetActive(false);
            buttonSoundOff.SetActive(true);
            foreach (var audioSource in _cashedAudio)
            {
                audioSource.mute = true;
            }
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
        }
    }

    public void SoundEffect(int index)
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _audioSourceFXUI.PlayOneShot(_soundsUIEffectClip[index]);
    }
    public void MenuBtnPlaySound()
    { 
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _audioSourceFXUI.PlayOneShot(_soundsClip[0]);
    }
    public void HomeBtnPlaySound()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _audioSourceFXUI.PlayOneShot(_soundsClip[1]);
    }
    public void BackBtnPlaySound()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _audioSourceFXUI.PlayOneShot(_soundsClip[2]);
    }
    
    public void CheckSound()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        if (Save_214BS.save_BS().saveDataBS.SoundsBS)
        {
            _audioSourceFXUI.mute = false;
            buttonSoundOn.SetActive(true);
            buttonSoundOff.SetActive(false);
            foreach (var audioSource in _cashedAudio)
            {
                audioSource.mute = false;
            }
        }
        else
        {
            _audioSourceFXUI.mute = true;
            buttonSoundOn.SetActive(false);
            buttonSoundOff.SetActive(true);
            foreach (var audioSource in _cashedAudio)
            {
                audioSource.mute = true;
            }
        }
    }

    public void OnOffSound_214BS(bool off)
    {
        if (off)
        {
            Save_214BS.save_BS().saveDataBS.SoundsBS = false;
            Save_214BS.save_BS().SaveGameBS();
        }
        else
        {
            Save_214BS.save_BS().saveDataBS.SoundsBS = true;
            Save_214BS.save_BS().SaveGameBS();
        }
        
        Invoke("CheckSound",0.2f);
    }
    
    public void CheckMusic()
    {
        if (Save_214BS.save_BS().saveDataBS.MusicBS)
        {
            buttonMusicOn.SetActive(true);
            buttonMusicOff.SetActive(false);
            _audioSourceMusic.mute = false;
            _audioSourceMusic.clip = _musicClip[0];
            _audioSourceMusic.loop = true;
            _audioSourceMusic.Play();
        }
        else
        {
            buttonMusicOn.SetActive(false);
            buttonMusicOff.SetActive(true);
            _audioSourceMusic.mute = true;
        }
    }

    public void OnOffMusic_214BS()
    {
        if (Save_214BS.save_BS().saveDataBS.MusicBS)
        {
            Save_214BS.save_BS().saveDataBS.MusicBS = false;
            Save_214BS.save_BS().SaveGameBS();
        }
        else
        {
            Save_214BS.save_BS().saveDataBS.MusicBS = true;
            Save_214BS.save_BS().SaveGameBS();
        }

        Invoke("CheckMusic",0.1f);
    }
}
