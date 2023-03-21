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
			return false;
		}
	}

	public List<AkAudioListener> ListenerList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public static void MaybeInitializeBuckets()
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_audio_logbuckets")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DebugUtils), Member = "GetGameObjectPath")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static void LogAudioBucket()
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	public static string GetDebugText()
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeInitializeBuckets")]
	[Calls(Type = typeof(AkGameObj), Member = "UpdateAuxValuesForBucket")]
	[Calls(Type = typeof(AkGameObj), Member = "UpdateObjPositionsForBucket")]
	[Calls(Type = typeof(AkGameObj), Member = "MigrateObjectsBetweenBuckets")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void UpdateAll()
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeUpdateAuxValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private static void UpdateAuxValuesForBucket(int bucketIndex)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeUpdateObjectPosition")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 23)]
	private static void UpdateObjPositionsForBucket(int bucketIndex)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkGameObj), Member = "RemoveObjectFromBucket")]
	[Calls(Type = typeof(AkGameObj), Member = "AddObjectToBucket")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static void MigrateObjectsBetweenBuckets(int bucketIndex)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "MigrateObjectsBetweenBuckets")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static void RemoveObjectFromBucket(AkGameObj obj, int bucketIndex)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "MigrateObjectsBetweenBuckets")]
	[CalledBy(Type = typeof(AkGameObj), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static void AddObjectToBucket(AkGameObj obj, int bucketIndex)
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateAuxValuesForBucket")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AkAudioListener.BaseListenerList), Member = "GetListenerIds")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetListeners")]
	[Calls(Type = typeof(AkSoundEngine), Member = "ResetListenersToDefault")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void MaybeUpdateAuxValues()
	{
	}

	[CalledBy(Type = typeof(AkGameObj), Member = "UpdateObjPositionsForBucket")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CalledBy(Type = typeof(GameAudioManager), Member = "GetSoundEmitterFromGameObject")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CalledBy(Type = typeof(GameAudioManager), Member = "EnsureEmitterIsRegistered")]
	[CalledBy(Type = typeof(AkAudioListener), Member = "Awake")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(AkSoundEngine), Member = "RegisterGameObj")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public AKRESULT Register()
	{
		return default(AKRESULT);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AkGameObj), Member = "Register")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetObjectPosition")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "UpdateAuxSend")]
	[Calls(Type = typeof(AkGameObjListenerList), Member = "Init")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsRenderObjectInstanceChild")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 38)]
	private void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	private void CheckStaticStatus()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObj), Member = "MaybeInitializeBuckets")]
	[Calls(Type = typeof(AkGameObj), Member = "AddObjectToBucket")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObj), Member = "RemoveObjectFromBucket")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(AkTriggerHandler), Member = "DoDestroy")]
	[Calls(Type = typeof(AkSoundEngine), Member = "IsInitialized")]
	[Calls(Type = typeof(AkSoundEngine), Member = "UnregisterGameObj")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 18)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "AddAkEnvironment")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "RemoveAkEnvironment")]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjEnvironmentData), Member = "Reset")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LevelLoadedCallback(Scene s, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AkGameObjListenerList), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public AkGameObj()
	{
	}
}
