using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using TLD.Serialization;
using UnityEngine;

public class OwnershipOverride : MonoBehaviour
{
	[Serializable]
	public class SerializedData
	{
		public string m_TrustId;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SerializedData()
		{
		}
	}

	private SerializedData m_SerializedData;

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string data)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[CallsUnknownMethods(Count = 1)]
	public void SetTrustId(string trustId)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetTrustId()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public OwnershipOverride()
	{
	}
}
