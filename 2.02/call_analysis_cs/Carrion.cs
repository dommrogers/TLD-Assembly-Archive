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
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public bool ShouldDisperseGlobal(float radius)
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "UpdatePosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static void UpdateAllCarrionPositions()
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateAll()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private static void StaggeredUpdateCarrions(int start, int endExclusive)
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Carrion), Member = "Destroy")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(Carrion), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 19)]
	public void StaggeredUpdateCarrion()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 24)]
	[CallsUnknownMethods(Count = 49)]
	public void Create()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool HasDispersed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private bool IsTooDark()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool ShouldDisperseLocal()
	{
		return false;
	}

	[CalledBy(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 46)]
	private void UpdatePosition()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public Carrion()
	{
	}
}
