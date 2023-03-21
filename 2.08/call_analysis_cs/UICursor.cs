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

	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(UICursor), Member = "Set")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	public static void Clear()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UICursor), Member = "Update")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public static void Set(UIAtlas atlas, string sprite)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UICursor()
	{
	}
}
