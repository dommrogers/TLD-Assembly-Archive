using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None,
		Vertical,
		Horizontal,
		Explicit
	}

	public static BetterList<UIKeyNavigation> list;

	public static KeyCode lastKeycodeUsed;

	public Constraint constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public GameObject[] onLeftBackup;

	public GameObject[] onRightBackup;

	public GameObject[] onUpBackup;

	public GameObject[] onDownBackup;

	public bool startsSelected;

	private UIKeyNavigation onLeftNav;

	private UIKeyNavigation onRightNav;

	private UIKeyNavigation onUpNav;

	private UIKeyNavigation onDownNav;

	private BetterList<UIKeyNavigation> onLeftNavBackup;

	private BetterList<UIKeyNavigation> onRightNavBackup;

	private BetterList<UIKeyNavigation> onUpNavBackup;

	private BetterList<UIKeyNavigation> onDownNavBackup;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	protected GameObject GetLeft()
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	private GameObject GetRight()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	protected GameObject GetUp()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	protected GameObject GetDown()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	protected GameObject Get(Vector3 myDir, bool horizontal)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	protected static Vector3 GetCenter(GameObject go)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	protected virtual void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	protected virtual void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIKeyNavigation()
	{
	}
}
