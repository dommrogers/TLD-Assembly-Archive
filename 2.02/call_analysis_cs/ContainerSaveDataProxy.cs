using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ContainerSaveDataProxy
{
	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_ContainerFilterName;

	public string m_ContainerSortName;

	public bool m_InspectedProxy;

	public bool m_CanNeverBeOpened;

	public bool m_RolledSpawnChanceProxy;

	public bool m_NotPopulated;

	public string m_LockSerialized;

	public string m_SafeCrackingSerialized;

	public string m_MissionObjectSerialized;

	public string m_OwnershipOverrideSerialized;

	public List<string> m_GearToInstantiateSerialized;

	public List<ContainerItemSaveData> m_SerializedItems;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Container), Member = ".cctor")]
	[CallsUnknownMethods(Count = 14)]
	public ContainerSaveDataProxy()
	{
	}
}
