
/** NarrativeNode.cs
*
*	Created by LIAM WOFFORD of CUBEROOT SOFTWARE, LLC.
*
*	Free to use or modify, with or without creditation,
*	under the Creative Commons 0 License.
*/

#region Includes

using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using UnityEditor;
using UnityEditor.Experimental.GraphView;

using Cuberoot.Editor;

#endregion

namespace Cuberoot.Narrative
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>

	public sealed class NarrativeNode : CustomNode
	{
		#region Data

		#region

		// public string DialogueText;
		// public AudioClip DialogueAudio;

		#endregion

		#endregion
		#region Methods

		#region Constructor

		public NarrativeNode() : base()
		{
			CreateExecutiveInputPort();
			CreateExecutiveOutputPort();
		}

		public void CreateExecutiveInputPort(string name = null)
		{
			CreatePort<bool>(name ?? string.Empty, Direction.Input, Orientation.Horizontal, Port.Capacity.Multi);
		}
		public void CreateExecutiveOutputPort(string name = null)
		{
			CreatePort<bool>(name ?? string.Empty, Direction.Output, Orientation.Horizontal, Port.Capacity.Single);
		}

		#endregion

		#region

		public override string DefaultName => "Dialogue";
		public override Vector2 DefaultSize => new Vector2(400f, 400f);

		#endregion

		#endregion
	}
}
