using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueCategoriesConfiguration : ScriptableObject
{
	public List<DialogueModeRigFP.DialogueChoiceCategoryConfiguration> m_CategoryConfigurations;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DialogueCategoriesConfiguration()
	{
	}
}
