using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
	public PlayerAttributesSaveData m_SaveData;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerAttributes()
	{
	}
}
