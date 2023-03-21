using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutdoorSceneRoot : MonoBehaviour
{
	private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OutdoorSceneRoot _003C_003E4__this;

		private int _003CitemCount_003E5__2;

		private int _003CcurrentIndex_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(Count = 44)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 44)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OutdoorSceneRoot), Member = "DecachePrefabs")]
		[Calls(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 5)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public List<PrefabInstantiateData> m_CachedPrefabs;

	public static bool m_CacheEnabled;

	public static bool m_SpawnCompleted;

	private bool m_InCache;

	private GameObject m_MasterObject;

	private static int m_NumProcessPerFrame;

	private static bool m_StaggeredSpawnAtStart;

	private static Dictionary<string, GameObject> m_MasterObjectDict;

	private const string m_MasterObjectPrefix = "Master_";

	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	public void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallsUnknownMethods(Count = 8)]
	private static void DeActivate(GameObject masterObject)
	{
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	private void TrySetGroundLayerRecursive(GameObject go)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "LevelLoadedCallback")]
	[CalledBy(Type = typeof(_003CStart_003Ed__10), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "MoveToCache")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	private void SpawnPrefabs(int start, int endExclusive)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(_003CStart_003Ed__10), Member = "MoveNext")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "LevelLoadedCallback")]
	[CallsUnknownMethods(Count = 10)]
	private void DecachePrefabs(int start, int endExclusive)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SpawnOrDecachePrefabs(int start, int endExclusive)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "DecachePrefabs")]
	[CallerCount(Count = 0)]
	private void LevelLoadedCallback(Scene s, LoadSceneMode mode)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CallsUnknownMethods(Count = 2)]
	private void MoveToCache(Transform prefab)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "Awake")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	private static string GetSceneName()
	{
		return null;
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	private static void MaybeClearCache(string nextScene)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "MaybeClearCache")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "DeActivate")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	public static void OnSceneUnload(string nextScene)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public OutdoorSceneRoot()
	{
	}
}
