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
		[CalledBy(Type = typeof(PostProcessManager), Member = "QuickVolume")]
		[CallsUnknownMethods(Count = 7)]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 60)]
		set
		{
		}
	}

	internal PostProcessProfile profileRef
	{
		[CallerCount(Count = 4)]
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
	public bool HasInstantiatedProfile()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Gizmos), Member = "DrawMesh")]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	[Calls(Type = typeof(MeshCollider), Member = "set_convex")]
	[Calls(Type = typeof(MeshCollider), Member = "get_convex")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 0)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PostProcessVolume()
	{
	}
}
