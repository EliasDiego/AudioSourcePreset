using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Internal;

namespace YergoLabs.Sounds
{
    [CreateAssetMenu(menuName = "YergoLabs/Sounds/Audio Source Preset")]
    public class AudioSourcePreset : ScriptableObject
    {
        [SerializeField] private AudioClip _AudioClip;
        [SerializeField] private AudioMixerGroup _OutputAudioMixerGroup;
        [SerializeField] private bool _BypassEffects = false;
        [SerializeField] private bool _BypassListenerEffects = false;
        [SerializeField] private bool _BypassReverbZones = false;
        [SerializeField] private bool _Loop = false;
        [SerializeField, Range(0, 256)] private int _Priority = 128;
        [SerializeField, Range(0, 1)] private float _Volume = 1;
        [SerializeField, Range(-3, 3)] private float _Pitch = 1;[SerializeField, Range(-1, 1)] private float _StereoPan = 0;
        [SerializeField, Range(0, 1)] private float _SpatialBlend = 0;
        [SerializeField, Range(0, 1.1f)] private float _ReverbZoneMix = 1;

        public AudioClip audioClip => _AudioClip;
        public AudioMixerGroup outputAudioMixerGroup => _OutputAudioMixerGroup;
        public bool bypassEffects => _BypassEffects;
        public bool bypassListenerEffects => _BypassListenerEffects;
        public bool bypassReverbZones => _BypassReverbZones;
        public bool loop => _Loop;
        public int priority => _Priority;
        public float volume => _Volume;
        public float pitch => _Pitch;
        public float stereoPan => _StereoPan;
        public float spatialBlend => _SpatialBlend;
        public float reverbZoneMix => _ReverbZoneMix;
    }
}