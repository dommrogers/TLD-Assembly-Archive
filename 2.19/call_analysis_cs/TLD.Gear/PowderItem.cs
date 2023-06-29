using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

namespace TLD.Gear;

public class PowderItem : MonoBehaviour
{
	private class SaveData
	{
		public float m_WeightKG;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SaveData()
		{
		}
	}

	public PowderType m_Type;

	public float m_WeightKG;

	public float m_WeightLimitKG;

	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CallerCount(Count = 2)]
	public float Add(float amount)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PowderItem()
	{
	}
}
