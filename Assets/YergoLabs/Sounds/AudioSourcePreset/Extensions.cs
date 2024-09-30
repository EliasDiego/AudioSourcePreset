using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YergoLabs.Sounds
{
    public static class Extensions
    {
        public static void SetPreset(this AudioSource audioSource, AudioSourcePreset audioSourcePreset)
        {
            Debug.Assert(audioSource, "Audio Source is null!");
            Debug.Assert(audioSourcePreset, "Audio Source Preset is null!");

            if(!audioSource || !audioSourcePreset)
                return;

            audioSource.clip = audioSourcePreset.audioClip;
            audioSource.bypassEffects = audioSourcePreset.bypassEffects;
            audioSource.bypassListenerEffects = audioSourcePreset.bypassListenerEffects;
            audioSource.bypassReverbZones = audioSourcePreset.bypassReverbZones;
            audioSource.loop = audioSourcePreset.loop;
            audioSource.pitch = audioSourcePreset.pitch;
            audioSource.priority = audioSourcePreset.priority;
            audioSource.outputAudioMixerGroup = audioSourcePreset.outputAudioMixerGroup;
            audioSource.volume = audioSourcePreset.volume;
            audioSource.panStereo = audioSourcePreset.stereoPan;
            audioSource.spatialBlend = audioSourcePreset.spatialBlend;
            audioSource.reverbZoneMix = audioSourcePreset.reverbZoneMix;
        }
    }
}