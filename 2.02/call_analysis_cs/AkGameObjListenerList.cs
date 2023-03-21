using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AkGameObjListenerList : AkAudioListener.BaseListenerList
{
	[NonSerialized]
	private AkGameObj akGameObj;

	public List<AkAudioListener> initialListenerList;

	public bool useDefaultListeners;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "GetListenerIds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ResetListenersToDefault")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AddListener")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	public void SetUseDefaultListeners(bool useDefault)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public void Init(AkGameObj akGameObj)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "Add")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AddListener")]
	[CallsUnknownMethods(Count = 4)]
	public override bool Add(AkAudioListener listener)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	public override bool Remove(AkAudioListener listener)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "GetListenerIds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ResetListenersToDefault")]
	public void Refresh(GameObject gameObject)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = ".ctor")]
	[CalledBy(Type = typeof(AkGameObj), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AkGameObjListenerList()
	{
	}
}
