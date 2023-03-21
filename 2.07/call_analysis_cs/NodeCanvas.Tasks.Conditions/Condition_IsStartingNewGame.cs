using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsStartingNewGame : ConditionTask
{
	[Calls(Type = typeof(SaveGameSystem), Member = "IsRestoreInProgress")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "MatchesMainMenuSceneName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetSceneAt")]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsStartingNewGame()
	{
	}
}
