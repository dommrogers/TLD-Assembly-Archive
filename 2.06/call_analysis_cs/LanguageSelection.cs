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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "set_Language")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CStart_003Eb__2_0()
		{
		}
	}

	private UIPopupList mList;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(LanguageSelection), Member = "Refresh")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(LanguageSelection), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "MaybeLoadLanguageTables")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Localization), Member = "get_Language")]
	[Calls(Type = typeof(UIPopupList), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Refresh()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LanguageSelection()
	{
	}
}
