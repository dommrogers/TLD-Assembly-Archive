using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class FindObjectsOfType<T> : ActionTask where T : Component
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<T, GameObject> _003C_003E9__2_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal GameObject _003COnExecute_003Eb__2_0(T o)
		{
			return null;
		}
	}

	public BBParameter<List<GameObject>> saveGameObjects;

	public BBParameter<List<T>> saveComponents;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 5)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FindObjectsOfType()
	{
	}
}
