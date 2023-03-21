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

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UICamera), Member = "Start")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "LogString")]
	[CalledBy(Type = typeof(NGUIDebug), Member = "LogString")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void CreateInstance()
	{
	}

	[Calls(Type = typeof(NGUIDebug), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(NGUIDebug), Member = "Log")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public static void DrawBounds(Bounds b)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(NGUITools), Member = "GetHierarchy")]
	[CallsUnknownMethods(Count = 4)]
	private void OnGUI()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NGUIDebug()
	{
	}
}
