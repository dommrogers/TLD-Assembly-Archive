using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.ModularElectrolizer;
using UnityEngine;

public class AuroraElectrolizerControlVolume : MonoBehaviour
{
	public enum LocalOverride
	{
		UseAurora,
		ForceOff
	}

	public string m_VolumeName;

	public int m_VolumeID;

	public List<AuroraModularElectrolizer> m_ElectrolizerList;

	public List<AuroraLightingSimple> m_SimpleLightList;

	public List<Light> m_LooseLightList;

	private ElectrifiedWater[] m_ElectrifiedWater;

	public LocalOverride m_SandboxOverride;

	private bool m_IsActivated;

	private bool m_HasSetPowerState;

	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	public void SetPowerState(bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActivated()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasSetPowerState()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AuroraElectrolizerControlVolume()
	{
	}
}
