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
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	internal PostProcessProfile profileRef
	{
		[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public bool HasInstantiatedProfile()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsUnknownMethods(Count = 10)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	private void Update()
	{
	}

	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(SphereCollider), Member = "get_center")]
	[Calls(Type = typeof(SphereCollider), Member = "get_center")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	[Calls(Type = typeof(Gizmos), Member = "DrawMesh")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	[Calls(Type = typeof(MeshCollider), Member = "get_convex")]
	[Calls(Type = typeof(MeshCollider), Member = "set_convex")]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PostProcessVolume()
	{
	}
}
