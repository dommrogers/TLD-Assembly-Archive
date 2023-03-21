using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueCategoriesConfiguration : ScriptableObject
{
	public List<DialogueModeRigFP.DialogueChoiceCategoryConfiguration> m_CategoryConfigurations;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public DialogueCategoriesConfiguration()
	{
	}
}
