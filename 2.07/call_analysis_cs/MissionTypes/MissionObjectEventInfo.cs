using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MissionTypes;

public class MissionObjectEventInfo
{
	public string objectName;

	public MissionObjectClass objectClass;

	public string prefabType;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 2)]
	public MissionObjectEventInfo(MissionObjectIdentifier moi)
	{
	}

	[CallerCount(Count = 0)]
	public MissionObjectEventInfo(string _prefabType)
	{
	}
}
