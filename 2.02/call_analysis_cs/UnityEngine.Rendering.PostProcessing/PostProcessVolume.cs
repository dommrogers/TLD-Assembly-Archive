using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessVolume : MonoBehaviour
{
	public PostProcessProfile sharedProfile;

	public bool isGlobal;

	public float blendDistance;

	public float weight;

	public float priority;

	private int m_PreviousLayer;

	private float m_PreviousPriority;

	private List<Collider> m_TempColliders;

	private PostProcessProfile m_InternalProfile;

	public PostProcessProfile profile
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	internal PostProcessProfile profileRef
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public bool HasInstantiatedProfile()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsUnknownMethods(Count = 5)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(SphereCollider), Member = "get_center")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(SphereCollider), Member = "get_center")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Gizmos), Member = "DrawMesh")]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	[Calls(Type = typeof(MeshCollider), Member = "set_convex")]
	[Calls(Type = typeof(MeshCollider), Member = "get_convex")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	private void OnDrawGizmos()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PostProcessVolume()
	{
	}
}
