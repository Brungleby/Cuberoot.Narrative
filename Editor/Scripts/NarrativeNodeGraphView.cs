
/** NarrativeNodeGraphView.cs
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
using UnityEngine.UIElements;

using UnityEditor;
using UnityEditor.Experimental.GraphView;

using Cuberoot.Editor;

#endregion

namespace Cuberoot.Narrative
{
	/// <summary>
	/// __TODO_ANNOTATE__
	///</summary>

	public sealed class NarrativeNodeGraphView : CustomNodeGraphView
	{
		#region Data

		#region



		#endregion

		#endregion
		#region Methods

		#region Construction

		public NarrativeNodeGraphView() : base()
		{
			Debug.Log("Hi");
			CreateEntryPointNode();

		}

		#endregion

		#region

		private CustomNode CreateEntryPointNode()
		{
			var __resultNode = CreateNewNode<CustomNode>("START", Vector2.zero);

			var __port_out = __resultNode.CreatePort("Out", Direction.Output, Orientation.Horizontal, Port.Capacity.Single);

			__resultNode.outputContainer.Add(__port_out);
			__resultNode.RefreshAll();

			return __resultNode;
		}

		#endregion

		#endregion
	}
}
