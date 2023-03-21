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

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CalledBy(Type = typeof(Container), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	public void Deserialize(string data)
	{
	}

	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public OwnershipOverride()
	{
	}
}
