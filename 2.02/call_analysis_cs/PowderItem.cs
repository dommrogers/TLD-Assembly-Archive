using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PowderItem : MonoBehaviour
{
	private class SaveData
	{
		public float m_WeightKG;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SaveData()
		{
		}
	}

	public GearPowderType m_Type;

	public float m_WeightKG;

	public float m_WeightLimitKG;

	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float Add(float amount)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	public void Deserialize(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public PowderItem()
	{
	}
}
