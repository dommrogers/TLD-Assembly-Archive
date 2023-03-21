using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class OwnershipOverride : MonoBehaviour
{
	[Serializable]
	public class SerializedData
	{
		public string m_TrustId;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SerializedData()
		{
		}
	}

	private SerializedData m_SerializedData;

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(Container), Member = "Serialize")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public string GetTrustId()
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public OwnershipOverride()
	{
	}
}
