using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Pool;

namespace TLD.Gameplay;

public static class DisableForCurrentModeExtensions
{
	[CalledBy(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateAvailableMementos")]
	[CalledBy(Type = typeof(Panel_Log), Member = "IsActiveMemento")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GenericPool<>), Member = "Get")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[Calls(Type = typeof(PooledObject<>), Member = "System.IDisposable.Dispose")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 8)]
	public static bool ShouldDisableForCurrentMode(this GameObject gameObject)
	{
		return false;
	}
}
