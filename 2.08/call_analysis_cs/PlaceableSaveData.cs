using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlaceableSaveData
{
	public bool m_ActiveSelf;

	public string m_Name;

	public string m_PrefabName;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_CarryableBodySerialized;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlaceableSaveData()
	{
	}
}
