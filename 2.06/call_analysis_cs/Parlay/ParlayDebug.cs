using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Parlay;

public class ParlayDebug : MonoBehaviour
{
	private class DebugElement
	{
		public string m_Title;

		public string m_Text;

		public float m_ExpireTime;

		[CallerCount(Count = 0)]
		public DebugElement(string title, string text, float expireTime)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<string> _003C_003E9__4_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal int _003CUpdate_003Eb__4_0(string a, string b)
		{
			return 0;
		}
	}

	private static ParlayDebug m_Instance;

	private Dictionary<string, Dictionary<string, DebugElement>> m_ActiveElements;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Sort")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 31)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ParlayDebug), Member = "SetText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	private void SetTextInternal(string tag, string title, string text, float duration)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ParlayDebug), Member = "SetTextInternal")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetText(string tag, string title, string text, float duration = 0f)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void ResetInternal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public ParlayDebug()
	{
	}
}
