using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;

public class Dialogue_Speech_Utils
{
	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Action_ShowChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_HideChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	public static string GetShowChoiceVariableName(int choiceIndex, string uniqueName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public Dialogue_Speech_Utils()
	{
	}
}
