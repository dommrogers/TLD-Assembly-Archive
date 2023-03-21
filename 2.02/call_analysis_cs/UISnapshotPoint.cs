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
	[Calls(Type = typeof(Component), Member = "get_tag")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UISnapshotPoint()
	{
	}
}
