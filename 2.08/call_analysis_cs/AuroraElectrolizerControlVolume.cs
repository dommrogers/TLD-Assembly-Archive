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
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasSetPowerState()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AuroraElectrolizerControlVolume()
	{
	}
}
