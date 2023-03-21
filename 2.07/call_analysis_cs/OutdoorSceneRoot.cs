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
	private sealed class _003CStart_003Ed__10 : IDisposable, IEnumerator<object>, IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OutdoorSceneRoot _003C_003E4__this;

		private int _003CitemCount_003E5__2;

		private int _003CcurrentIndex_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CStart_003Ed__10(int _003C_003E1__state)
		{
		}

		[CallerCount(Count = 6)]
		[DebuggerHidden]
		[DeduplicatedMethod]
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

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	public void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public IEnumerator Start()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private static void DeActivate(GameObject masterObject)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	private void TrySetGroundLayerRecursive(GameObject go)
	{
	}

	[Calls(Type = typeof(OutdoorSceneRoot), Member = "MoveToCache")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "LevelLoadedCallback")]
	[CalledBy(Type = typeof(_003CStart_003Ed__10), Member = "MoveNext")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
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

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void SpawnOrDecachePrefabs(int start, int endExclusive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "DecachePrefabs")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "Awake")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetSceneName()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	private static void MaybeClearCache(string nextScene)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "MaybeClearCache")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	public static void OnSceneUnload(string nextScene)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public OutdoorSceneRoot()
	{
	}
}
