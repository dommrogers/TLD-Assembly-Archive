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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	private void UpdateLightsForFP_Part1(Vector3 playerPos)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateLightsForFP_Part2(Vector3 playerPos)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(LightTracking), Member = "MaybeAdd")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static void Add(LightTracking light)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
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
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	public static void OnLevelLoadComplete()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	public static void TransformLightPositions(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public static void InverseTransformLightPositions(Transform t)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallsUnknownMethods(Count = 8)]
	public static void TransformFpsLightPositions(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static void InverseTransformFpsLightPositions(Transform t)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	public static void SetLightingStrength(Color value)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLightingStrengthDefault()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string GetDebugText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public LightingManager()
	{
	}
}
