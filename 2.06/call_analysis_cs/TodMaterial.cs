using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TodMaterial : MonoBehaviour
{
	public Material m_Material;

	public Color m_DayColor;

	public Color m_NightColor;

	public bool m_StoryOnly;

	private int m_MaterialIndex;

	private bool m_ForcedUpdate;

	private Renderer m_Renderer;

	private static List<TodMaterial> m_TodMaterials;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	public void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TodMaterial), Member = "UpdateMaterial")]
	public static void UpdateAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void ForceUpdateAll()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateAll")]
	[CallAnalysisFailed]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateForDawn()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	private void UpdateForDusk()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public TodMaterial()
	{
	}
}
