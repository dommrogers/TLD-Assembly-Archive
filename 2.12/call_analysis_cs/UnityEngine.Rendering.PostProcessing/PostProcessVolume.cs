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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
		[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
		[Calls(Type = typeof(Object), Member = "Instantiate")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 70)]
		set
		{
		}
	}

	internal PostProcessProfile profileRef
	{
		[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
		[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
		[CalledBy(Type = typeof(RuntimeUtilities), Member = "DestroyVolume")]
		[CallerCount(Count = 4)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	public bool HasInstantiatedProfile()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "get_instance")]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MeshCollider), Member = "get_convex")]
	[Calls(Type = typeof(MeshCollider), Member = "set_convex")]
	[Calls(Type = typeof(MeshCollider), Member = "get_sharedMesh")]
	[Calls(Type = typeof(Gizmos), Member = "DrawMesh")]
	[Calls(Type = typeof(SphereCollider), Member = "get_radius")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 26)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PostProcessVolume()
	{
	}
}
