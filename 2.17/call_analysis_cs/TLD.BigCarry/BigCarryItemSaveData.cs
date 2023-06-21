using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.BigCarry;

public class BigCarryItemSaveData
{
	public bool m_ActiveSelf;

	public string m_Name;

	public Vector3 m_Position;

	public Quaternion m_Rotation;

	public string m_ItemDataSerialized;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BigCarryItemSaveData()
	{
	}
}
