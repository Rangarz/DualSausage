using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class OptionMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    Resolution[] resolutions;
    public Dropdown resolutionDropDown;
    

    private void Start()
    {
        resolutions= Screen.resolutions;
        resolutionDropDown.ClearOptions();
        //to convert resolution into strings
        int crurrentResolutionIndex = 0;
        List<string> options = new List<string>();
        for (int i=0;i<resolutions.Length;i++)
        {
            string option = resolutions[i].width + "X" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width==Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) 
            {
                crurrentResolutionIndex = i;
            }
        }
        //it takes strings only
        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = crurrentResolutionIndex;
        resolutionDropDown.RefreshShownValue();

    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("Volume",volume);
    }

    public void SetQuality(int qualityIndex) 
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    
    public void SetFullScreen(bool isFullScreen) 
    {
        Screen.fullScreen = isFullScreen;
    }


}
 