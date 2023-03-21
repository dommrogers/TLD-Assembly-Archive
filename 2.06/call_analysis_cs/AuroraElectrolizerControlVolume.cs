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

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	public void SetPowerState(bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsActivated()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool HasSetPowerState()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AuroraElectrolizerControlVolume()
	{
	}
}
