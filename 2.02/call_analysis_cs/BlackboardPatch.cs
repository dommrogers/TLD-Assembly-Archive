using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using UnityEngine;

public class BlackboardPatch : MonoBehaviour
{
	[Serializable]
	public struct Patch
	{
		public string m_Key;

		public float m_Value;
	}

	public List<Patch> m_PatchList;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	public void Update()
	{
	}

	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void ApplyPatch()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public BlackboardPatch()
	{
	}
}
