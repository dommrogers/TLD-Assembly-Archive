using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;

public class Dialogue_Speech_Utils
{
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_HideChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_ShowChoice), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetShowChoiceVariableName(int choiceIndex, string uniqueName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Dialogue_Speech_Utils()
	{
	}
}
