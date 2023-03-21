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
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare")]
		internal int _003CUpdate_003Eb__4_0(string a, string b)
		{
			return default(int);
		}
	}

	private static ParlayDebug m_Instance;

	private Dictionary<string, Dictionary<string, DebugElement>> m_ActiveElements;

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Time), Member = "get_time")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[CallsUnknownMethods(Count = 31)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ParlayDebug), Member = "SetText")]
	[CallsUnknownMethods(Count = 28)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	private void SetTextInternal(string tag, string title, string text, float duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ParlayDebug), Member = "SetTextInternal")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetText(string tag, string title, string text, float duration = 0f)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ResetInternal()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ParlayDebug()
	{
	}
}
