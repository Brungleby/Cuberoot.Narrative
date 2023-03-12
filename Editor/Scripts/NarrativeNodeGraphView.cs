
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

		#endregion

		#region Overrides

		public override void CreatePredefinedNodes()
		{
			#region Start Node

			var __resultNode = CreateNewNode<CustomNode>(null, null, "START");
			__resultNode.IsPredefined = true;

			var __port_out = __resultNode.CreatePort("Out", Direction.Output, Orientation.Horizontal, Port.Capacity.Single);

			__resultNode.outputContainer.Add(__port_out);
			__resultNode.RefreshAll();

			#endregion
		}

		public override List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
		{
			return new List<SearchTreeEntry>
			{
				new SearchTreeGroupEntry(new GUIContent("Available Nodes"), 0),
					new SearchTreeEntry(new GUIContent("Custom Node"))
						{ level = 1, userData = typeof(CustomNode) },
					new SearchTreeEntry(new GUIContent("Dialogue Node"))
						{ level = 1, userData = typeof(NarrativeNode) },
			};
		}

		#endregion

		#endregion
	}
}
