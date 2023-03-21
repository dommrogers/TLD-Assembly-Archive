using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WorldMapDetail : MonoBehaviour
{
	private string m_ObjectGuid;

	[DeduplicatedMethod]
	[CallerCount(Count = 35)]
	public string Guid()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WorldMapDetail()
	{
	}
}
