using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueCategoriesConfiguration : ScriptableObject
{
	public List<DialogueModeRigFP.DialogueChoiceCategoryConfiguration> m_CategoryConfigurations;

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public DialogueCategoriesConfiguration()
	{
	}
}
