using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetOverlapSphereObjects : ActionTask<Transform>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Collider, GameObject> _003C_003E9__3_0;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal GameObject _003COnExecute_003Eb__3_0(Collider c)
		{
			return null;
		}
	}

	public LayerMask layerMask;

	public BBParameter<float> radius;

	public BBParameter<List<GameObject>> saveObjectsAs;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 18)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public GetOverlapSphereObjects()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
