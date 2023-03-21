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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightTracking), Member = "MaybeAdd")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(LightTracking), Member = "OnEnable")]
	[CalledBy(Type = typeof(LightTracking), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightingManager), Member = "Add")]
	private void MaybeAdd(bool areWeStarting)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightingManager), Member = "Remove")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
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
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	public void MaybeUpdateForCinematic(bool isCinematicActive)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsLightEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	public void EnableLight(bool state)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[Calls(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
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

	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CallsUnknownMethods(Count = 2)]
	public float GetLightRange()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool IsDirectional()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallsUnknownMethods(Count = 2)]
	public float GetLightIntensity()
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetLightIntensity(float intensity)
	{
	}

	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Start")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLightIntensity()
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[CalledBy(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[CalledBy(Type = typeof(LightTracking), Member = "GetLightRange")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CalledBy(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableLight")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CalledBy(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[CalledBy(Type = typeof(LightTracking), Member = "Awake")]
	private Light GetLightComponent()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CalledBy(Type = typeof(LightTracking), Member = "Awake")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CallsUnknownMethods(Count = 2)]
	private bool IsLightingWeaponCamera()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public LightTracking()
	{
	}
}
