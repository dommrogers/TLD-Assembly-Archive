using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GenericIndoors : MonoBehaviour
{
	public Texture2D m_ColourGradingLUT;

	public ColorGradingSettings m_ColourGradingSettings;

	public static List<GenericIndoors> m_GenericIndoorsList;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Weather), Member = "ForceIndoorEnvironment")]
	[Calls(Type = typeof(GameManager), Member = "GetUniStorm")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ColorGrading), Member = "UpdateLutForTimeOfDay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GenericIndoors()
	{
	}
}
