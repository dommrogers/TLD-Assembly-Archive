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
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightColor")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	private void UpdateLightsForFP_Part1(Vector3 playerPos)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	private void UpdateLightsForFP_Part2(Vector3 playerPos)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(LightTracking), Member = "MaybeAdd")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetType")]
	public static void Add(LightTracking light)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(LightTracking), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 9)]
	public static void Remove(LightTracking light)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static void RemoveAll()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 11)]
	public static void OnLevelLoadComplete()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	public static void TransformLightPositions(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static void InverseTransformLightPositions(Transform t)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	public static void TransformFpsLightPositions(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	public static void InverseTransformFpsLightPositions(Transform t)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLightingStrength(Color value)
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "OnDisable")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static void SetLightingStrengthDefault()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightingManager()
	{
	}
}
