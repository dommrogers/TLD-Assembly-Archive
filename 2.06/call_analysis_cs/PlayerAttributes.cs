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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PlayerAttributes()
	{
	}
}
