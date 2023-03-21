using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;

public class Dialogue_Speech_Utils
{
	[CalledBy(Type = typeof(Action_ShowChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_HideChoice), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	public static string GetShowChoiceVariableName(int choiceIndex, string uniqueName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public Dialogue_Speech_Utils()
	{
	}
}
