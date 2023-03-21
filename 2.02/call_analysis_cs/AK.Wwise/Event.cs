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
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
	[CallerCount(Count = 2)]
	private void VerifyPlayingID(uint playingId)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CalledBy(Type = typeof(AkEvent), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkRoom), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AmbientTracker), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public uint Post(GameObject gameObject)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public uint Post(GameObject gameObject, CallbackFlags flags, AkCallbackManager.EventCallback callback, object cookie = null)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "retriggerEvent")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "playEvent")]
	[CalledBy(Type = typeof(AkEvent), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkAmbient), Member = "HandleEvent")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PostEvent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(AkAudioInputManager), Member = "PostAudioInputEvent")]
	public uint Post(GameObject gameObject, uint flags, AkCallbackManager.EventCallback callback, object cookie = null)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "ExecuteAction")]
	public void Stop(GameObject gameObject, int transitionDuration = 0, AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
	{
	}

	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeIn")]
	[CalledBy(Type = typeof(AmbientTracker), Member = "Stop")]
	[CalledBy(Type = typeof(Event), Member = "Stop")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "stopEvent")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeOut")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "triggerFadeIn")]
	[CalledBy(Type = typeof(AkEventPlayableBehavior), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AkEvent), Member = "Stop")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CalledBy(Type = typeof(AkEvent), Member = "Stop")]
	[CalledBy(Type = typeof(AkAmbient), Member = "HandleEvent")]
	[CalledBy(Type = typeof(AkEvent), Member = "HandleEvent")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	public void ExecuteAction(GameObject gameObject, AkActionOnEventType actionOnEventType, int transitionDuration, AkCurveInterpolation curveInterpolation)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEnginePINVOKE), Member = "CSharp_AkMIDIPost_PostOnEvent")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public void PostMIDI(GameObject gameObject, AkMIDIPostArray array, int count)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsUnknownMethods(Count = 2)]
	public void StopMIDI(GameObject gameObject)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void StopMIDI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Event()
	{
	}
}
