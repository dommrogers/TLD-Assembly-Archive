using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkAudioListener : MonoBehaviour
{
	public class BaseListenerList
	{
		private readonly List<ulong> listenerIdList;

		private readonly List<AkAudioListener> listenerList;

		protected bool changed;

		public List<AkAudioListener> ListenerList
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		[CalledBy(Type = typeof(DefaultListenerList), Member = "Add")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Add")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 12)]
		public virtual bool Add(AkAudioListener listener)
		{
			return false;
		}

		[CalledBy(Type = typeof(DefaultListenerList), Member = "Remove")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Remove")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(List<>), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 8)]
		public virtual bool Remove(AkAudioListener listener)
		{
			return false;
		}

		[CalledBy(Type = typeof(DefaultListenerList), Member = "Refresh")]
		[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "SetUseDefaultListeners")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Refresh")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public ulong[] GetListenerIds()
		{
			return null;
		}

		[CalledBy(Type = typeof(AkAudioListener), Member = ".cctor")]
		[CalledBy(Type = typeof(DefaultListenerList), Member = ".ctor")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = ".ctor")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 19)]
		public BaseListenerList()
		{
		}
	}

	public class DefaultListenerList : BaseListenerList
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListenerList), Member = "Add")]
		[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
		[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		public override bool Add(AkAudioListener listener)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListenerList), Member = "Remove")]
		[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
		[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		public override bool Remove(AkAudioListener listener)
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListenerList), Member = "GetListenerIds")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		internal void Refresh()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListenerList), Member = ".ctor")]
		public DefaultListenerList()
		{
		}
	}

	private static readonly DefaultListenerList defaultListeners;

	private ulong akGameObjectID;

	private List<AkGameObj> EmittersToStartListeningTo;

	private List<AkGameObj> EmittersToStopListeningTo;

	public bool isDefaultListener;

	public int listenerId;

	public static DefaultListenerList DefaultListeners
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StartListeningToEmitter(AkGameObj emitter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void StopListeningToEmitter(AkGameObj emitter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void SetIsDefaultListener(bool isDefault)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public ulong GetAkGameObjectID()
	{
		return 0uL;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Migrate14()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public AkAudioListener()
	{
	}
}
