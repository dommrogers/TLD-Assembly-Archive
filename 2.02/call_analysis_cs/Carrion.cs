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
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Carrion), Member = "HasDispersed")]
	public bool ShouldDisperseGlobal(float radius)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Carrion), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	private static void UpdateAllCarrionPositions()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void UpdateCarrions()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private static void StaggeredUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[CallsUnknownMethods(Count = 1)]
	private static void UpdateAll()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAll")]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateCarrions")]
	[Calls(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static void StaggeredUpdateCarrions(int start, int endExclusive)
	{
	}

	[Calls(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	[Calls(Type = typeof(Utils), Member = "DistanceToMainCamera")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Carrion), Member = "Create")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(Carrion), Member = "Destroy")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrions")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void StaggeredUpdateCarrion()
	{
	}

	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 49)]
	[Calls(Type = typeof(FlyOver), Member = "TryGetClearFlightHeight")]
	[CallsDeduplicatedMethods(Count = 26)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	public void Create()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AkSoundEngine), Member = "StopPlayingID")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CallsUnknownMethods(Count = 2)]
	public void Destroy()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void ForceDisperse(bool enable)
	{
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "UpdateCarrion")]
	[CalledBy(Type = typeof(Carrion), Member = "ShouldDisperseGlobal")]
	[CalledBy(Type = typeof(CarcassSite), Member = "SetCarrionActive")]
	[CalledBy(Type = typeof(CarcassSite), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public bool HasDispersed()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDawn")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsDusk")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	private bool IsTooDark()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "IsSnowing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private bool ShouldDisperseLocal()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(Carrion), Member = "UpdateAllCarrionPositions")]
	[Calls(Type = typeof(GameAudioManager), Member = "SetAudioSourceTransform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private void UpdatePosition()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Carrion()
	{
	}
}
