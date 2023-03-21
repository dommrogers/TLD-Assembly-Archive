using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PowderItem : MonoBehaviour
{
	private class SaveData
	{
		public float m_WeightKG;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public SaveData()
		{
		}
	}

	public GearPowderType m_Type;

	public float m_WeightKG;

	public float m_WeightLimitKG;

	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float Add(float amount)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PowderItem()
	{
	}
}
