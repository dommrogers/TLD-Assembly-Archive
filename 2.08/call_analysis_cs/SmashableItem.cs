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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool NeedsToBeSmashedOpen()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SmashableItem()
	{
	}
}
