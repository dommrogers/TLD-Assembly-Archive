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

	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = "get_mainTexture")]
	public void Awake()
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(TodMaterial), Member = "ForceUpdateAll")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "IsNight")]
	public void ForceUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(GameManager), Member = "UpdateNotPaused")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TodMaterial), Member = "UpdateMaterial")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void UpdateAll()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TodMaterial), Member = "ForceUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "ForceUpdateTodObjects")]
	public static void ForceUpdateAll()
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(TodMaterial), Member = "UpdateAll")]
	[CallAnalysisFailed]
	private void UpdateMaterial()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDawn")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	private void UpdateForDawn()
	{
	}

	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Color), Member = "Lerp")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniStormWeatherSystem), Member = "GetProgressDusk")]
	private void UpdateForDusk()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TodMaterial()
	{
	}
}
