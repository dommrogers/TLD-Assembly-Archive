using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightTracking : MonoBehaviour
{
	private const float CINEMATIC_FADE_TIME = 0.5f;

	private const float CINEMATIC_FADE_MIN_STRENGTH = 0f;

	public static bool s_FadePlayerLightsDurignCinematics;

	public Light m_LightComponent;

	public Vector3 m_WorldPosition;

	public bool m_StaticPosition;

	private Vector3 m_OriginalPosition;

	private Quaternion m_OriginalRotation;

	private bool m_Started;

	private GearItem m_AssociatedGearItem;

	private float m_BaseLightIntensity;

	private float m_CinematicFadeStrength;

	private bool m_WasLightingWeaponCamera;

	private bool m_IsDirectional;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightTracking), Member = "MaybeAdd")]
	private void Start()
	{
	}

	[Calls(Type = typeof(LightTracking), Member = "MaybeAdd")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LightingManager), Member = "Add")]
	[CalledBy(Type = typeof(LightTracking), Member = "Start")]
	[CalledBy(Type = typeof(LightTracking), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 9)]
	private void MaybeAdd(bool areWeStarting)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightingManager), Member = "Remove")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	public void StorePositionAndRotation()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(LightingManager), Member = "TransformLightPositions")]
	[CalledBy(Type = typeof(LightingManager), Member = "TransformLightPositions")]
	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[CallsUnknownMethods(Count = 5)]
	public void RestorePositionAndRotation()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void MaybeUpdateForCinematic(bool isCinematicActive)
	{
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsLightEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	public void EnableLight(bool state)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	public void EnableWeaponCameraLighting(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasLightingWeaponCamera()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	public float GetLightRange()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsDirectional()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	[CallsUnknownMethods(Count = 2)]
	public float GetLightIntensity()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void SetLightIntensity(float intensity)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[CalledBy(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Start")]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	private void UpdateLightIntensity()
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[CalledBy(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[CalledBy(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[CalledBy(Type = typeof(LightTracking), Member = "GetLightRange")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CalledBy(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[CalledBy(Type = typeof(LightTracking), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableLight")]
	private Light GetLightComponent()
	{
		return null;
	}

	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CalledBy(Type = typeof(LightTracking), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	private bool IsLightingWeaponCamera()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightTracking()
	{
	}
}
