using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	protected int framerate;

	public bool ignoreTimeScale;

	public bool loop;

	public Sprite[] frames;

	private SpriteRenderer mUnitySprite;

	private UI2DSprite mNguiSprite;

	private int mIndex;

	private float mUpdate;

	public bool isPlaying
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 59)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public int framesPerSecond
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		get
		{
			return 0;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Play()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Pause()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsUnknownMethods(Count = 1)]
	public void ResetToBeginning()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UI2DSpriteAnimation), Member = "UpdateSprite")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Play")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "ResetToBeginning")]
	[CalledBy(Type = typeof(UI2DSpriteAnimation), Member = "Start")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateSprite()
	{
	}

	[CallerCount(Count = 0)]
	public UI2DSpriteAnimation()
	{
	}
}
