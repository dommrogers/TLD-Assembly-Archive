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
	[Calls(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CalledBy(Type = typeof(LightTracking), Member = "Start")]
	[CalledBy(Type = typeof(LightTracking), Member = "OnEnable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(LightingManager), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybeAdd(bool areWeStarting)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LightingManager), Member = "Remove")]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformLightPositions")]
	[CalledBy(Type = typeof(LightingManager), Member = "TransformFpsLightPositions")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public void StorePositionAndRotation()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "TransformLightPositions")]
	[CalledBy(Type = typeof(LightingManager), Member = "InverseTransformFpsLightPositions")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void RestorePositionAndRotation()
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[CallsUnknownMethods(Count = 1)]
	public void MaybeUpdateForCinematic(bool isCinematicActive)
	{
	}

	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsLightEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsUnknownMethods(Count = 2)]
	public void EnableLight(bool state)
	{
	}

	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void EnableWeaponCameraLighting(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool WasLightingWeaponCamera()
	{
		return false;
	}

	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part1")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsUnknownMethods(Count = 2)]
	public float GetLightRange()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsDirectional()
	{
		return false;
	}

	[CalledBy(Type = typeof(LightRandomIntensity), Member = "GetIntensity")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsUnknownMethods(Count = 2)]
	public float GetLightIntensity()
	{
		return 0f;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void SetLightIntensity(float intensity)
	{
	}

	[CalledBy(Type = typeof(KeroseneLampIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Start")]
	[CalledBy(Type = typeof(LightRandomIntensity), Member = "Update")]
	[CalledBy(Type = typeof(LightTracking), Member = "MaybeUpdateForCinematic")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateLightIntensity()
	{
	}

	[CalledBy(Type = typeof(LightTracking), Member = "Awake")]
	[CalledBy(Type = typeof(LightTracking), Member = "IsLightEnabled")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableLight")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CalledBy(Type = typeof(LightTracking), Member = "GetLightRange")]
	[CalledBy(Type = typeof(LightTracking), Member = "GetLightIntensity")]
	[CalledBy(Type = typeof(LightTracking), Member = "UpdateLightIntensity")]
	[CalledBy(Type = typeof(LightTracking), Member = "IsLightingWeaponCamera")]
	[CalledBy(Type = typeof(LightingManager), Member = "Update")]
	[CalledBy(Type = typeof(LightingManager), Member = "UpdateLightsForFP_Part2")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private Light GetLightComponent()
	{
		return null;
	}

	[CalledBy(Type = typeof(LightTracking), Member = "Awake")]
	[CalledBy(Type = typeof(LightTracking), Member = "EnableWeaponCameraLighting")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LightTracking), Member = "GetLightComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsLightingWeaponCamera()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public LightTracking()
	{
	}
}
