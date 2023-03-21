using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

	public List<AuroraElectrolizer> m_ElectrolizerList;

	public List<AuroraLightingSimple> m_SimpleLightList;

	public List<Light> m_LooseLightList;

	private ElectrifiedWater[] m_ElectrifiedWater;

	public LocalOverride m_SandboxOverride;

	private bool m_IsActivated;

	private bool m_HasSetPowerState;

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Update")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 6)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraElectrolizerControlVolume()
	{
	}
}
