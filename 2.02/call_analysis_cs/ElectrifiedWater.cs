using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ElectrifiedWater : MonoBehaviour
{
	private bool m_ElectrifiedOnAwake;

	private Renderer m_Renderer;

	private int m_ElectrictyAmountShaderID;

	private bool m_HasInitialized;

	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	[CallerCount(Count = 0)]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ElectrifiedWater), Member = "SetElectrified")]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "Awake")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "Initialize")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "SetExternalPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AuroraElectrolizerControlVolume), Member = "Initialize")]
	private void SetElectrified(bool isElectrified)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public ElectrifiedWater()
	{
	}
}
