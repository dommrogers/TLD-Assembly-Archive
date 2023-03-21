using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Carrion : MonoBehaviour
{
	public GameObject m_Prefab;

	public int m_MinFlockSize;

	public int m_MaxFlockSize;

	public float m_LodDistance;

	public float m_FlyDistanceAboveTarget;

	public string m_LoopAudio;

	public static List<Carrion> m_CarrionObjects;

	public static bool s_StaggeredUpdateEnabled;

	private float m_FormationValidHeight;

	private GameObject m_Instance;

	private const float m_DisperseVerticalSpeed = 2f;

	private uint m_LoopAudioID;

	private bool m_ForceDisperse;

	private bool m_ShouldDisperse;

	private List<Carrion> m_NearbyCarrions;

	private static int s_CurrentIndex;

	private static int s_NumProcessPerFrame;

	private bool m_SkipPositionUpdateRequested;

	private const float CARRION_NO_OVERLAP_RADIUS = 30f;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldDisperseGlobal(float radius)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Carrion), Member = "UpdatePosition")]
	private static void UpdateAllCarrionPositions()
	{
	}

	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	public static void UpdateCarrions()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static void StaggeredUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateAll()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private static void StaggeredUpdateCarrions(int start, int endExclusive)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "Create")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Carrion), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	public void StaggeredUpdateCarrion()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public void Create()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	public void Destroy()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ForceDisperse(bool enable)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SetCarrionActive")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	public bool HasDispersed()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	private bool IsTooDark()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	private bool ShouldDisperseLocal()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdatePosition()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Carrion()
	{
	}
}
