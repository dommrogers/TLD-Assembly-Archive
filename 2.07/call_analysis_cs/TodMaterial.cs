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

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(TimeOfDay), Member = "IsDay")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "set_color")]
	public void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TodMaterial), Member = "UpdateMaterial")]
	public static void UpdateAll()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "SetNormalizedTime")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	[CalledBy(Type = typeof(Rest), Member = "EndSleeping")]
	public static void ForceUpdateAll()
	{
	}

	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateAll")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	private void UpdateMaterial()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	private void UpdateForDawn()
	{
	}

	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsUnknownMethods(Count = 6)]
	private void UpdateForDusk()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TodMaterial()
	{
	}
}
