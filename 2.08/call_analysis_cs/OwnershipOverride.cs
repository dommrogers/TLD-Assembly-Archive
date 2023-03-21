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

	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	public void Deserialize(string data)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[CallsUnknownMethods(Count = 1)]
	public void SetTrustId(string trustId)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public string GetTrustId()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public OwnershipOverride()
	{
	}
}
