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
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "GetListenerIds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ResetListenersToDefault")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AddListener")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public void SetUseDefaultListeners(bool useDefault)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void Init(AkGameObj akGameObj)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "Add")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "AddListener")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public override bool Add(AkAudioListener listener)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "Remove")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public override bool Remove(AkAudioListener listener)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "GetListenerIds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ResetListenersToDefault")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Refresh(GameObject gameObject)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkGameObjListenerList()
	{
	}
}
