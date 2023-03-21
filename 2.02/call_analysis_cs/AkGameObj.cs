using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AkGameObj : MonoBehaviour
{
	public static bool s_DebugBuckets;

	private static List<AkGameObj>[] s_UpdateBuckets;

	private static float[] s_BucketRanges;

	private static float[] s_BucketSqrRanges;

	private static int[] s_NumToProcessPerBucketUpdate;

	private static int[] s_BucketUpdateIndex;

	private GameObject m_CachedGameObject;

	private Transform m_CachedTransform;

	private int m_BucketIndex;

	private AkGameObjListenerList m_listeners;

	public bool isEnvironmentAware;

	private bool isStaticObject;

	private Collider m_Collider;

	private AkGameObjEnvironmentData m_envData;

	private AkGameObjPositionData m_posData;

	public AkGameObjPositionOffsetData m_positionOffsetData;

	public bool isRegistered;

	private AkGameObjPosOffsetData m_posOffsetData;

	private const int AK_NUM_LISTENERS = 8;

	private int listenerMask;

	public bool IsUsingDefaultListeners
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public List<AkAudioListener> ListenerList
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "OnEnable")]
	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void MaybeInitializeBuckets()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_audio_logbuckets")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(DebugUtils), Member = "GetGameObjectPath")]
	public static void LogAudioBucket()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallsUnknownMethods(Count = 24)]
	public static string GetDebugText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[Calls(Type = typeof(AkGameObj), Member = "MigrateObjectsBetweenBuckets")]
	[Calls(Type = typeof(AkGameObj), Member = "UpdateObjPositionsForBucket")]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeInitializeBuckets")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkGameObj), Member = "UpdateAuxValuesForBucket")]
	public static void UpdateAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[CallsUnknownMethods(Count = 6)]
	private static void UpdateAuxValuesForBucket(int bucketIndex)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeUpdateObjectPosition")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static void UpdateObjPositionsForBucket(int bucketIndex)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkGameObj), Member = "RemoveObjectFromBucket")]
	[Calls(Type = typeof(AkGameObj), Member = "AddObjectToBucket")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	private static void MigrateObjectsBetweenBuckets(int bucketIndex)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnDisable")]
	[CalledBy(Type = typeof(AkGameObj), Member = "MigrateObjectsBetweenBuckets")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private static void RemoveObjectFromBucket(AkGameObj obj, int bucketIndex)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(AkGameObj), Member = "MigrateObjectsBetweenBuckets")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnEnable")]
	private static void AddObjectToBucket(AkGameObj obj, int bucketIndex)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAuxValuesForBucket")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ResetListenersToDefault")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "GetListenerIds")]
	private void MaybeUpdateAuxValues()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateObjPositionsForBucket")]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeUpdateObjectPosition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void AddListener(AkAudioListener listener)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void RemoveListener(AkAudioListener listener)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CalledBy(Type = typeof(AkAudioListener), Member = "Awake")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RegisterGameObj")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	public AKRESULT Register()
	{
		return default(AKRESULT);
	}

	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsRenderObjectInstanceChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObjListenerList), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = ".ctor")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void CheckStaticStatus()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeInitializeBuckets")]
	[Calls(Type = typeof(AkGameObj), Member = "AddObjectToBucket")]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(AkGameObj), Member = "RemoveObjectFromBucket")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[Calls(Type = typeof(AkSoundEngine), Member = "UnregisterGameObj")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 7)]
	public virtual Vector3 GetPosition()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 1)]
	public virtual Vector3 GetForward()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 1)]
	public virtual Vector3 GetUpward()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[CallerCount(Count = 0)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "Reset")]
	[CallsUnknownMethods(Count = 1)]
	private void LevelLoadedCallback(Scene s, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkGameObjListenerList), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public AkGameObj()
	{
	}
}
