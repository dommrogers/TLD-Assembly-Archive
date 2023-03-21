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
	[CallerCount(Count = 2)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerAttributes()
	{
	}
}
