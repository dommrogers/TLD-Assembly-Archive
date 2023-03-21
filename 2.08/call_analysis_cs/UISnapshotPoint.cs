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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = "get_tag")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	public UISnapshotPoint()
	{
	}
}
