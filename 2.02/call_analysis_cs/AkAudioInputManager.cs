using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AK.Wwise;
using AOT;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class AkAudioInputManager
{
	public delegate void AudioFormatDelegate(uint playingID, AkAudioFormat format);

	public delegate void AudioFormatInteropDelegate(uint playingID, IntPtr format);

	public delegate bool AudioSamplesDelegate(uint playingID, uint channelIndex, float[] samples);

	public delegate bool AudioSamplesInteropDelegate(uint playingID, [In][Out] float[] samples, uint channelIndex, uint frames);

	private static bool initialized;

	private static readonly Dictionary<uint, AudioSamplesDelegate> audioSamplesDelegates;

	private static readonly Dictionary<uint, AudioFormatDelegate> audioFormatDelegates;

	private static readonly AkAudioFormat audioFormat;

	private static readonly AudioSamplesInteropDelegate audioSamplesDelegate;

	private static readonly AudioFormatInteropDelegate audioFormatDelegate;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(AK.Wwise.Event), Member = "Post")]
	[Calls(Type = typeof(AkAudioInputManager), Member = "AddPlayingID")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkAudioInputManager), Member = "TryInitialize")]
	public static uint PostAudioInputEvent(AK.Wwise.Event akEvent, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null)
	{
		return default(uint);
	}

	[Calls(Type = typeof(AkAudioInputManager), Member = "AddPlayingID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkAudioInputManager), Member = "TryInitialize")]
	public static uint PostAudioInputEvent(uint akEventID, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkAudioInputManager), Member = "TryInitialize")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[Calls(Type = typeof(AkAudioInputManager), Member = "AddPlayingID")]
	[CallsUnknownMethods(Count = 7)]
	public static uint PostAudioInputEvent(string akEventName, GameObject gameObject, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate = null)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(AudioSamplesDelegate), Member = "Invoke")]
	[CallerCount(Count = 0)]
	[AOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static bool InternalAudioSamplesDelegate(uint playingID, float[] samples, uint channelIndex, uint frames)
	{
		return default(bool);
	}

	[AOT.MonoPInvokeCallback(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private static void InternalAudioFormatDelegate(uint playingID, IntPtr format)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CallsUnknownMethods(Count = 3)]
	private static void TryInitialize()
	{
	}

	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	private static void AddPlayingID(uint playingID, AudioSamplesDelegate sampleDelegate, AudioFormatDelegate formatDelegate)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[Calls(Type = typeof(AkEventCallbackInfo), Member = "get_playingID")]
	[CallsUnknownMethods(Count = 2)]
	private static void EventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo)
	{
	}
}
