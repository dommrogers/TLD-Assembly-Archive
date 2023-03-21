using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UISnapshotPoint : MonoBehaviour
{
	public bool isOrthographic;

	public float nearClip;

	public float farClip;

	public int fieldOfView;

	public float orthoSize;

	public Texture2D thumbnail;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public UISnapshotPoint()
	{
	}
}
