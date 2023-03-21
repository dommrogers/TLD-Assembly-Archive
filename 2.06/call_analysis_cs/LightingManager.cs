using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightingManager : MonoBehaviour
{
	private static List<LightTracking> m_Lights;

	private static List<LightTracking> m_LightsForFp;

	private static List<LightTracking> m_FpsLights;

	private static List<LightTracking> m_SelectedWorldLightsForFp;

	private static bool m_LevelLoadComplete;

	private static string[] m_NonStaticComponentList;

	public static float m_LightIntensityOnPlayer;

	public static Color m_LightColorOnPlayer;

	private static readonly int m_LightingStrengthShaderId;

	private static readonly Color m_DefaultLightingStrength;

	public static bool s_FilterWorldLightForFP;

	public static bool s_DebugFPLights;

	private Vector3 m_LastPlayerPos;

	private float m_SqrRefreshLightsForFpThreshold;

	private float m_UpdateLightForFpDeltaTime;

	private float m_UpdateLightForFpAccumulatedDeltaTime;

	private float m_SqrPlayerWithItemRadius;

	private string[] m_NonStaticComponents;

	private static int m_LightsForFpCount;

	private static int m_LightCount;

	private static int m_SelectedWorldLightsForFpCount;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightColor")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	private void UpdateLightsForFP_Part1(Vector3 playerPos)
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateLightsForFP_Part2(Vector3 playerPos)
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "MaybeAdd")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	public static void Add(LightTracking light)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(LightTracking), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 3)]
	public static void Remove(LightTracking light)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void RemoveAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public static void OnLevelLoadComplete()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void TransformLightPositions(Transform t)
	{
	}

	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public static void InverseTransformLightPositions(Transform t)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	public static void TransformFpsLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	public static void InverseTransformFpsLightPositions(Transform t)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLightingStrength(Color value)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	public static void SetLightingStrengthDefault()
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public LightingManager()
	{
	}
}
