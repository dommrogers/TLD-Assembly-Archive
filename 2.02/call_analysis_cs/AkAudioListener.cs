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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(DefaultListenerList), Member = "Add")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Add")]
		[CallsUnknownMethods(Count = 12)]
		public virtual bool Add(AkAudioListener listener)
		{
			return default(bool);
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Remove")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 6)]
		[CalledBy(Type = typeof(DefaultListenerList), Member = "Remove")]
		public virtual bool Remove(AkAudioListener listener)
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "Refresh")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "Copy")]
		[CalledBy(Type = typeof(DefaultListenerList), Member = "Refresh")]
		[CalledBy(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
		[CalledBy(Type = typeof(AkGameObjListenerList), Member = "SetUseDefaultListeners")]
		[CallsUnknownMethods(Count = 2)]
		public ulong[] GetListenerIds()
		{
			return null;
		}

		[CalledBy(Type = typeof(AkGameObjListenerList), Member = ".ctor")]
		[CallsUnknownMethods(Count = 19)]
		[CalledBy(Type = typeof(DefaultListenerList), Member = ".ctor")]
		[CalledBy(Type = typeof(AkAudioListener), Member = ".cctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		public BaseListenerList()
		{
		}
	}

	public class DefaultListenerList : BaseListenerList
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(BaseListenerList), Member = "Add")]
		[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
		[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
		[CallsUnknownMethods(Count = 3)]
		public override bool Add(AkAudioListener listener)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
		[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
		[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseListenerList), Member = "Remove")]
		public override bool Remove(AkAudioListener listener)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(BaseListenerList), Member = "GetListenerIds")]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void StartListeningToEmitter(AkGameObj emitter)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void StopListeningToEmitter(AkGameObj emitter)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public void SetIsDefaultListener(bool isDefault)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public ulong GetAkGameObjectID()
	{
		return default(ulong);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 2)]
	public void Migrate14()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public AkAudioListener()
	{
	}
}
