using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElectrifiedWater : MonoBehaviour
{
	private bool m_ElectrifiedOnAwake;

	private Renderer m_Renderer;

	private int m_ElectrictyAmountShaderID;

	private bool m_HasInitialized;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Initialize()
	{
	}

	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "Awake")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "Initialize")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "SetExternalPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerControlVolume), Member = "Initialize")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Initialize")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	private void SetElectrified(bool isElectrified)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public ElectrifiedWater()
	{
	}
}
