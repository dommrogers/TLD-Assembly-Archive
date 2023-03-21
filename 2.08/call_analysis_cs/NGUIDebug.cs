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
		get
		{
			return default(bool);
		}
		[CallAnalysisFailed]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "LogString")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(UICamera), Member = "Start")]
	[CallerCount(Count = 2)]
	public static void CreateInstance()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NGUIDebug), Member = "Log")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(NGUIDebug), Member = "CreateInstance")]
	private static void LogString(string text)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NGUIDebug), Member = "LogString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static void Log(object[] objs)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Clear()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static void DrawBounds(Bounds b)
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NGUIDebug()
	{
	}
}
