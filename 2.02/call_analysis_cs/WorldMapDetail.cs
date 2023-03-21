using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WorldMapDetail : MonoBehaviour
{
	private string m_ObjectGuid;

	[DeduplicatedMethod]
	[CallerCount(Count = 29)]
	public string Guid()
	{
		return null;
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WorldMapDetail()
	{
	}
}
