using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetLinecastInfo2DAll : ActionTask<Transform>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<RaycastHit2D, GameObject> _003C_003E9__7_0;

		public static Func<RaycastHit2D, float> _003C_003E9__7_1;

		public static Func<RaycastHit2D, Vector2> _003C_003E9__7_2;

		public static Func<RaycastHit2D, Vector2> _003C_003E9__7_3;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RaycastHit2D), Member = "get_collider")]
		[CallsUnknownMethods(Count = 2)]
		internal GameObject _003COnExecute_003Eb__7_0(RaycastHit2D h)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal float _003COnExecute_003Eb__7_1(RaycastHit2D h)
		{
			return default(float);
		}

		[CallerCount(Count = 0)]
		internal Vector2 _003COnExecute_003Eb__7_2(RaycastHit2D h)
		{
			return default(Vector2);
		}

		[CallerCount(Count = 0)]
		internal Vector2 _003COnExecute_003Eb__7_3(RaycastHit2D h)
		{
			return default(Vector2);
		}
	}

	public BBParameter<GameObject> target;

	public LayerMask mask;

	public BBParameter<List<GameObject>> saveHitGameObjectsAs;

	public BBParameter<List<float>> saveDistancesAs;

	public BBParameter<List<Vector3>> savePointsAs;

	public BBParameter<List<Vector3>> saveNormalsAs;

	private RaycastHit2D[] hits;

	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 76)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Physics2D), Member = "LinecastAll")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	public GetLinecastInfo2DAll()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
