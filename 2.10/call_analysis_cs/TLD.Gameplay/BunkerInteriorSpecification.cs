using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

public class BunkerInteriorSpecification : ScriptableObject
{
	private SceneSet m_Interior;

	private string m_ExitPointName;

	public SceneSet Interior
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
	}

	public string ExitPointName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public BunkerInteriorSpecification()
	{
	}
}
