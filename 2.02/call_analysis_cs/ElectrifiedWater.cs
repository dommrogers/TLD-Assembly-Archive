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

	[CalledBy(Type = typeof(AuroraElectrolizerControlVolume), Member = "SetPowerState")]
	[CalledBy(Type = typeof(AuroraElectrolizerControlVolume), Member = "Initialize")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Initialize")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "SetExternalPowerState")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "Initialize")]
	[CalledBy(Type = typeof(ElectrifiedWater), Member = "Awake")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	private void SetElectrified(bool isElectrified)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public ElectrifiedWater()
	{
	}
}
