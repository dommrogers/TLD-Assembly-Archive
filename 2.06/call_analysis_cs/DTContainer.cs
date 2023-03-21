using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class DTContainer : ScriptableObject
{
	public string m_UniqueId;

	public string m_ObjectName;

	public List<DialogueTreeController> m_DialogueTreeControllers;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public DTContainer()
	{
	}
}
