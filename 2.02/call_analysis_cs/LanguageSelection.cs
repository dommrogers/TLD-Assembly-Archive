using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LanguageSelection : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__2_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "set_Language")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStart_003Eb__2_0()
		{
		}
	}

	private UIPopupList mList;

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LanguageSelection), Member = "Refresh")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Localization), Member = "GetLanguages")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(LanguageSelection), Member = "Awake")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Refresh()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LanguageSelection()
	{
	}
}
