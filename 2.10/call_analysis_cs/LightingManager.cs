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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[Calls(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightIntensity")]
	[Calls(Type = typeof(PlayerManager), Member = "GetHeldLightColor")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateLightsForFP_Part1(Vector3 playerPos)
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightRange")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateLightsForFP_Part2(Vector3 playerPos)
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "MaybeAdd")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 9)]
	public static void Add(LightTracking light)
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "OnDisable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static void Remove(LightTracking light)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void RemoveAll()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(LightingManager), Member = "SetLightingStrengthDefault")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public static void OnLevelLoadComplete()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void TransformLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallsUnknownMethods(Count = 16)]
	public static void InverseTransformLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "StorePositionAndRotation")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	public static void TransformFpsLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "RenderScene")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "RestorePositionAndRotation")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void InverseTransformFpsLightPositions(Transform t)
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[CalledBy(Type = typeof(InteriorLightingManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SetLightingStrength(Color value)
	{
	}

	[CalledBy(Type = typeof(DarkLightingManager), Member = "OnDisable")]
	[CalledBy(Type = typeof(LightingManager), Member = "OnLevelLoadComplete")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
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
