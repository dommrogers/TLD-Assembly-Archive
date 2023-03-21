using System;
using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid;

	public const int elementId_positionX = 1;

	public const int elementId_positionY = 2;

	public const int elementId_positionZ = 0;

	public const int elementId_rotationX = 3;

	public const int elementId_rotationY = 5;

	public const int elementId_rotationZ = 4;

	public const int elementId_throttle1Axis = 6;

	public const int elementId_throttle1MinDetent = 50;

	public const int elementId_throttle2Axis = 7;

	public const int elementId_throttle2MinDetent = 51;

	public const int elementId_extraAxis1 = 8;

	public const int elementId_extraAxis2 = 9;

	public const int elementId_extraAxis3 = 10;

	public const int elementId_extraAxis4 = 11;

	public const int elementId_button1 = 12;

	public const int elementId_button2 = 13;

	public const int elementId_button3 = 14;

	public const int elementId_button4 = 15;

	public const int elementId_button5 = 16;

	public const int elementId_button6 = 17;

	public const int elementId_button7 = 18;

	public const int elementId_button8 = 19;

	public const int elementId_button9 = 20;

	public const int elementId_button10 = 21;

	public const int elementId_button11 = 22;

	public const int elementId_button12 = 23;

	public const int elementId_button13 = 24;

	public const int elementId_button14 = 25;

	public const int elementId_button15 = 26;

	public const int elementId_button16 = 27;

	public const int elementId_button17 = 28;

	public const int elementId_button18 = 29;

	public const int elementId_button19 = 30;

	public const int elementId_button20 = 31;

	public const int elementId_button21 = 55;

	public const int elementId_button22 = 56;

	public const int elementId_button23 = 57;

	public const int elementId_button24 = 58;

	public const int elementId_button25 = 59;

	public const int elementId_button26 = 60;

	public const int elementId_button27 = 61;

	public const int elementId_button28 = 62;

	public const int elementId_button29 = 63;

	public const int elementId_button30 = 64;

	public const int elementId_button31 = 65;

	public const int elementId_button32 = 66;

	public const int elementId_hat1Up = 32;

	public const int elementId_hat1UpRight = 33;

	public const int elementId_hat1Right = 34;

	public const int elementId_hat1DownRight = 35;

	public const int elementId_hat1Down = 36;

	public const int elementId_hat1DownLeft = 37;

	public const int elementId_hat1Left = 38;

	public const int elementId_hat1UpLeft = 39;

	public const int elementId_hat2Up = 40;

	public const int elementId_hat2UpRight = 41;

	public const int elementId_hat2Right = 42;

	public const int elementId_hat2DownRight = 43;

	public const int elementId_hat2Down = 44;

	public const int elementId_hat2DownLeft = 45;

	public const int elementId_hat2Left = 46;

	public const int elementId_hat2UpLeft = 47;

	public const int elementId_hat1 = 48;

	public const int elementId_hat2 = 49;

	public const int elementId_throttle1 = 52;

	public const int elementId_throttle2 = 53;

	public const int elementId_stick = 54;

	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis3
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EISixDofControllerTemplate_002EextraAxis4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton4
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton5
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton6
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton7
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton8
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton9
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton10
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton11
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton12
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton13
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton14
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton15
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton16
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton17
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton18
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton19
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton20
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton21
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton22
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton23
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton24
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton25
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton26
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton27
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton28
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton29
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton30
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton31
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EISixDofControllerTemplate_002Ebutton32
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EISixDofControllerTemplate_002Ehat1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateHat Rewired_002EISixDofControllerTemplate_002Ehat2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EISixDofControllerTemplate_002Ethrottle1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThrottle Rewired_002EISixDofControllerTemplate_002Ethrottle2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateStick6D Rewired_002EISixDofControllerTemplate_002Estick
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerTemplate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public SixDofControllerTemplate(object payload)
		: base(null)
	{
	}
}
