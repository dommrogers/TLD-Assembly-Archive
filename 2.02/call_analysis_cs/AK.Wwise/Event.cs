using System;
using Audio.SimpleAudio;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
public class Event : BaseType
{
	public WwiseEventReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 9)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override WwiseObjectType WwiseObjectType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void VerifyPlayingID(uint playingId)
	{
	}

	[CalledBy(Type = typeof(AkEvent), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkRoom), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public uint Post(GameObject gameObject)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public uint Post(GameObject gameObject, CallbackFlags flags, AkCallbackManager.EventCallback callback, object cookie = null)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	[CalledBy(Type = typeof(AkAmbient), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkEvent), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "playEvent")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "retriggerEvent")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public uint Post(GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie = null)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "ExecuteAction")]
	public void Stop(GameObject gameObject, int transitionDuration = 0, AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
	{
	}

	[CalledBy(Type = typeof(AkAmbient), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkEvent), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkEvent), Member = "Stop")]
	[CalledBy(Type = typeof(AkEvent), Member = "Stop")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeIn")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeOut")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "stopEvent")]
	[CalledBy(Type = typeof(Event), Member = "Stop")]
	[CalledBy(Type = typeof(AmbientTracker), Member = "Stop")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void ExecuteAction(GameObject gameObject, AkActionOnEventType actionOnEventType, int transitionDuration, AkCurveInterpolation curveInterpolation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array, int count)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void StopMIDI(GameObject gameObject)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public void StopMIDI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Event()
	{
	}
}
