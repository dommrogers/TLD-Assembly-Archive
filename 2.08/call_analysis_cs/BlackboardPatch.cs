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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "Update")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	private void ApplyPatch()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public BlackboardPatch()
	{
	}
}
