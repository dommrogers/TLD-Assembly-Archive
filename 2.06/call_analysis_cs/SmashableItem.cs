using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class SmashableItem : MonoBehaviour
{
	public int m_MinPercentLoss;

	public int m_MaxPercentLoss;

	public int m_TimeToSmash;

	public string m_SmashAudio;

	public bool m_HasBeenSmashed;

	private static SmashableItemSaveDataProxy m_SmashableItemSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public void Deserialize(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public bool NeedsToBeSmashedOpen()
	{
		return default(bool);
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public SmashableItem()
	{
	}
}
