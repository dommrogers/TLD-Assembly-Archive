using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes.ObjectReferences;

namespace TLD.Gameplay;

public class BunkerLocationReference : SceneObjectReference
{
	private string m_Guid;

	public string Guid
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneObjectReference), Member = ".ctor")]
	public BunkerLocationReference()
	{
	}
}
