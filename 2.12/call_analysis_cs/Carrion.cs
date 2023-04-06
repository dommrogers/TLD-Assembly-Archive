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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public bool ShouldDisperseGlobal(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private static void UpdateAllCarrionPositions()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void StaggeredUpdateCarrions(int start, int endExclusive)
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Carrion), Member = "Destroy")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Carrion), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public void StaggeredUpdateCarrion()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 34)]
	public void Create()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	public void Destroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ForceDisperse(bool enable)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SetCarrionActive")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	[CallerCount(Count = 4)]
	public bool HasDispersed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsTooDark()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldDisperseLocal()
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdatePosition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Carrion()
	{
	}
}