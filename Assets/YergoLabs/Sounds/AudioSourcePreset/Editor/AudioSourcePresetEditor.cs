using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using UnityEditor;

namespace YergoLabs.Sounds
{
    [CustomEditor(typeof(AudioSourcePreset))]
    public class AudioSourcePresetEditor : Editor
    {
        private AudioSource _PreviewAudioSource;
        private AudioSourcePreset _AudioPreset;

        private void OnEnable() 
        {
            _PreviewAudioSource = EditorUtility.CreateGameObjectWithHideFlags("Audio Preview", HideFlags.HideAndDontSave, typeof(AudioSource)).GetComponent<AudioSource>();   
            
            _AudioPreset = target as AudioSourcePreset;
        }

        private void OnDisable() 
        {
            DestroyImmediate(_PreviewAudioSource.gameObject);    
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if(_PreviewAudioSource.isPlaying)
            {
                if(GUILayout.Button("Stop"))
                    _PreviewAudioSource.Stop();
            }

            else if(GUILayout.Button("Preview"))
            {
                _PreviewAudioSource.SetPreset(_AudioPreset);
                _PreviewAudioSource.Play();
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}