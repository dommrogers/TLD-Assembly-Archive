using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 35)]
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
		[CallerCount(Count = 7)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OutdoorSceneRoot), Member = "DecachePrefabs")]
		[Calls(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "add_sceneLoaded")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 20)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public IEnumerator Start()
	{
		return null;
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	private static void DeActivate(GameObject masterObject)
	{
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	private void TrySetGroundLayerRecursive(GameObject go)
	{
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "LevelLoadedCallback")]
	[CalledBy(Type = typeof(_003CStart_003Ed__10), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "TrySetGroundLayerRecursive")]
	[Calls(Type = typeof(Terrain), Member = "set_drawInstanced")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "MoveToCache")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	private void SpawnPrefabs(int start, int endExclusive)
	{
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "LevelLoadedCallback")]
	[CalledBy(Type = typeof(_003CStart_003Ed__10), Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 18)]
	private void DecachePrefabs(int start, int endExclusive)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void SpawnOrDecachePrefabs(int start, int endExclusive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "DecachePrefabs")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LevelLoadedCallback(Scene s, LoadSceneMode mode)
	{
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "SpawnPrefabs")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void MoveToCache(Transform prefab)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "remove_sceneLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "Awake")]
	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetSceneName()
	{
		return null;
	}

	[CalledBy(Type = typeof(OutdoorSceneRoot), Member = "OnSceneUnload")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsOutDoorsScene")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private static void MaybeClearCache(string nextScene)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadSceneAsynchronously")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "MaybeClearCache")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "GetSceneName")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(OutdoorSceneRoot), Member = "DeActivate")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void OnSceneUnload(string nextScene)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public OutdoorSceneRoot()
	{
	}
}
