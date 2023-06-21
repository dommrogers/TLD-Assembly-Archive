using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICursor : MonoBehaviour
{
	public static UICursor instance;

	public Camera uiCamera;

	private Transform mTrans;

	private UISprite mSprite;

	private UIAtlas mAtlas;

	private string mSpriteName;

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UICursor), Member = "Set")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 16)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallerCount(Count = 1)]
	public static void Clear()
	{
	}

	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UICursor), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void Set(UIAtlas atlas, string sprite)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UICursor()
	{
	}
}
