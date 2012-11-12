#region license
// This file is part of Polaris API Library.
// 
// Polaris API Library is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Polaris API Library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Polaris API Library. If not, see http://www.gnu.org/licenses.
#endregion
namespace Clc.Polaris.Api
{
	/// <summary>
	/// The response to a HoldRequestReply call.
	/// </summary>
	public class HoldRequestReplyData
	{
		/// <summary>
		/// Txn group qualifier.
		/// </summary>
		public string TxnGroupQualifier { get; set; }

		/// <summary>
		/// Txn qualifier.
		/// </summary>
		public string TxnQualifier { get; set; }

		/// <summary>
		/// The org ID of the branch processing the request.
		/// </summary>
		public int RequestingOrgID { get; set; }

		/// <summary>
		/// The answer. 1 - Yes. 0 - No or Cancel
		/// </summary>
		public int Answer { get; set; }

		/// <summary>
		/// Which conditional will this answer be applied to? 
		/// 1 - Item available locally
		/// 2 - Accept ILL policy
		/// 3 - Accept even with existing holds
		/// 4 - No items attached, still place hold
		/// 5 - Accept local hold policy (charge)
		/// </summary>
		public int State { get; set; }
	}
}