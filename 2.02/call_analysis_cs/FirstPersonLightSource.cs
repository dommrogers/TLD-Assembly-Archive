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

	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void UpdateLightPosition()
	{
	}

	[CallsUnknownMethods(Count = 28)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void TurnOnEffects()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void DisableEffectsObject()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void SetFresh(bool fresh)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[CallsUnknownMethods(Count = 9)]
	private void TurnOffParticleSystems(Transform parent, bool hardStop)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public FirstPersonLightSource()
	{
	}
}
