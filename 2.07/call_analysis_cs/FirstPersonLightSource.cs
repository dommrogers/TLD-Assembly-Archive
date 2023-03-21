using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstPersonLightSource : MonoBehaviour
{
	public GameObject m_FXGameObject;

	public GameObject m_TurningOnFX;

	public Light m_LightIndoor;

	public Light m_LightOutdoor;

	public GameObject m_LightPosition;

	public GameObject m_LightContainer;

	public float m_LightCollisionRadius;

	public GameObject[] m_MeshObjectsFresh;

	public GameObject[] m_MeshObjectsUsed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "UpdateLightPosition")]
	public void LateUpdate()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "LateUpdate")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	private void UpdateLightPosition()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	public void TurnOnEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	public void DisableEffectsObject()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void SetFresh(bool fresh)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	private void TurnOffParticleSystems(Transform parent, bool hardStop)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstPersonLightSource()
	{
	}
}
