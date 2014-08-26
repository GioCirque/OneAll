﻿using System.Runtime.Serialization;

namespace OneAll.Sharing.Analytics
{
	/// <summary>The result of a sharing analytics snapshot request.</summary>
	[DataContract()]
	public class CompletedSnapshotResult : BaseObject
	{
		#region Member Variables

		/// <summary>The snapshot summary.</summary>
		private CompletedSnapshot _snapshot;

		#endregion Member Variables

		#region Properties

		#region Snapshot
		/// <summary>The snapshot summary.</summary>
		[DataMember(Name = "sharing_analytics_snapshot", IsRequired = false, EmitDefaultValue = false)]
		public CompletedSnapshot Snapshot
		{
			get { return _snapshot; }
			set { _snapshot = value; OnPropertyChanged("Snapshot"); }
		}
		#endregion Snapshot

		#endregion Properties
	}
}