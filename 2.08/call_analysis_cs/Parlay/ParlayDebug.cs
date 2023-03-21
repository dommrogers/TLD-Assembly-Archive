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
			return default(int);
		}
	}

	private static ParlayDebug m_Instance;

	private Dictionary<string, Dictionary<string, DebugElement>> m_ActiveElements;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 31)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ParlayDebug), Member = "SetText")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	private void SetTextInternal(string tag, string title, string text, float duration)
	{
	}

	[Calls(Type = typeof(ParlayDebug), Member = "SetTextInternal")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void SetText(string tag, string title, string text, float duration = 0f)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ResetInternal()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParlayDebug()
	{
	}
}
