using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
namespace The_Final_Drop_abduosaber
{
    public class SettingMenu : MonoBehaviour
    {
        public AudioMixer AudioMixer;
        public void SetVolume(float volume)
        {
            AudioMixer.SetFloat("volume", volume);
        }
        public AudioMixer AudioMixer2;
        public void SetSFX(float sfx)
        {
            AudioMixer2.SetFloat("sfx", sfx);
        }
    }
}
