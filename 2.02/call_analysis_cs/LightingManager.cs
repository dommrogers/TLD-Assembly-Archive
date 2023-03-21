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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightColor")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 19)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateLightsForFP_Part1(Vector3 playerPos)
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateLightsForFP_Part2(Vector3 playerPos)
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "MaybeAdd")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public static void Add(LightTracking light)
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public static void Remove(LightTracking light)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void RemoveAll()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(GameObject), Member = "get_scene")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public static void OnLevelLoadComplete()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void TransformLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "Inverse")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 22)]
	public static void InverseTransformLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public static void TransformFpsLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void InverseTransformFpsLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLightingStrength(Color value)
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrength")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetLightingStrengthDefault()
	{
	}

	[CalledBy(Type = typeof(HUDManager), Member = "UpdateDebugLines")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
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
