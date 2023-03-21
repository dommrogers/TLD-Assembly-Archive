using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gameplay;

public static class DisableForCurrentModeExtensions
{
	[CalledBy(Type = typeof(Panel_Log), Member = "IsActiveMemento")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static bool ShouldDisableForCurrentMode(this GameObject gameObject)
	{
		return default(bool);
	}
}
