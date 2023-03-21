using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NGUIDebug : MonoBehaviour
{
	private static bool mRayDebug;

	private static List<string> mLines;

	private static NGUIDebug mInstance;

	public static bool debugRaycast
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallAnalysisFailed]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "LogString")]
	[CalledBy(Type = typeof(UICamera), Member = "Start")]
	public static void CreateInstance()
	{
	}

	[Calls(Type = typeof(NGUIDebug), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(NGUIDebug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private static void LogString(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NGUIDebug), Member = "LogString")]
	[CallsUnknownMethods(Count = 7)]
	public static void Log(object[] objs)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	public static void DrawBounds(Bounds b)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[CallerCount(Count = 0)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NGUIDebug()
	{
	}
}
