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

	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "LateUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Physics), Member = "CheckSphere")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateLightPosition()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOnEffects")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(HeatSource), Member = "TurnOn")]
	[Calls(Type = typeof(Weather), Member = "UseOutdoorLightingForLightSources")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 12)]
	public void TurnOnEffects()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void DisableEffectsObject()
	{
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "EnableEffectsForWeapon")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "TurnOffEffects")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "ResetLightSources")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void Reset()
	{
	}

	[CalledBy(Type = typeof(PlayerAnimation), Member = "Update_Lightsource_Lit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	public void SetFresh(bool fresh)
	{
	}

	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOffEffects")]
	[CalledBy(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParticleSystem), Member = "Clear")]
	[Calls(Type = typeof(FirstPersonLightSource), Member = "TurnOffParticleSystems")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void TurnOffParticleSystems(Transform parent, bool hardStop)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FirstPersonLightSource()
	{
	}
}
