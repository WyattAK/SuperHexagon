using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	// Holds all sounds used in game (theme song, collisions, level complete)
	public Sound[] sounds;

	public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {

		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);

		foreach (Sound s in sounds)
		{
			// Enables controls in the Unity Editor for specific parameters of each sound 
			// Volume, pitch, clip length, and looping (on or off)
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
		}
    }

	//Plays theme music on game start with looping enabled
	void Start ()
	{
		Play("Theme");
	}

	public void Play(string name)
	{
		Sound s = Array.Find(sounds, sound => sound.name == name);
		if (s == null)
			return;
		s.source.Play();
	}
}
