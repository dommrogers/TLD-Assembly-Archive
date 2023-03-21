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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool ShouldDisperseGlobal(float radius)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdatePosition")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 3)]
	private static void UpdateAllCarrionPositions()
	{
	}

	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateCarrions()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private static void StaggeredUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	private static void UpdateAll()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private static void StaggeredUpdateCarrions(int start, int endExclusive)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "Create")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Carrion), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	public void StaggeredUpdateCarrion()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 34)]
	public void Create()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "StopPlayingID")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	public void Destroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void ForceDisperse(bool enable)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SetCarrionActive")]
	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	public bool HasDispersed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(TimeOfDay), Member = "IsDawn")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDusk")]
	private bool IsTooDark()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[CallsUnknownMethods(Count = 3)]
	private bool ShouldDisperseLocal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 1)]
	private void UpdatePosition()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public Carrion()
	{
	}
}
