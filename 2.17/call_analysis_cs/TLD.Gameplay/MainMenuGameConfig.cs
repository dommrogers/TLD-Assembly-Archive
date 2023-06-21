using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public class MainMenuGameConfig : GameModeConfig
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public MainMenuGameConfig()
	{
	}
}
